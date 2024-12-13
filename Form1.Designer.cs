namespace AISD_Exam
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.checkBoxProcessor = new System.Windows.Forms.CheckBox();
            this.checkBoxGraphicsCard = new System.Windows.Forms.CheckBox();
            this.checkBoxMotherboard = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.textBoxCompatibility = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(823, 386);
            this.dataGridView1.TabIndex = 0;
            // 
            // checkBoxProcessor
            // 
            this.checkBoxProcessor.AutoSize = true;
            this.checkBoxProcessor.Location = new System.Drawing.Point(192, 426);
            this.checkBoxProcessor.Name = "checkBoxProcessor";
            this.checkBoxProcessor.Size = new System.Drawing.Size(73, 17);
            this.checkBoxProcessor.TabIndex = 1;
            this.checkBoxProcessor.Text = "Processor";
            this.checkBoxProcessor.UseVisualStyleBackColor = true;
            this.checkBoxProcessor.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // checkBoxGraphicsCard
            // 
            this.checkBoxGraphicsCard.AutoSize = true;
            this.checkBoxGraphicsCard.Location = new System.Drawing.Point(192, 449);
            this.checkBoxGraphicsCard.Name = "checkBoxGraphicsCard";
            this.checkBoxGraphicsCard.Size = new System.Drawing.Size(90, 17);
            this.checkBoxGraphicsCard.TabIndex = 2;
            this.checkBoxGraphicsCard.Text = "GraphicsCard";
            this.checkBoxGraphicsCard.UseVisualStyleBackColor = true;
            this.checkBoxGraphicsCard.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // checkBoxMotherboard
            // 
            this.checkBoxMotherboard.AutoSize = true;
            this.checkBoxMotherboard.Location = new System.Drawing.Point(321, 426);
            this.checkBoxMotherboard.Name = "checkBoxMotherboard";
            this.checkBoxMotherboard.Size = new System.Drawing.Size(86, 17);
            this.checkBoxMotherboard.TabIndex = 3;
            this.checkBoxMotherboard.Text = "Motherboard";
            this.checkBoxMotherboard.UseVisualStyleBackColor = true;
            this.checkBoxMotherboard.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(450, 426);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(80, 17);
            this.checkBox4.TabIndex = 4;
            this.checkBox4.Text = "checkBox4";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // textBoxCompatibility
            // 
            this.textBoxCompatibility.Location = new System.Drawing.Point(12, 426);
            this.textBoxCompatibility.Name = "textBoxCompatibility";
            this.textBoxCompatibility.Size = new System.Drawing.Size(100, 20);
            this.textBoxCompatibility.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 410);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Выберите 1 или 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 520);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCompatibility);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBoxMotherboard);
            this.Controls.Add(this.checkBoxGraphicsCard);
            this.Controls.Add(this.checkBoxProcessor);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "PC Configurator";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox checkBoxProcessor;
        private System.Windows.Forms.CheckBox checkBoxGraphicsCard;
        private System.Windows.Forms.CheckBox checkBoxMotherboard;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.TextBox textBoxCompatibility;
        private System.Windows.Forms.Label label1;
    }
}

