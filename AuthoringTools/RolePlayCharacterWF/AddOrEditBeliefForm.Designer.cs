﻿namespace RolePlayCharacterWF
{
    partial class AddOrEditBeliefForm
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
            this.components = new System.ComponentModel.Container();
            this.emotionalAppraisalAssetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.addOrEditBeliefButton = new System.Windows.Forms.Button();
            this.beliefNameTextBox = new System.Windows.Forms.TextBox();
            this.beliefValueTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addBeliefErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.perspectiveTextBox = new System.Windows.Forms.TextBox();
            this.certaintyTextBox = new System.Windows.Forms.TextBox();
            this.labelCertainty = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.emotionalAppraisalAssetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addBeliefErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // emotionalAppraisalAssetBindingSource
            // 
            this.emotionalAppraisalAssetBindingSource.DataSource = typeof(EmotionalAppraisal.EmotionalAppraisalAsset);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // addOrEditBeliefButton
            // 
            this.addOrEditBeliefButton.Location = new System.Drawing.Point(133, 255);
            this.addOrEditBeliefButton.Name = "addOrEditBeliefButton";
            this.addOrEditBeliefButton.Size = new System.Drawing.Size(75, 23);
            this.addOrEditBeliefButton.TabIndex = 30;
            this.addOrEditBeliefButton.Text = "Add";
            this.addOrEditBeliefButton.UseVisualStyleBackColor = true;
            this.addOrEditBeliefButton.Click += new System.EventHandler(this.addOrEditBeliefButton_Click);
            // 
            // beliefNameTextBox
            // 
            this.beliefNameTextBox.Location = new System.Drawing.Point(40, 54);
            this.beliefNameTextBox.Name = "beliefNameTextBox";
            this.beliefNameTextBox.Size = new System.Drawing.Size(260, 20);
            this.beliefNameTextBox.TabIndex = 17;
            this.beliefNameTextBox.TextChanged += new System.EventHandler(this.beliefNameTextBox_TextChanged);
            // 
            // beliefValueTextBox
            // 
            this.beliefValueTextBox.Location = new System.Drawing.Point(40, 105);
            this.beliefValueTextBox.Name = "beliefValueTextBox";
            this.beliefValueTextBox.Size = new System.Drawing.Size(260, 20);
            this.beliefValueTextBox.TabIndex = 18;
            this.beliefValueTextBox.TextChanged += new System.EventHandler(this.beliefValueTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Perspective:";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Value:";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // addBeliefErrorProvider
            // 
            this.addBeliefErrorProvider.ContainerControl = this;
            // 
            // perspectiveTextBox
            // 
            this.perspectiveTextBox.Location = new System.Drawing.Point(40, 158);
            this.perspectiveTextBox.Name = "perspectiveTextBox";
            this.perspectiveTextBox.Size = new System.Drawing.Size(260, 20);
            this.perspectiveTextBox.TabIndex = 21;
            // 
            // certaintyTextBox
            // 
            this.certaintyTextBox.Location = new System.Drawing.Point(40, 213);
            this.certaintyTextBox.Name = "certaintyTextBox";
            this.certaintyTextBox.Size = new System.Drawing.Size(260, 20);
            this.certaintyTextBox.TabIndex = 23;
            // 
            // labelCertainty
            // 
            this.labelCertainty.AutoSize = true;
            this.labelCertainty.Location = new System.Drawing.Point(40, 192);
            this.labelCertainty.Name = "labelCertainty";
            this.labelCertainty.Size = new System.Drawing.Size(51, 13);
            this.labelCertainty.TabIndex = 22;
            this.labelCertainty.Text = "Certainty:";
            // 
            // AddOrEditBeliefForm
            // 
            this.AcceptButton = this.addOrEditBeliefButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(340, 307);
            this.Controls.Add(this.certaintyTextBox);
            this.Controls.Add(this.labelCertainty);
            this.Controls.Add(this.perspectiveTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addOrEditBeliefButton);
            this.Controls.Add(this.beliefNameTextBox);
            this.Controls.Add(this.beliefValueTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AddOrEditBeliefForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Belief";
            this.Load += new System.EventHandler(this.AddOrEditBeliefForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.emotionalAppraisalAssetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addBeliefErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource emotionalAppraisalAssetBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addOrEditBeliefButton;
        private System.Windows.Forms.TextBox beliefNameTextBox;
        private System.Windows.Forms.TextBox beliefValueTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider addBeliefErrorProvider;
        private System.Windows.Forms.TextBox certaintyTextBox;
        private System.Windows.Forms.Label labelCertainty;
        private System.Windows.Forms.TextBox perspectiveTextBox;
    }
}