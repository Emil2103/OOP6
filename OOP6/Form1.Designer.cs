namespace OOP6
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
            this.sheet = new System.Windows.Forms.PictureBox();
            this.DrCirc = new System.Windows.Forms.Button();
            this.DrRec = new System.Windows.Forms.Button();
            this.DrTr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sheet)).BeginInit();
            this.SuspendLayout();
            // 
            // sheet
            // 
            this.sheet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sheet.Location = new System.Drawing.Point(12, 27);
            this.sheet.Name = "sheet";
            this.sheet.Size = new System.Drawing.Size(857, 503);
            this.sheet.TabIndex = 0;
            this.sheet.TabStop = false;
            this.sheet.Paint += new System.Windows.Forms.PaintEventHandler(this.sheet_Paint);
            this.sheet.MouseClick += new System.Windows.Forms.MouseEventHandler(this.sheet_MouseClick);
            // 
            // DrCirc
            // 
            this.DrCirc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DrCirc.Location = new System.Drawing.Point(897, 49);
            this.DrCirc.Name = "DrCirc";
            this.DrCirc.Size = new System.Drawing.Size(80, 50);
            this.DrCirc.TabIndex = 1;
            this.DrCirc.Text = "круг";
            this.DrCirc.UseVisualStyleBackColor = true;
            this.DrCirc.Click += new System.EventHandler(this.DrCirc_Click);
            // 
            // DrRec
            // 
            this.DrRec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DrRec.Location = new System.Drawing.Point(897, 105);
            this.DrRec.Name = "DrRec";
            this.DrRec.Size = new System.Drawing.Size(80, 50);
            this.DrRec.TabIndex = 2;
            this.DrRec.Text = "квадрат";
            this.DrRec.UseVisualStyleBackColor = true;
            this.DrRec.Click += new System.EventHandler(this.DrRec_Click);
            // 
            // DrTr
            // 
            this.DrTr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DrTr.Location = new System.Drawing.Point(897, 161);
            this.DrTr.Name = "DrTr";
            this.DrTr.Size = new System.Drawing.Size(80, 50);
            this.DrTr.TabIndex = 3;
            this.DrTr.Text = "Треугольник";
            this.DrTr.UseVisualStyleBackColor = true;
            this.DrTr.Click += new System.EventHandler(this.DrTr_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 542);
            this.Controls.Add(this.DrTr);
            this.Controls.Add(this.DrRec);
            this.Controls.Add(this.DrCirc);
            this.Controls.Add(this.sheet);
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(1000, 500);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.sheet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox sheet;
        private System.Windows.Forms.Button DrCirc;
        private System.Windows.Forms.Button DrRec;
        private System.Windows.Forms.Button DrTr;
    }
}

