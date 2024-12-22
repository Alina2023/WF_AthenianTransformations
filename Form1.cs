using Emgu.CV.Structure;
using Emgu.CV;
using Emgu.CV.CvEnum;
using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;

namespace WF_AthenianTransformations
{
    public partial class Form1 : Form
    {
        private List<PointF> selectedPoints = new List<PointF>();
        private Image<Bgr, byte> sourceImage;  // Исходное изображение
        private Image<Bgr, byte> scaledImage; // Масштабированное изображение
        private Image<Bgr, byte> originalImage;  // Переменная для хранения исходного изображения


        public Form1()
        {
            InitializeComponent();
            // Привязываем обработчик к событию клика по ImageBox
            imageBox1.MouseClick += new MouseEventHandler(imageBox1_MouseClick);
        }

        private void buttonLoadImage_Click(object sender, EventArgs e)
        {
            // Создаем диалоговое окно для выбора файла
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Отображаем диалог и получаем результат
            var result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)  // Если файл выбран
            {
                string fileName = openFileDialog.FileName;  // Получаем путь к выбранному файлу

                // Загружаем изображение
                sourceImage = new Image<Bgr, byte>(fileName);  // Создаем объект Image из выбранного файла


                // Сохраняем исходное изображение для сброса
                originalImage = sourceImage.Clone();  // Клонируем изображение, чтобы не изменять оригинал

                // Получаем текущие размеры ImageBox1
                int width = imageBox1.Width;
                int height = imageBox1.Height;

                // Вычисляем новые размеры изображения, чтобы оно заполнило ImageBox1, сохраняя пропорции
                double ratio = Math.Max((double)width / sourceImage.Width, (double)height / sourceImage.Height);
                int newWidth = (int)(sourceImage.Width * ratio);
                int newHeight = (int)(sourceImage.Height * ratio);

                // Изменяем размер изображения, сохраняя пропорции
                Image<Bgr, byte> resizedImage = sourceImage.Resize(newWidth, newHeight, Emgu.CV.CvEnum.Inter.Linear);

                // Обрезаем лишнюю часть изображения, если оно больше по размеру
                int xOffset = (resizedImage.Width - width) / 2;
                int yOffset = (resizedImage.Height - height) / 2;

                // Создаем изображение нужного размера
                Image<Bgr, byte> croppedImage = resizedImage.Copy(new System.Drawing.Rectangle(xOffset, yOffset, width, height));

                // Отображаем центрированное и обрезанное изображение в imageBox1
                imageBox1.Image = croppedImage;
            }
        }
        private void buttonShiftImage_Click_1(object sender, EventArgs e)
        {
            // Проверяем, загружено ли изображение
            if (sourceImage == null)
            {
                MessageBox.Show("Сначала загрузите изображение!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Получаем значения сдвига от пользователя
            float shiftX = (float)numericUpDownShiftX.Value;
            float shiftY = (float)numericUpDownShiftY.Value;

            // Создаем матрицу аффинного преобразования для сдвига
            Mat transformationMatrix = new Mat(2, 3, Emgu.CV.CvEnum.DepthType.Cv32F, 1);

            // Применяем формулы для сдвига по X и Y
            float[] transformationArray = { 1, 0, shiftX, 0, 1, shiftY };
            transformationMatrix.SetTo(transformationArray);

            // Создаем пустое изображение для результата
            Mat shiftedImage = new Mat();

            // Применяем аффинное преобразование для сдвига
            CvInvoke.WarpAffine(
                sourceImage.Mat,             // Исходное изображение
                shiftedImage,                // Результат
                transformationMatrix,        // Матрица сдвига
                sourceImage.Size,            // Размер выходного изображения
                Emgu.CV.CvEnum.Inter.Linear  // Метод интерполяции (Linear)
            );

            // Проверка, не пустое ли изображение после сдвига
            if (shiftedImage.IsEmpty)
            {
                MessageBox.Show("Изображение после сдвига пустое!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Проверяем размер сдвинутого изображения
            Console.WriteLine("Размер сдвинутого изображения: " + shiftedImage.Size);

            // Преобразуем Mat в Image для отображения в ImageBox2
            imageBox2.Image?.Dispose(); // Освобождаем ресурсы
            Image<Bgr, byte> imageToShow = shiftedImage.ToImage<Bgr, byte>();

            // Получаем текущие размеры ImageBox2
            int boxWidth = imageBox2.Width;
            int boxHeight = imageBox2.Height;

            // Рассчитываем коэффициент масштабирования для сохранения пропорций
            double ratio = Math.Min((double)boxWidth / imageToShow.Width, (double)boxHeight / imageToShow.Height);

            // Новые размеры изображения с учетом пропорций
            int newWidth = (int)(imageToShow.Width * ratio);
            int newHeight = (int)(imageToShow.Height * ratio);

            // Масштабируем изображение с сохранением пропорций
            Image<Bgr, byte> resizedShiftedImage = imageToShow.Resize(newWidth, newHeight, Emgu.CV.CvEnum.Inter.Linear);

            // Отображаем результат в ImageBox2
            imageBox2.Image = resizedShiftedImage;
        }

        private void buttonScaleImage_Click(object sender, EventArgs e)
        {
            if (sourceImage == null)
            {
                MessageBox.Show("Сначала загрузите изображение!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double scaleX = (double)numericUpDownScaleX.Value;
            double scaleY = (double)numericUpDownScaleY.Value;

            if (scaleX <= 0 || scaleY <= 0)
            {
                MessageBox.Show("Коэффициенты масштабирования должны быть больше 0!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Рассчитываем новые размеры на основе масштабов
                int newWidth = (int)(sourceImage.Width * scaleX);
                int newHeight = (int)(sourceImage.Height * scaleY);

                // Масштабируем изображение
                scaledImage = sourceImage.Resize(newWidth, newHeight, Emgu.CV.CvEnum.Inter.Linear);

                // Отображаем результат
                imageBox2.Image?.Dispose(); // Освобождаем ресурсы
                imageBox2.Image = scaledImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка масштабирования: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRotateImage_Click(object sender, EventArgs e)
        {
            // Проверяем, загружено ли изображение
            if (sourceImage == null)
            {
                MessageBox.Show("Сначала загрузите изображение!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Получаем угол поворота от пользователя
            double angle = (double)numericUpDownAngle.Value;

            // Указываем центр вращения
            float centerX = (float)numericUpDownCenterX.Value;
            float centerY = (float)numericUpDownCenterY.Value;
            PointF centerPoint = new PointF(centerX, centerY);

            // Создаем матрицу поворота
            Mat rotationMatrix = new Mat();
            CvInvoke.GetRotationMatrix2D(centerPoint, angle, 1.0, rotationMatrix);

            // Размер изображения
            Size size = new Size(sourceImage.Width, sourceImage.Height);

            // Создаем изображение для результата
            Mat rotatedImage = new Mat();

            // Применяем матрицу поворота
            CvInvoke.WarpAffine(
                sourceImage,                     // Исходное изображение
                rotatedImage,                    // Результирующее изображение
                rotationMatrix,                  // Матрица поворота
                size,                            // Размер выходного изображения
                Emgu.CV.CvEnum.Inter.Linear,    // Метод интерполяции
                Emgu.CV.CvEnum.Warp.FillOutliers // Тип обработки выходных границ
            );

            // Отображаем результат в ImageBox2
            imageBox2.Image?.Dispose();
            imageBox2.Image = rotatedImage.ToImage<Bgr, byte>();
        }

        private void buttonReflectHorisontal_Click(object sender, EventArgs e)
        {
            // Проверяем, загружено ли изображение
            if (sourceImage == null)
            {
                MessageBox.Show("Сначала загрузите изображение!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Создаем матрицу для отражения по горизонтали (по оси X)
            Mat reflectionMatrix = new Mat(2, 3, Emgu.CV.CvEnum.DepthType.Cv32F, 1);
            // Отражение по оси X: qX = -1, сдвиг по X: sourceImage.Width
            float[] transformationArray = { -1, 0, sourceImage.Width, 0, 1, 0 };
            reflectionMatrix.SetTo(transformationArray);

            // Применяем аффинное преобразование для отражения
            Mat reflectedImage = new Mat();
            CvInvoke.WarpAffine(
                sourceImage.Mat,             // Исходное изображение
                reflectedImage,              // Результат
                reflectionMatrix,            // Матрица отражения
                sourceImage.Size,            // Размер выходного изображения
                Emgu.CV.CvEnum.Inter.Linear  // Метод интерполяции
            );

            // Проверка, не пустое ли изображение после отражения
            if (reflectedImage.IsEmpty)
            {
                MessageBox.Show("Изображение после отражения пустое!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Преобразуем Mat в Image для отображения в ImageBox2
            imageBox2.Image?.Dispose(); // Освобождаем ресурсы
            Image<Bgr, byte> imageToShow = reflectedImage.ToImage<Bgr, byte>();

            // Отображаем результат в ImageBox2
            imageBox2.Image = imageToShow;
        }

        private void buttonReflectVertical_Click(object sender, EventArgs e)
        {
            // Проверяем, загружено ли изображение
            if (sourceImage == null)
            {
                MessageBox.Show("Сначала загрузите изображение!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Создаем матрицу для отражения по вертикали (по оси Y)
            Mat reflectionMatrix = new Mat(2, 3, Emgu.CV.CvEnum.DepthType.Cv32F, 1);
            // Отражение по оси Y: qY = -1, сдвиг по Y: sourceImage.Height
            float[] transformationArray = { 1, 0, 0, 0, -1, sourceImage.Height };
            reflectionMatrix.SetTo(transformationArray);

            // Применяем аффинное преобразование для отражения
            Mat reflectedImage = new Mat();
            CvInvoke.WarpAffine(
                sourceImage.Mat,             // Исходное изображение
                reflectedImage,              // Результат
                reflectionMatrix,            // Матрица отражения
                sourceImage.Size,            // Размер выходного изображения
                Emgu.CV.CvEnum.Inter.Linear  // Метод интерполяции
            );

            // Проверка, не пустое ли изображение после отражения
            if (reflectedImage.IsEmpty)
            {
                MessageBox.Show("Изображение после отражения пустое!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Преобразуем Mat в Image для отображения в ImageBox2
            imageBox2.Image?.Dispose(); // Освобождаем ресурсы
            Image<Bgr, byte> imageToShow = reflectedImage.ToImage<Bgr, byte>();

            // Отображаем результат в ImageBox2
            imageBox2.Image = imageToShow;
        }

        private void ApplyBilinearInterpolationOnScale(double scaleX, double scaleY)
        {
            // Проверяем, загружено ли изображение
            if (sourceImage == null)
            {
                MessageBox.Show("Сначала загрузите изображение!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Устанавливаем новый размер изображения с учетом коэффициентов масштабирования
            Size newSize = new Size((int)(sourceImage.Width * scaleX), (int)(sourceImage.Height * scaleY));

            // Применяем масштабирование с билинейной интерполяцией
            Mat scaledImage = new Mat();
            CvInvoke.Resize(
                sourceImage.Mat,       // Исходное изображение
                scaledImage,           // Результат
                newSize,               // Новый размер
                0, 0,                  // Коэффициенты масштабирования по X и Y (если не указаны, масштабирование по умолчанию)
                Emgu.CV.CvEnum.Inter.Linear  // Билинейная интерполяция
            );

            // Проверка, не пустое ли изображение после масштабирования
            if (scaledImage.IsEmpty)
            {
                MessageBox.Show("Изображение после масштабирования пустое!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Преобразуем Mat в Image для отображения в ImageBox2
            imageBox2.Image?.Dispose(); // Освобождаем ресурсы
            Image<Bgr, byte> imageToShow = scaledImage.ToImage<Bgr, byte>();

            // Отображаем результат в ImageBox2
            imageBox2.Image = imageToShow;
        }

        private void ApplyBilinearInterpolationOnRotate(double angle)
        {
            // Проверяем, загружено ли изображение
            if (sourceImage == null)
            {
                MessageBox.Show("Сначала загрузите изображение!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Вычисляем центр изображения для поворота
            PointF center = new PointF(sourceImage.Width / 2, sourceImage.Height / 2);

            // Создаем матрицу для поворота
            Mat rotationMatrix = new Mat();

            // Получаем матрицу поворота
            CvInvoke.GetRotationMatrix2D(center, angle, 1.0, rotationMatrix);

            // Применяем аффинное преобразование (поворот) с билинейной интерполяцией
            Mat rotatedImage = new Mat();
            CvInvoke.WarpAffine(sourceImage.Mat, rotatedImage, rotationMatrix, sourceImage.Size, Inter.Linear);

            // Проверка, не пустое ли изображение после поворота
            if (rotatedImage.IsEmpty)
            {
                MessageBox.Show("Изображение после поворота пустое!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Преобразуем Mat в Image для отображения в ImageBox2
            imageBox2.Image?.Dispose(); // Освобождаем ресурсы
            Image<Bgr, byte> imageToShow = rotatedImage.ToImage<Bgr, byte>();

            // Отображаем результат в ImageBox2
            imageBox2.Image = imageToShow;
        }
        private void ApplyHomography()
        {
            if (selectedPoints.Count == 4)
            {
                // Точки на исходном изображении (выбранные пользователем)
                PointF[] srcPoints = selectedPoints.ToArray();

                // Точки на целевой плоскости
                PointF[] destPoints = new PointF[]
                {
            new PointF(0, 0),
            new PointF(0, sourceImage.Height - 1),
            new PointF(sourceImage.Width - 1, sourceImage.Height - 1),
            new PointF(sourceImage.Width - 1, 0)
                };

                // Находим матрицу гомографической проекции
                var homographyMatrix = CvInvoke.GetPerspectiveTransform(srcPoints, destPoints);

                // Применяем гомографию (проекцию) на изображение
                var destImage = new Image<Bgr, byte>(sourceImage.Size);
                CvInvoke.WarpPerspective(sourceImage, destImage, homographyMatrix, destImage.Size);

                // Отображаем результат в ImageBox2
                imageBox2.Image?.Dispose();  // Освобождаем ресурсы, если изображение уже было
                imageBox2.Image = destImage;
            }
        }
        private void imageBox1_MouseClick(object sender, MouseEventArgs e)
        {
            // Получаем координаты клика с учетом масштаба изображения
            int x = (int)(e.Location.X / imageBox1.ZoomScale);
            int y = (int)(e.Location.Y / imageBox1.ZoomScale);

            // Если точек меньше 4, добавляем точку в список
            if (selectedPoints.Count < 4)
            {
                selectedPoints.Add(new PointF(x, y));

                // Рисуем маленький круг на изображении в месте клика
                Point center = new Point(x, y);
                int radius = 5;  // Радиус круга
                int thickness = 2;  // Толщина
                var color = new Bgr(Color.Blue).MCvScalar;  // Синий цвет
                CvInvoke.Circle(sourceImage, center, radius, color, thickness);

                // Обновляем отображение с нарисованными точками
                imageBox1.Image = sourceImage;
            }

            // Если выбраны все 4 точки, вызываем метод ApplyHomography
            if (selectedPoints.Count == 4)
            {
                ApplyHomography();
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            selectedPoints.Clear();
            sourceImage = originalImage.Clone();  // Восстанавливаем исходное изображение из оригинала
            imageBox1.Image = sourceImage;  // Обновляем отображение в ImageBox1
        }
    }
}

