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
            this.checkBoxStorage = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxCase = new System.Windows.Forms.CheckBox();
            this.checkBoxRAM = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(275, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(560, 386);
            this.dataGridView1.TabIndex = 0;
            // 
            // checkBoxProcessor
            // 
            this.checkBoxProcessor.AutoSize = true;
            this.checkBoxProcessor.Location = new System.Drawing.Point(129, 52);
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
            this.checkBoxGraphicsCard.Location = new System.Drawing.Point(129, 121);
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
            this.checkBoxMotherboard.Location = new System.Drawing.Point(129, 75);
            this.checkBoxMotherboard.Name = "checkBoxMotherboard";
            this.checkBoxMotherboard.Size = new System.Drawing.Size(86, 17);
            this.checkBoxMotherboard.TabIndex = 3;
            this.checkBoxMotherboard.Text = "Motherboard";
            this.checkBoxMotherboard.UseVisualStyleBackColor = true;
            this.checkBoxMotherboard.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // checkBoxStorage
            // 
            this.checkBoxStorage.AutoSize = true;
            this.checkBoxStorage.Location = new System.Drawing.Point(129, 144);
            this.checkBoxStorage.Name = "checkBoxStorage";
            this.checkBoxStorage.Size = new System.Drawing.Size(63, 17);
            this.checkBoxStorage.TabIndex = 4;
            this.checkBoxStorage.Text = "Storage";
            this.checkBoxStorage.UseVisualStyleBackColor = true;
            this.checkBoxStorage.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Совместимость";
            // 
            // checkBoxCase
            // 
            this.checkBoxCase.AutoSize = true;
            this.checkBoxCase.Location = new System.Drawing.Point(129, 98);
            this.checkBoxCase.Name = "checkBoxCase";
            this.checkBoxCase.Size = new System.Drawing.Size(50, 17);
            this.checkBoxCase.TabIndex = 7;
            this.checkBoxCase.Text = "Case";
            this.checkBoxCase.UseVisualStyleBackColor = true;
            this.checkBoxCase.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // checkBoxRAM
            // 
            this.checkBoxRAM.AutoSize = true;
            this.checkBoxRAM.Location = new System.Drawing.Point(129, 167);
            this.checkBoxRAM.Name = "checkBoxRAM";
            this.checkBoxRAM.Size = new System.Drawing.Size(50, 17);
            this.checkBoxRAM.TabIndex = 8;
            this.checkBoxRAM.Text = "RAM";
            this.checkBoxRAM.UseVisualStyleBackColor = true;
            this.checkBoxRAM.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2"});
            this.comboBox1.Location = new System.Drawing.Point(15, 48);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(71, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Сбросить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 404);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.checkBoxRAM);
            this.Controls.Add(this.checkBoxCase);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxStorage);
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
        private System.Windows.Forms.CheckBox checkBoxStorage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxCase;
        private System.Windows.Forms.CheckBox checkBoxRAM;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
    }
}

