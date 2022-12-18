
namespace CircleArea
{
    partial class CircleAreaForm
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
            this.radiusTextBox = new System.Windows.Forms.TextBox();
            this.calculateAreaButton = new System.Windows.Forms.Button();
            this.areaLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Radius of circle:";
            // 
            // radiusTextBox
            // 
            this.radiusTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiusTextBox.Location = new System.Drawing.Point(236, 30);
            this.radiusTextBox.Name = "radiusTextBox";
            this.radiusTextBox.Size = new System.Drawing.Size(100, 29);
            this.radiusTextBox.TabIndex = 1;
            // 
            // calculateAreaButton
            // 
            this.calculateAreaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateAreaButton.Location = new System.Drawing.Point(88, 91);
            this.calculateAreaButton.Name = "calculateAreaButton";
            this.calculateAreaButton.Size = new System.Drawing.Size(246, 59);
            this.calculateAreaButton.TabIndex = 2;
            this.calculateAreaButton.Text = "Calculate Area of Circle";
            this.calculateAreaButton.UseVisualStyleBackColor = true;
            // 
            // areaLabel
            // 
            this.areaLabel.AutoSize = true;
            this.areaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.areaLabel.Location = new System.Drawing.Point(30, 182);
            this.areaLabel.Name = "areaLabel";
            this.areaLabel.Size = new System.Drawing.Size(259, 24);
            this.areaLabel.TabIndex = 3;
            this.areaLabel.Text = "The circle will have an area of";
            // 
            // CircleAreaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 237);
            this.Controls.Add(this.areaLabel);
            this.Controls.Add(this.calculateAreaButton);
            this.Controls.Add(this.radiusTextBox);
            this.Controls.Add(this.label1);
            this.Name = "CircleAreaForm";
            this.Text = "Circle Area";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox radiusTextBox;
        private System.Windows.Forms.Button calculateAreaButton;
        private System.Windows.Forms.Label areaLabel;
    }
}

