namespace PAOA2
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
            this.labelX = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.lineX = new System.Windows.Forms.TextBox();
            this.lineY = new System.Windows.Forms.TextBox();
            this.addPoint = new System.Windows.Forms.Button();
            this.NextPhase_Grehema = new System.Windows.Forms.Button();
            this.labeleror = new System.Windows.Forms.Label();
            this.textBoxControlY = new System.Windows.Forms.TextBox();
            this.textBoxControlX = new System.Windows.Forms.TextBox();
            this.labelControlX = new System.Windows.Forms.Label();
            this.labelControlY = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NextPhase_Jarvisa = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX.Location = new System.Drawing.Point(56, 59);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(24, 24);
            this.labelX.TabIndex = 1;
            this.labelX.Text = "X";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelY.Location = new System.Drawing.Point(58, 115);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(22, 24);
            this.labelY.TabIndex = 2;
            this.labelY.Text = "Y";
            // 
            // lineX
            // 
            this.lineX.Location = new System.Drawing.Point(87, 62);
            this.lineX.Name = "lineX";
            this.lineX.Size = new System.Drawing.Size(100, 20);
            this.lineX.TabIndex = 3;
            // 
            // lineY
            // 
            this.lineY.Location = new System.Drawing.Point(87, 118);
            this.lineY.Name = "lineY";
            this.lineY.Size = new System.Drawing.Size(100, 20);
            this.lineY.TabIndex = 4;
            // 
            // addPoint
            // 
            this.addPoint.Location = new System.Drawing.Point(230, 90);
            this.addPoint.Name = "addPoint";
            this.addPoint.Size = new System.Drawing.Size(75, 23);
            this.addPoint.TabIndex = 5;
            this.addPoint.Text = "Додати";
            this.addPoint.UseVisualStyleBackColor = true;
            this.addPoint.Click += new System.EventHandler(this.addPoint_Click);
            // 
            // NextPhase_Grehema
            // 
            this.NextPhase_Grehema.Location = new System.Drawing.Point(217, 376);
            this.NextPhase_Grehema.Name = "NextPhase_Grehema";
            this.NextPhase_Grehema.Size = new System.Drawing.Size(107, 46);
            this.NextPhase_Grehema.TabIndex = 7;
            this.NextPhase_Grehema.Text = "Grehema";
            this.NextPhase_Grehema.UseVisualStyleBackColor = true;
            this.NextPhase_Grehema.Click += new System.EventHandler(this.NextPhase_Click);
            // 
            // labeleror
            // 
            this.labeleror.AutoSize = true;
            this.labeleror.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeleror.Location = new System.Drawing.Point(83, 295);
            this.labeleror.Name = "labeleror";
            this.labeleror.Size = new System.Drawing.Size(187, 24);
            this.labeleror.TabIndex = 8;
            this.labeleror.Text = "Менше трьох точок";
            // 
            // textBoxControlY
            // 
            this.textBoxControlY.Location = new System.Drawing.Point(286, 238);
            this.textBoxControlY.Name = "textBoxControlY";
            this.textBoxControlY.Size = new System.Drawing.Size(51, 20);
            this.textBoxControlY.TabIndex = 9;
            // 
            // textBoxControlX
            // 
            this.textBoxControlX.Location = new System.Drawing.Point(286, 200);
            this.textBoxControlX.Name = "textBoxControlX";
            this.textBoxControlX.Size = new System.Drawing.Size(51, 20);
            this.textBoxControlX.TabIndex = 10;
            // 
            // labelControlX
            // 
            this.labelControlX.AutoSize = true;
            this.labelControlX.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControlX.Location = new System.Drawing.Point(343, 198);
            this.labelControlX.Name = "labelControlX";
            this.labelControlX.Size = new System.Drawing.Size(19, 22);
            this.labelControlX.TabIndex = 11;
            this.labelControlX.Text = "х";
            // 
            // labelControlY
            // 
            this.labelControlY.AutoSize = true;
            this.labelControlY.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControlY.Location = new System.Drawing.Point(343, 236);
            this.labelControlY.Name = "labelControlY";
            this.labelControlY.Size = new System.Drawing.Size(19, 22);
            this.labelControlY.TabIndex = 12;
            this.labelControlY.Text = "у";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(213, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Точка для перевірки";
            // 
            // NextPhase_Jarvisa
            // 
            this.NextPhase_Jarvisa.Location = new System.Drawing.Point(62, 376);
            this.NextPhase_Jarvisa.Name = "NextPhase_Jarvisa";
            this.NextPhase_Jarvisa.Size = new System.Drawing.Size(107, 46);
            this.NextPhase_Jarvisa.TabIndex = 15;
            this.NextPhase_Jarvisa.Text = "Jervisa";
            this.NextPhase_Jarvisa.UseVisualStyleBackColor = true;
            this.NextPhase_Jarvisa.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(311, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "\'\'\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 453);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NextPhase_Jarvisa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelControlY);
            this.Controls.Add(this.labelControlX);
            this.Controls.Add(this.textBoxControlX);
            this.Controls.Add(this.textBoxControlY);
            this.Controls.Add(this.labeleror);
            this.Controls.Add(this.NextPhase_Grehema);
            this.Controls.Add(this.addPoint);
            this.Controls.Add(this.lineY);
            this.Controls.Add(this.lineX);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.labelX);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.TextBox lineX;
        private System.Windows.Forms.TextBox lineY;
        private System.Windows.Forms.Button addPoint;
        private System.Windows.Forms.Button NextPhase_Grehema;
        private System.Windows.Forms.Label labeleror;
        private System.Windows.Forms.TextBox textBoxControlY;
        private System.Windows.Forms.TextBox textBoxControlX;
        private System.Windows.Forms.Label labelControlX;
        private System.Windows.Forms.Label labelControlY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button NextPhase_Jarvisa;
        private System.Windows.Forms.Label label2;
    }
}

