
namespace LanguageEditor.Views
{
    partial class AttributeTypeSelect
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
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Тип:";
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(81, 16);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(256, 24);
            this.comboBoxType.TabIndex = 1;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(124, 54);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(83, 23);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Создать";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // AttributeTypeSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 89);
            this.ControlBox = false;
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "AttributeTypeSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выберите тип атрибута";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Button buttonSave;
    }
}