namespace PictureBackgroundRemove_WinForm
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
            this.pictureBoxCurrentImage = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtB_FilePath = new System.Windows.Forms.TextBox();
            this.uploadImage = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSaveImage = new System.Windows.Forms.Button();
            this.radBtnContour = new System.Windows.Forms.RadioButton();
            this.radioDeleteBackground = new System.Windows.Forms.RadioButton();
            this.radBtnDeleteObject = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBoxMagnifier = new System.Windows.Forms.PictureBox();
            this.colorPalette = new System.Windows.Forms.ColorDialog();
            this.btnBackgroundSelect = new System.Windows.Forms.Button();
            this.btnEvaluate = new System.Windows.Forms.Button();
            this.radBtnBackground = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCurrentImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMagnifier)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxCurrentImage
            // 
            this.pictureBoxCurrentImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxCurrentImage.Location = new System.Drawing.Point(27, 98);
            this.pictureBoxCurrentImage.Name = "pictureBoxCurrentImage";
            this.pictureBoxCurrentImage.Size = new System.Drawing.Size(305, 262);
            this.pictureBoxCurrentImage.TabIndex = 0;
            this.pictureBoxCurrentImage.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "File Path";
            // 
            // txtB_FilePath
            // 
            this.txtB_FilePath.Location = new System.Drawing.Point(106, 22);
            this.txtB_FilePath.Name = "txtB_FilePath";
            this.txtB_FilePath.Size = new System.Drawing.Size(567, 20);
            this.txtB_FilePath.TabIndex = 4;
            this.txtB_FilePath.TextChanged += new System.EventHandler(this.txtB_FilePath_TextChanged);
            // 
            // uploadImage
            // 
            this.uploadImage.Location = new System.Drawing.Point(690, 22);
            this.uploadImage.Name = "uploadImage";
            this.uploadImage.Size = new System.Drawing.Size(98, 23);
            this.uploadImage.TabIndex = 5;
            this.uploadImage.Text = "Upload Image";
            this.uploadImage.UseVisualStyleBackColor = true;
            this.uploadImage.Click += new System.EventHandler(this.uploadImage_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(110, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Current Image";
            // 
            // btnSaveImage
            // 
            this.btnSaveImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveImage.Location = new System.Drawing.Point(27, 421);
            this.btnSaveImage.Name = "btnSaveImage";
            this.btnSaveImage.Size = new System.Drawing.Size(89, 32);
            this.btnSaveImage.TabIndex = 8;
            this.btnSaveImage.Text = "Save ";
            this.btnSaveImage.UseVisualStyleBackColor = true;
            this.btnSaveImage.Click += new System.EventHandler(this.btnSaveImage_Click);
            // 
            // radBtnContour
            // 
            this.radBtnContour.AutoSize = true;
            this.radBtnContour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radBtnContour.Location = new System.Drawing.Point(375, 192);
            this.radBtnContour.Name = "radBtnContour";
            this.radBtnContour.Size = new System.Drawing.Size(139, 21);
            this.radBtnContour.TabIndex = 9;
            this.radBtnContour.Text = "Добавить контур";
            this.radBtnContour.UseVisualStyleBackColor = true;
            this.radBtnContour.CheckedChanged += new System.EventHandler(this.radBtnContour_CheckedChanged);
            this.radBtnContour.Click += new System.EventHandler(this.radBtnContour_Click);
            // 
            // radioDeleteBackground
            // 
            this.radioDeleteBackground.AutoSize = true;
            this.radioDeleteBackground.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioDeleteBackground.Location = new System.Drawing.Point(375, 109);
            this.radioDeleteBackground.Name = "radioDeleteBackground";
            this.radioDeleteBackground.Size = new System.Drawing.Size(112, 21);
            this.radioDeleteBackground.TabIndex = 10;
            this.radioDeleteBackground.TabStop = true;
            this.radioDeleteBackground.Text = "Удалить фон";
            this.radioDeleteBackground.UseVisualStyleBackColor = true;
            this.radioDeleteBackground.CheckedChanged += new System.EventHandler(this.radioDeleteBackground_CheckedChanged);
            this.radioDeleteBackground.Click += new System.EventHandler(this.radioDeleteBackground_Click);
            // 
            // radBtnDeleteObject
            // 
            this.radBtnDeleteObject.AutoSize = true;
            this.radBtnDeleteObject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radBtnDeleteObject.Location = new System.Drawing.Point(375, 151);
            this.radBtnDeleteObject.Name = "radBtnDeleteObject";
            this.radBtnDeleteObject.Size = new System.Drawing.Size(132, 21);
            this.radBtnDeleteObject.TabIndex = 11;
            this.radBtnDeleteObject.TabStop = true;
            this.radBtnDeleteObject.Text = "Удалить объект";
            this.radBtnDeleteObject.UseVisualStyleBackColor = true;
            this.radBtnDeleteObject.CheckedChanged += new System.EventHandler(this.radBtnDeleteObject_CheckedChanged);
            this.radBtnDeleteObject.Click += new System.EventHandler(this.radBtnDeleteObject_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 0;
            // 
            // pictureBoxMagnifier
            // 
            this.pictureBoxMagnifier.Location = new System.Drawing.Point(399, 322);
            this.pictureBoxMagnifier.Name = "pictureBoxMagnifier";
            this.pictureBoxMagnifier.Size = new System.Drawing.Size(150, 131);
            this.pictureBoxMagnifier.TabIndex = 15;
            this.pictureBoxMagnifier.TabStop = false;
            // 
            // btnBackgroundSelect
            // 
            this.btnBackgroundSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBackgroundSelect.Location = new System.Drawing.Point(27, 379);
            this.btnBackgroundSelect.Name = "btnBackgroundSelect";
            this.btnBackgroundSelect.Size = new System.Drawing.Size(156, 32);
            this.btnBackgroundSelect.TabIndex = 16;
            this.btnBackgroundSelect.Text = "Выбрать цвет";
            this.btnBackgroundSelect.UseVisualStyleBackColor = true;
            this.btnBackgroundSelect.Click += new System.EventHandler(this.btnBackgroundSelect_Click);
            // 
            // btnEvaluate
            // 
            this.btnEvaluate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEvaluate.Location = new System.Drawing.Point(375, 271);
            this.btnEvaluate.Name = "btnEvaluate";
            this.btnEvaluate.Size = new System.Drawing.Size(172, 45);
            this.btnEvaluate.TabIndex = 17;
            this.btnEvaluate.Text = "Рассчитать";
            this.btnEvaluate.UseVisualStyleBackColor = true;
            this.btnEvaluate.Click += new System.EventHandler(this.btnEvaluate_Click);
            // 
            // radBtnBackground
            // 
            this.radBtnBackground.AutoSize = true;
            this.radBtnBackground.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radBtnBackground.Location = new System.Drawing.Point(375, 231);
            this.radBtnBackground.Name = "radBtnBackground";
            this.radBtnBackground.Size = new System.Drawing.Size(121, 21);
            this.radBtnBackground.TabIndex = 20;
            this.radBtnBackground.TabStop = true;
            this.radBtnBackground.Text = "Добавить фон";
            this.radBtnBackground.UseVisualStyleBackColor = true;
            this.radBtnBackground.CheckedChanged += new System.EventHandler(this.radBtnBackground_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "label7";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 483);
            this.Controls.Add(this.radBtnBackground);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEvaluate);
            this.Controls.Add(this.btnBackgroundSelect);
            this.Controls.Add(this.pictureBoxMagnifier);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.radBtnDeleteObject);
            this.Controls.Add(this.radioDeleteBackground);
            this.Controls.Add(this.radBtnContour);
            this.Controls.Add(this.btnSaveImage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uploadImage);
            this.Controls.Add(this.txtB_FilePath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxCurrentImage);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCurrentImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMagnifier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxCurrentImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtB_FilePath;
        private System.Windows.Forms.Button uploadImage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSaveImage;
        private System.Windows.Forms.RadioButton radBtnContour;
        private System.Windows.Forms.RadioButton radioDeleteBackground;
        private System.Windows.Forms.RadioButton radBtnDeleteObject;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBoxMagnifier;
        private System.Windows.Forms.ColorDialog colorPalette;
        private System.Windows.Forms.Button btnBackgroundSelect;
        private System.Windows.Forms.Button btnEvaluate;
        private System.Windows.Forms.RadioButton radBtnBackground;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
    }
}

