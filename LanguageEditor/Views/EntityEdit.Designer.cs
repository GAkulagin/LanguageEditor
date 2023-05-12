namespace LanguageEditor.Views
{
    partial class EntityEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownMaxCount = new System.Windows.Forms.NumericUpDown();
            this.checkBoxIsAbstract = new System.Windows.Forms.CheckBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelNameInvalidMsg = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBoxCanSetMaxCount = new System.Windows.Forms.CheckBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.buttonDeleteAttribute = new System.Windows.Forms.Button();
            this.buttonAddAttribute = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя*:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Абстрактная:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Макс. число экземпляров:";
            // 
            // numericUpDownMaxCount
            // 
            this.numericUpDownMaxCount.Location = new System.Drawing.Point(246, 110);
            this.numericUpDownMaxCount.Name = "numericUpDownMaxCount";
            this.numericUpDownMaxCount.Size = new System.Drawing.Size(55, 20);
            this.numericUpDownMaxCount.TabIndex = 3;
            // 
            // checkBoxIsAbstract
            // 
            this.checkBoxIsAbstract.AutoSize = true;
            this.checkBoxIsAbstract.Location = new System.Drawing.Point(246, 44);
            this.checkBoxIsAbstract.Name = "checkBoxIsAbstract";
            this.checkBoxIsAbstract.Size = new System.Drawing.Size(15, 14);
            this.checkBoxIsAbstract.TabIndex = 4;
            this.checkBoxIsAbstract.UseVisualStyleBackColor = true;
            this.checkBoxIsAbstract.CheckedChanged += new System.EventHandler(this.checkBoxIsAbstract_CheckedChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(246, 12);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(196, 20);
            this.textBoxName.TabIndex = 5;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // labelNameInvalidMsg
            // 
            this.labelNameInvalidMsg.AutoSize = true;
            this.labelNameInvalidMsg.ForeColor = System.Drawing.Color.Red;
            this.labelNameInvalidMsg.Location = new System.Drawing.Point(319, 35);
            this.labelNameInvalidMsg.Name = "labelNameInvalidMsg";
            this.labelNameInvalidMsg.Size = new System.Drawing.Size(123, 13);
            this.labelNameInvalidMsg.TabIndex = 6;
            this.labelNameInvalidMsg.Text = "Это поле обязательно!";
            this.labelNameInvalidMsg.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ограничить макс. число экземпляров";
            // 
            // checkBoxCanSetMaxCount
            // 
            this.checkBoxCanSetMaxCount.AutoSize = true;
            this.checkBoxCanSetMaxCount.Location = new System.Drawing.Point(246, 73);
            this.checkBoxCanSetMaxCount.Name = "checkBoxCanSetMaxCount";
            this.checkBoxCanSetMaxCount.Size = new System.Drawing.Size(15, 14);
            this.checkBoxCanSetMaxCount.TabIndex = 8;
            this.checkBoxCanSetMaxCount.UseVisualStyleBackColor = true;
            this.checkBoxCanSetMaxCount.CheckedChanged += new System.EventHandler(this.checkBoxCanSetMaxCount_CheckedChanged);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(12, 415);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 164);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(430, 150);
            this.dataGridView.TabIndex = 10;
            // 
            // buttonDeleteAttribute
            // 
            this.buttonDeleteAttribute.Location = new System.Drawing.Point(367, 320);
            this.buttonDeleteAttribute.Name = "buttonDeleteAttribute";
            this.buttonDeleteAttribute.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteAttribute.TabIndex = 11;
            this.buttonDeleteAttribute.Text = "Удалить";
            this.buttonDeleteAttribute.UseVisualStyleBackColor = true;
            this.buttonDeleteAttribute.Click += new System.EventHandler(this.buttonDeleteAttribute_Click);
            // 
            // buttonAddAttribute
            // 
            this.buttonAddAttribute.Location = new System.Drawing.Point(276, 320);
            this.buttonAddAttribute.Name = "buttonAddAttribute";
            this.buttonAddAttribute.Size = new System.Drawing.Size(75, 23);
            this.buttonAddAttribute.TabIndex = 12;
            this.buttonAddAttribute.Text = "Добавить";
            this.buttonAddAttribute.UseVisualStyleBackColor = true;
            this.buttonAddAttribute.Click += new System.EventHandler(this.buttonAddAttribute_Click);
            // 
            // EntityEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 450);
            this.Controls.Add(this.buttonAddAttribute);
            this.Controls.Add(this.buttonDeleteAttribute);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.checkBoxCanSetMaxCount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelNameInvalidMsg);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.checkBoxIsAbstract);
            this.Controls.Add(this.numericUpDownMaxCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "EntityEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxCount;
        private System.Windows.Forms.CheckBox checkBoxIsAbstract;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelNameInvalidMsg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBoxCanSetMaxCount;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonDeleteAttribute;
        private System.Windows.Forms.Button buttonAddAttribute;
    }
}