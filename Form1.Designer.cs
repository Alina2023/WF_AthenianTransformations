namespace WF_AthenianTransformations
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.imageBox2 = new Emgu.CV.UI.ImageBox();
            this.buttonLoadImage = new System.Windows.Forms.Button();
            this.numericUpDownScaleX = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownScaleY = new System.Windows.Forms.NumericUpDown();
            this.buttonScaleImage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownShiftX = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownShiftY = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonShiftImage = new System.Windows.Forms.Button();
            this.numericUpDownAngle = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCenterX = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCenterY = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonRotateImage = new System.Windows.Forms.Button();
            this.buttonReflectHorisontal = new System.Windows.Forms.Button();
            this.buttonReflectVertical = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownScaleX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownScaleY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownShiftX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownShiftY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCenterX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCenterY)).BeginInit();
            this.SuspendLayout();
            // 
            // imageBox1
            // 
            this.imageBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.imageBox1.Location = new System.Drawing.Point(12, 33);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(337, 460);
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // imageBox2
            // 
            this.imageBox2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.imageBox2.Location = new System.Drawing.Point(355, 33);
            this.imageBox2.Name = "imageBox2";
            this.imageBox2.Size = new System.Drawing.Size(337, 460);
            this.imageBox2.TabIndex = 3;
            this.imageBox2.TabStop = false;
            // 
            // buttonLoadImage
            // 
            this.buttonLoadImage.Location = new System.Drawing.Point(716, 33);
            this.buttonLoadImage.Name = "buttonLoadImage";
            this.buttonLoadImage.Size = new System.Drawing.Size(159, 36);
            this.buttonLoadImage.TabIndex = 4;
            this.buttonLoadImage.Text = "Добавить изображение";
            this.buttonLoadImage.UseVisualStyleBackColor = true;
            this.buttonLoadImage.Click += new System.EventHandler(this.buttonLoadImage_Click);
            // 
            // numericUpDownScaleX
            // 
            this.numericUpDownScaleX.DecimalPlaces = 2;
            this.numericUpDownScaleX.Location = new System.Drawing.Point(736, 75);
            this.numericUpDownScaleX.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownScaleX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownScaleX.Name = "numericUpDownScaleX";
            this.numericUpDownScaleX.Size = new System.Drawing.Size(139, 20);
            this.numericUpDownScaleX.TabIndex = 5;
            this.numericUpDownScaleX.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownScaleY
            // 
            this.numericUpDownScaleY.DecimalPlaces = 2;
            this.numericUpDownScaleY.Location = new System.Drawing.Point(736, 101);
            this.numericUpDownScaleY.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownScaleY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownScaleY.Name = "numericUpDownScaleY";
            this.numericUpDownScaleY.Size = new System.Drawing.Size(139, 20);
            this.numericUpDownScaleY.TabIndex = 6;
            this.numericUpDownScaleY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonScaleImage
            // 
            this.buttonScaleImage.Location = new System.Drawing.Point(788, 127);
            this.buttonScaleImage.Name = "buttonScaleImage";
            this.buttonScaleImage.Size = new System.Drawing.Size(87, 21);
            this.buttonScaleImage.TabIndex = 7;
            this.buttonScaleImage.Text = "Масштаб";
            this.buttonScaleImage.UseVisualStyleBackColor = true;
            this.buttonScaleImage.Click += new System.EventHandler(this.buttonScaleImage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(713, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(713, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Y:";
            // 
            // numericUpDownShiftX
            // 
            this.numericUpDownShiftX.Location = new System.Drawing.Point(736, 154);
            this.numericUpDownShiftX.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownShiftX.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numericUpDownShiftX.Name = "numericUpDownShiftX";
            this.numericUpDownShiftX.Size = new System.Drawing.Size(139, 20);
            this.numericUpDownShiftX.TabIndex = 10;
            // 
            // numericUpDownShiftY
            // 
            this.numericUpDownShiftY.Location = new System.Drawing.Point(736, 180);
            this.numericUpDownShiftY.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownShiftY.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numericUpDownShiftY.Name = "numericUpDownShiftY";
            this.numericUpDownShiftY.Size = new System.Drawing.Size(139, 20);
            this.numericUpDownShiftY.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(713, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "X:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(713, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Y:";
            // 
            // buttonShiftImage
            // 
            this.buttonShiftImage.Location = new System.Drawing.Point(788, 206);
            this.buttonShiftImage.Name = "buttonShiftImage";
            this.buttonShiftImage.Size = new System.Drawing.Size(87, 20);
            this.buttonShiftImage.TabIndex = 14;
            this.buttonShiftImage.Text = "Сдвинуть";
            this.buttonShiftImage.UseVisualStyleBackColor = true;
            this.buttonShiftImage.Click += new System.EventHandler(this.buttonShiftImage_Click_1);
            // 
            // numericUpDownAngle
            // 
            this.numericUpDownAngle.Location = new System.Drawing.Point(738, 236);
            this.numericUpDownAngle.Name = "numericUpDownAngle";
            this.numericUpDownAngle.Size = new System.Drawing.Size(136, 20);
            this.numericUpDownAngle.TabIndex = 15;
            // 
            // numericUpDownCenterX
            // 
            this.numericUpDownCenterX.Location = new System.Drawing.Point(739, 262);
            this.numericUpDownCenterX.Name = "numericUpDownCenterX";
            this.numericUpDownCenterX.Size = new System.Drawing.Size(136, 20);
            this.numericUpDownCenterX.TabIndex = 16;
            // 
            // numericUpDownCenterY
            // 
            this.numericUpDownCenterY.Location = new System.Drawing.Point(739, 288);
            this.numericUpDownCenterY.Name = "numericUpDownCenterY";
            this.numericUpDownCenterY.Size = new System.Drawing.Size(136, 20);
            this.numericUpDownCenterY.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(713, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "X:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(716, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Y:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(695, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Угол:";
            // 
            // buttonRotateImage
            // 
            this.buttonRotateImage.Location = new System.Drawing.Point(788, 314);
            this.buttonRotateImage.Name = "buttonRotateImage";
            this.buttonRotateImage.Size = new System.Drawing.Size(85, 20);
            this.buttonRotateImage.TabIndex = 21;
            this.buttonRotateImage.Text = "Поворот";
            this.buttonRotateImage.UseVisualStyleBackColor = true;
            this.buttonRotateImage.Click += new System.EventHandler(this.buttonRotateImage_Click);
            // 
            // buttonReflectHorisontal
            // 
            this.buttonReflectHorisontal.Location = new System.Drawing.Point(716, 363);
            this.buttonReflectHorisontal.Name = "buttonReflectHorisontal";
            this.buttonReflectHorisontal.Size = new System.Drawing.Size(132, 20);
            this.buttonReflectHorisontal.TabIndex = 22;
            this.buttonReflectHorisontal.Text = "По горизонтали";
            this.buttonReflectHorisontal.UseVisualStyleBackColor = true;
            this.buttonReflectHorisontal.Click += new System.EventHandler(this.buttonReflectHorisontal_Click);
            // 
            // buttonReflectVertical
            // 
            this.buttonReflectVertical.Location = new System.Drawing.Point(716, 389);
            this.buttonReflectVertical.Name = "buttonReflectVertical";
            this.buttonReflectVertical.Size = new System.Drawing.Size(132, 20);
            this.buttonReflectVertical.TabIndex = 23;
            this.buttonReflectVertical.Text = "По вертикали";
            this.buttonReflectVertical.UseVisualStyleBackColor = true;
            this.buttonReflectVertical.Click += new System.EventHandler(this.buttonReflectVertical_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(698, 332);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Отражение:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(698, 423);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Гомография:";
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(716, 448);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(131, 20);
            this.buttonReset.TabIndex = 27;
            this.buttonReset.Text = "Сбросить точки";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 518);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonReflectVertical);
            this.Controls.Add(this.buttonReflectHorisontal);
            this.Controls.Add(this.buttonRotateImage);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDownCenterY);
            this.Controls.Add(this.numericUpDownCenterX);
            this.Controls.Add(this.numericUpDownAngle);
            this.Controls.Add(this.buttonShiftImage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownShiftY);
            this.Controls.Add(this.numericUpDownShiftX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonScaleImage);
            this.Controls.Add(this.numericUpDownScaleY);
            this.Controls.Add(this.numericUpDownScaleX);
            this.Controls.Add(this.buttonLoadImage);
            this.Controls.Add(this.imageBox2);
            this.Controls.Add(this.imageBox1);
            this.Name = "Form1";
            this.Text = "Фоторедактор 2";
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownScaleX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownScaleY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownShiftX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownShiftY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCenterX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCenterY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox imageBox1;
        private Emgu.CV.UI.ImageBox imageBox2;
        private System.Windows.Forms.Button buttonLoadImage;
        private System.Windows.Forms.NumericUpDown numericUpDownScaleX;
        private System.Windows.Forms.NumericUpDown numericUpDownScaleY;
        private System.Windows.Forms.Button buttonScaleImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownShiftX;
        private System.Windows.Forms.NumericUpDown numericUpDownShiftY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonShiftImage;
        private System.Windows.Forms.NumericUpDown numericUpDownAngle;
        private System.Windows.Forms.NumericUpDown numericUpDownCenterX;
        private System.Windows.Forms.NumericUpDown numericUpDownCenterY;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonRotateImage;
        private System.Windows.Forms.Button buttonReflectHorisontal;
        private System.Windows.Forms.Button buttonReflectVertical;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonReset;
    }
}

