﻿namespace CommeillFautWF
{
    partial class MainForm
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
            this.socialExchangeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.genericPropertyDataGridControler1 = new GAIPS.AssetEditorTools.GenericPropertyDataGridControler();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.genericPropertyDataGridControler2 = new GAIPS.AssetEditorTools.GenericPropertyDataGridControler();
            this.conditionSetEditorControl1 = new GAIPS.AssetEditorTools.ConditionSetEditorControl();
            this.triggerRulesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.socialExchangeBindingSource)).BeginInit();
            this.TabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.triggerRulesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // socialExchangeBindingSource
            // 
            this.socialExchangeBindingSource.DataSource = typeof(CommeillFaut.SocialExchange);
            // 
            // TabControl
            // 
            this.TabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.TabControl.Controls.Add(this.tabPage1);
            this.TabControl.Controls.Add(this.tabPage2);
            this.TabControl.Location = new System.Drawing.Point(12, 40);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(869, 460);
            this.TabControl.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.genericPropertyDataGridControler1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(861, 427);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Social Exchange";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // genericPropertyDataGridControler1
            // 
            this.genericPropertyDataGridControler1.AllowMuliSelect = false;
            this.genericPropertyDataGridControler1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.genericPropertyDataGridControler1.Location = new System.Drawing.Point(3, 3);
            this.genericPropertyDataGridControler1.Margin = new System.Windows.Forms.Padding(0);
            this.genericPropertyDataGridControler1.Name = "genericPropertyDataGridControler1";
            this.genericPropertyDataGridControler1.Size = new System.Drawing.Size(847, 376);
            this.genericPropertyDataGridControler1.TabIndex = 0;
            this.genericPropertyDataGridControler1.Load += new System.EventHandler(this.genericPropertyDataGridControler1_Load_1);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.genericPropertyDataGridControler2);
            this.tabPage2.Controls.Add(this.conditionSetEditorControl1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(861, 427);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Trigger Rules";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // genericPropertyDataGridControler2
            // 
            this.genericPropertyDataGridControler2.AllowMuliSelect = false;
            this.genericPropertyDataGridControler2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.genericPropertyDataGridControler2.Location = new System.Drawing.Point(3, 3);
            this.genericPropertyDataGridControler2.Margin = new System.Windows.Forms.Padding(0);
            this.genericPropertyDataGridControler2.MinimumSize = new System.Drawing.Size(5, 150);
            this.genericPropertyDataGridControler2.Name = "genericPropertyDataGridControler2";
            this.genericPropertyDataGridControler2.Size = new System.Drawing.Size(841, 150);
            this.genericPropertyDataGridControler2.TabIndex = 1;
            this.genericPropertyDataGridControler2.Load += new System.EventHandler(this.genericPropertyDataGridControler2_Load);
            // 
            // conditionSetEditorControl1
            // 
            this.conditionSetEditorControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.conditionSetEditorControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.conditionSetEditorControl1.Location = new System.Drawing.Point(0, 172);
            this.conditionSetEditorControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.conditionSetEditorControl1.MinimumSize = new System.Drawing.Size(5, 120);
            this.conditionSetEditorControl1.Name = "conditionSetEditorControl1";
            this.conditionSetEditorControl1.Size = new System.Drawing.Size(848, 174);
            this.conditionSetEditorControl1.TabIndex = 0;
            this.conditionSetEditorControl1.View = null;
            // 
            // triggerRulesBindingSource
            // 
            this.triggerRulesBindingSource.DataSource = typeof(CommeillFaut.TriggerRules);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(881, 512);
            this.Controls.Add(this.TabControl);
            this.Name = "MainForm";
            this.Text = "Comme ill Faut";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Controls.SetChildIndex(this.TabControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.socialExchangeBindingSource)).EndInit();
            this.TabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.triggerRulesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource socialExchangeBindingSource;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.BindingSource triggerRulesBindingSource;
        private System.Windows.Forms.TabPage tabPage1;
        private GAIPS.AssetEditorTools.GenericPropertyDataGridControler genericPropertyDataGridControler1;
        private System.Windows.Forms.TabPage tabPage2;
        private GAIPS.AssetEditorTools.GenericPropertyDataGridControler genericPropertyDataGridControler2;
        private GAIPS.AssetEditorTools.ConditionSetEditorControl conditionSetEditorControl1;
    }
}

