namespace Chapter2
{
	partial class RegexTester
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox9 = new System.Windows.Forms.GroupBox();
			this.regularExpression = new System.Windows.Forms.TextBox();
			this.Test = new System.Windows.Forms.Button();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.IsRegexSingleline = new System.Windows.Forms.CheckBox();
			this.IsRegexRightToLeft = new System.Windows.Forms.CheckBox();
			this.IsRegexOptionsNone = new System.Windows.Forms.CheckBox();
			this.IsRegexMultiline = new System.Windows.Forms.CheckBox();
			this.IsRegexIgnorePatternWhitespace = new System.Windows.Forms.CheckBox();
			this.IsRegexIgnoreCase = new System.Windows.Forms.CheckBox();
			this.IsRegexExplicitCapture = new System.Windows.Forms.CheckBox();
			this.IsRegexCultureInvariant = new System.Windows.Forms.CheckBox();
			this.IsRegexCompiled = new System.Windows.Forms.CheckBox();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.ReplaceWith = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.TextReplace = new System.Windows.Forms.Button();
			this.ReplaceFindWhat = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.resultsCount = new System.Windows.Forms.Label();
			this.resultsView = new System.Windows.Forms.ListView();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.searchText = new System.Windows.Forms.RichTextBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.SplitExpression = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.SplitStartPosition = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.SplitMaxElements = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SplitText = new System.Windows.Forms.Button();
			this.groupBox7 = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.SplitResultsView = new System.Windows.Forms.ListView();
			this.ChunkHeader = new System.Windows.Forms.ColumnHeader();
			this.groupBox8 = new System.Windows.Forms.GroupBox();
			this.groupBox1.SuspendLayout();
			this.groupBox9.SuspendLayout();
			this.groupBox6.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox7.SuspendLayout();
			this.groupBox8.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.groupBox9);
			this.groupBox1.Controls.Add(this.groupBox6);
			this.groupBox1.Controls.Add(this.groupBox5);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(704, 182);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// groupBox9
			// 
			this.groupBox9.Controls.Add(this.regularExpression);
			this.groupBox9.Controls.Add(this.Test);
			this.groupBox9.Location = new System.Drawing.Point(6, 19);
			this.groupBox9.Name = "groupBox9";
			this.groupBox9.Size = new System.Drawing.Size(334, 76);
			this.groupBox9.TabIndex = 13;
			this.groupBox9.TabStop = false;
			this.groupBox9.Text = "Search Expression";
			// 
			// regularExpression
			// 
			this.regularExpression.Location = new System.Drawing.Point(6, 19);
			this.regularExpression.Name = "regularExpression";
			this.regularExpression.Size = new System.Drawing.Size(315, 20);
			this.regularExpression.TabIndex = 0;
			// 
			// Test
			// 
			this.Test.Location = new System.Drawing.Point(6, 45);
			this.Test.Name = "Test";
			this.Test.Size = new System.Drawing.Size(75, 23);
			this.Test.TabIndex = 1;
			this.Test.Text = "Search";
			this.Test.Click += new System.EventHandler(this.Test_Click);
			// 
			// groupBox6
			// 
			this.groupBox6.Controls.Add(this.IsRegexSingleline);
			this.groupBox6.Controls.Add(this.IsRegexRightToLeft);
			this.groupBox6.Controls.Add(this.IsRegexOptionsNone);
			this.groupBox6.Controls.Add(this.IsRegexMultiline);
			this.groupBox6.Controls.Add(this.IsRegexIgnorePatternWhitespace);
			this.groupBox6.Controls.Add(this.IsRegexIgnoreCase);
			this.groupBox6.Controls.Add(this.IsRegexExplicitCapture);
			this.groupBox6.Controls.Add(this.IsRegexCultureInvariant);
			this.groupBox6.Controls.Add(this.IsRegexCompiled);
			this.groupBox6.Location = new System.Drawing.Point(8, 103);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(685, 72);
			this.groupBox6.TabIndex = 12;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "Options";
			// 
			// IsRegexSingleline
			// 
			this.IsRegexSingleline.AutoSize = true;
			this.IsRegexSingleline.Location = new System.Drawing.Point(312, 22);
			this.IsRegexSingleline.Name = "IsRegexSingleline";
			this.IsRegexSingleline.Size = new System.Drawing.Size(67, 17);
			this.IsRegexSingleline.TabIndex = 21;
			this.IsRegexSingleline.Text = "Singleline";
			this.IsRegexSingleline.CheckedChanged += new System.EventHandler(this.OtherOptions_CheckChanges);
			// 
			// IsRegexRightToLeft
			// 
			this.IsRegexRightToLeft.AutoSize = true;
			this.IsRegexRightToLeft.Location = new System.Drawing.Point(92, 45);
			this.IsRegexRightToLeft.Name = "IsRegexRightToLeft";
			this.IsRegexRightToLeft.Size = new System.Drawing.Size(78, 17);
			this.IsRegexRightToLeft.TabIndex = 20;
			this.IsRegexRightToLeft.Text = "RightToLeft";
			this.IsRegexRightToLeft.CheckedChanged += new System.EventHandler(this.OtherOptions_CheckChanges);
			// 
			// IsRegexOptionsNone
			// 
			this.IsRegexOptionsNone.AutoSize = true;
			this.IsRegexOptionsNone.Location = new System.Drawing.Point(6, 22);
			this.IsRegexOptionsNone.Name = "IsRegexOptionsNone";
			this.IsRegexOptionsNone.Size = new System.Drawing.Size(73, 17);
			this.IsRegexOptionsNone.TabIndex = 19;
			this.IsRegexOptionsNone.Text = "No options";
			this.IsRegexOptionsNone.CheckedChanged += new System.EventHandler(this.IsRegexOptionsNone_CheckedChanged);
			// 
			// IsRegexMultiline
			// 
			this.IsRegexMultiline.AutoSize = true;
			this.IsRegexMultiline.Location = new System.Drawing.Point(312, 45);
			this.IsRegexMultiline.Name = "IsRegexMultiline";
			this.IsRegexMultiline.Size = new System.Drawing.Size(60, 17);
			this.IsRegexMultiline.TabIndex = 18;
			this.IsRegexMultiline.Text = "Multiline";
			this.IsRegexMultiline.CheckedChanged += new System.EventHandler(this.OtherOptions_CheckChanges);
			// 
			// IsRegexIgnorePatternWhitespace
			// 
			this.IsRegexIgnorePatternWhitespace.AutoSize = true;
			this.IsRegexIgnorePatternWhitespace.Location = new System.Drawing.Point(387, 22);
			this.IsRegexIgnorePatternWhitespace.Name = "IsRegexIgnorePatternWhitespace";
			this.IsRegexIgnorePatternWhitespace.Size = new System.Drawing.Size(146, 17);
			this.IsRegexIgnorePatternWhitespace.TabIndex = 17;
			this.IsRegexIgnorePatternWhitespace.Text = "IgnorePattern Whitespace";
			this.IsRegexIgnorePatternWhitespace.CheckedChanged += new System.EventHandler(this.OtherOptions_CheckChanges);
			// 
			// IsRegexIgnoreCase
			// 
			this.IsRegexIgnoreCase.AutoSize = true;
			this.IsRegexIgnoreCase.Location = new System.Drawing.Point(206, 45);
			this.IsRegexIgnoreCase.Name = "IsRegexIgnoreCase";
			this.IsRegexIgnoreCase.Size = new System.Drawing.Size(79, 17);
			this.IsRegexIgnoreCase.TabIndex = 16;
			this.IsRegexIgnoreCase.Text = "Ignore Case";
			this.IsRegexIgnoreCase.CheckedChanged += new System.EventHandler(this.OtherOptions_CheckChanges);
			// 
			// IsRegexExplicitCapture
			// 
			this.IsRegexExplicitCapture.AutoSize = true;
			this.IsRegexExplicitCapture.Location = new System.Drawing.Point(204, 22);
			this.IsRegexExplicitCapture.Name = "IsRegexExplicitCapture";
			this.IsRegexExplicitCapture.Size = new System.Drawing.Size(95, 17);
			this.IsRegexExplicitCapture.TabIndex = 15;
			this.IsRegexExplicitCapture.Text = "Explicit Capture";
			this.IsRegexExplicitCapture.CheckedChanged += new System.EventHandler(this.OtherOptions_CheckChanges);
			// 
			// IsRegexCultureInvariant
			// 
			this.IsRegexCultureInvariant.AutoSize = true;
			this.IsRegexCultureInvariant.Location = new System.Drawing.Point(92, 22);
			this.IsRegexCultureInvariant.Name = "IsRegexCultureInvariant";
			this.IsRegexCultureInvariant.Size = new System.Drawing.Size(99, 17);
			this.IsRegexCultureInvariant.TabIndex = 13;
			this.IsRegexCultureInvariant.Text = "Culture Invariant";
			this.IsRegexCultureInvariant.CheckedChanged += new System.EventHandler(this.OtherOptions_CheckChanges);
			// 
			// IsRegexCompiled
			// 
			this.IsRegexCompiled.AutoSize = true;
			this.IsRegexCompiled.Location = new System.Drawing.Point(6, 45);
			this.IsRegexCompiled.Name = "IsRegexCompiled";
			this.IsRegexCompiled.Size = new System.Drawing.Size(65, 17);
			this.IsRegexCompiled.TabIndex = 12;
			this.IsRegexCompiled.Text = "Compiled";
			this.IsRegexCompiled.CheckedChanged += new System.EventHandler(this.OtherOptions_CheckChanges);
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.ReplaceWith);
			this.groupBox5.Controls.Add(this.label6);
			this.groupBox5.Controls.Add(this.TextReplace);
			this.groupBox5.Controls.Add(this.ReplaceFindWhat);
			this.groupBox5.Controls.Add(this.label5);
			this.groupBox5.Location = new System.Drawing.Point(346, 19);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(347, 78);
			this.groupBox5.TabIndex = 3;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Replace";
			// 
			// ReplaceWith
			// 
			this.ReplaceWith.Location = new System.Drawing.Point(93, 45);
			this.ReplaceWith.Name = "ReplaceWith";
			this.ReplaceWith.Size = new System.Drawing.Size(161, 20);
			this.ReplaceWith.TabIndex = 11;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(13, 48);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(71, 13);
			this.label6.TabIndex = 10;
			this.label6.Text = "Replace With:";
			// 
			// TextReplace
			// 
			this.TextReplace.Location = new System.Drawing.Point(262, 30);
			this.TextReplace.Name = "TextReplace";
			this.TextReplace.Size = new System.Drawing.Size(75, 23);
			this.TextReplace.TabIndex = 9;
			this.TextReplace.Text = "Replace";
			this.TextReplace.Click += new System.EventHandler(this.TextReplace_Click);
			// 
			// ReplaceFindWhat
			// 
			this.ReplaceFindWhat.Location = new System.Drawing.Point(93, 19);
			this.ReplaceFindWhat.Name = "ReplaceFindWhat";
			this.ReplaceFindWhat.Size = new System.Drawing.Size(161, 20);
			this.ReplaceFindWhat.TabIndex = 8;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(13, 22);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(55, 13);
			this.label5.TabIndex = 7;
			this.label5.Text = "Find What:";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.resultsCount);
			this.groupBox3.Controls.Add(this.resultsView);
			this.groupBox3.Location = new System.Drawing.Point(12, 200);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(704, 149);
			this.groupBox3.TabIndex = 13;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Results";
			// 
			// resultsCount
			// 
			this.resultsCount.AutoSize = true;
			this.resultsCount.Location = new System.Drawing.Point(7, 18);
			this.resultsCount.Name = "resultsCount";
			this.resultsCount.Size = new System.Drawing.Size(0, 0);
			this.resultsCount.TabIndex = 1;
			// 
			// resultsView
			// 
			this.resultsView.FullRowSelect = true;
			this.resultsView.GridLines = true;
			this.resultsView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.resultsView.Location = new System.Drawing.Point(6, 37);
			this.resultsView.Name = "resultsView";
			this.resultsView.Size = new System.Drawing.Size(677, 106);
			this.resultsView.TabIndex = 0;
			this.resultsView.View = System.Windows.Forms.View.Details;
			this.resultsView.SelectedIndexChanged += new System.EventHandler(this.resultsView_SelectedIndexChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.searchText);
			this.groupBox2.Location = new System.Drawing.Point(12, 585);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(704, 141);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Text to Search";
			// 
			// searchText
			// 
			this.searchText.Location = new System.Drawing.Point(3, 16);
			this.searchText.Name = "searchText";
			this.searchText.Size = new System.Drawing.Size(680, 112);
			this.searchText.TabIndex = 0;
			this.searchText.Text = "";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.SplitExpression);
			this.groupBox4.Controls.Add(this.label3);
			this.groupBox4.Controls.Add(this.SplitStartPosition);
			this.groupBox4.Controls.Add(this.label2);
			this.groupBox4.Controls.Add(this.SplitMaxElements);
			this.groupBox4.Controls.Add(this.label1);
			this.groupBox4.Controls.Add(this.SplitText);
			this.groupBox4.Location = new System.Drawing.Point(7, 19);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(686, 55);
			this.groupBox4.TabIndex = 2;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Split Expression";
			// 
			// SplitExpression
			// 
			this.SplitExpression.Location = new System.Drawing.Point(92, 20);
			this.SplitExpression.Name = "SplitExpression";
			this.SplitExpression.Size = new System.Drawing.Size(136, 20);
			this.SplitExpression.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 23);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Split Expression:";
			// 
			// SplitStartPosition
			// 
			this.SplitStartPosition.Location = new System.Drawing.Point(461, 20);
			this.SplitStartPosition.Name = "SplitStartPosition";
			this.SplitStartPosition.Size = new System.Drawing.Size(44, 20);
			this.SplitStartPosition.TabIndex = 4;
			this.SplitStartPosition.Text = "0";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(387, 23);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Start Position:";
			// 
			// SplitMaxElements
			// 
			this.SplitMaxElements.Location = new System.Drawing.Point(316, 20);
			this.SplitMaxElements.Name = "SplitMaxElements";
			this.SplitMaxElements.Size = new System.Drawing.Size(45, 20);
			this.SplitMaxElements.TabIndex = 2;
			this.SplitMaxElements.Text = "100";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(238, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Max Elements:";
			// 
			// SplitText
			// 
			this.SplitText.Location = new System.Drawing.Point(532, 18);
			this.SplitText.Name = "SplitText";
			this.SplitText.Size = new System.Drawing.Size(75, 23);
			this.SplitText.TabIndex = 0;
			this.SplitText.Text = "Split";
			this.SplitText.Click += new System.EventHandler(this.SplitText_Click);
			// 
			// groupBox7
			// 
			this.groupBox7.Controls.Add(this.label4);
			this.groupBox7.Controls.Add(this.SplitResultsView);
			this.groupBox7.Location = new System.Drawing.Point(7, 80);
			this.groupBox7.Name = "groupBox7";
			this.groupBox7.Size = new System.Drawing.Size(686, 137);
			this.groupBox7.TabIndex = 14;
			this.groupBox7.TabStop = false;
			this.groupBox7.Text = "Results";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(7, 18);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(0, 0);
			this.label4.TabIndex = 1;
			// 
			// SplitResultsView
			// 
			this.SplitResultsView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ChunkHeader});
			this.SplitResultsView.FullRowSelect = true;
			this.SplitResultsView.GridLines = true;
			this.SplitResultsView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.SplitResultsView.Location = new System.Drawing.Point(6, 18);
			this.SplitResultsView.Name = "SplitResultsView";
			this.SplitResultsView.Size = new System.Drawing.Size(670, 103);
			this.SplitResultsView.TabIndex = 0;
			this.SplitResultsView.View = System.Windows.Forms.View.Details;
			// 
			// ChunkHeader
			// 
			this.ChunkHeader.Text = "Chunk";
			this.ChunkHeader.Width = 322;
			// 
			// groupBox8
			// 
			this.groupBox8.Controls.Add(this.groupBox4);
			this.groupBox8.Controls.Add(this.groupBox7);
			this.groupBox8.Location = new System.Drawing.Point(12, 355);
			this.groupBox8.Name = "groupBox8";
			this.groupBox8.Size = new System.Drawing.Size(704, 224);
			this.groupBox8.TabIndex = 15;
			this.groupBox8.TabStop = false;
			this.groupBox8.Text = "Split";
			// 
			// RegexTester
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(729, 736);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox8);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "RegexTester";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Regular Expression Sample";
			this.groupBox1.ResumeLayout(false);
			this.groupBox9.ResumeLayout(false);
			this.groupBox9.PerformLayout();
			this.groupBox6.ResumeLayout(false);
			this.groupBox6.PerformLayout();
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.groupBox7.ResumeLayout(false);
			this.groupBox7.PerformLayout();
			this.groupBox8.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button Test;
		private System.Windows.Forms.TextBox regularExpression;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.CheckBox IsRegexSingleline;
		private System.Windows.Forms.CheckBox IsRegexRightToLeft;
		private System.Windows.Forms.CheckBox IsRegexOptionsNone;
		private System.Windows.Forms.CheckBox IsRegexMultiline;
		private System.Windows.Forms.CheckBox IsRegexIgnorePatternWhitespace;
		private System.Windows.Forms.CheckBox IsRegexIgnoreCase;
		private System.Windows.Forms.CheckBox IsRegexExplicitCapture;
		private System.Windows.Forms.CheckBox IsRegexCultureInvariant;
		private System.Windows.Forms.CheckBox IsRegexCompiled;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.ListView resultsView;
		private System.Windows.Forms.RichTextBox searchText;
		private System.Windows.Forms.Label resultsCount;
		private System.Windows.Forms.Button SplitText;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox SplitStartPosition;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox SplitMaxElements;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox SplitExpression;
		private System.Windows.Forms.GroupBox groupBox7;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ListView SplitResultsView;
		private System.Windows.Forms.GroupBox groupBox8;
		private System.Windows.Forms.ColumnHeader ChunkHeader;
		private System.Windows.Forms.Button TextReplace;
		private System.Windows.Forms.TextBox ReplaceFindWhat;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox ReplaceWith;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.GroupBox groupBox9;
	}
}

