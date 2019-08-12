using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

using System.Text.RegularExpressions;

namespace Chapter2
{
	public partial class RegexTester : Form
	{
		public RegexTester()
		{
			InitializeComponent();

			// Load in the sample text
			LoadTextFile();

			this.SplitResultsView.Columns[0].Width = this.SplitResultsView.Width;
		}

        public static void Main()
        {
            Application.Run(new RegexTester());
        }

		private void Test_Click(object sender, EventArgs e)
		{
			if (regularExpression.Text.Length > 0 & searchText.Text.Length > 0)
				try
				{
					TestExpression(regularExpression.Text);
				}
				catch ( Exception ex )
				{
					MessageBox.Show("There was an error while executing the search\r\n" + ex.Message, "Regex Tester", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			else
				MessageBox.Show("You must enter an expression and text to search first", "Regex Tester", MessageBoxButtons.OK, MessageBoxIcon.Stop);
		}

		private void TestExpression(string testExpression)
		{
			// Create the regex options and assign the options
			Regex regex = new Regex(testExpression, SetRegexOptions());

			// populate the match collection based on the expression
			MatchCollection matches = regex.Matches(searchText.Text);

			// If there were any groups get them
			int[] groupNumbers = regex.GetGroupNumbers();

			// Add the results to the results list view
			SetupResultList(groupNumbers, matches);

			// Highlight the matches in the search text
			SetupSearchText(matches);
		}

		private string[] Split(string splitExpression, int maxElements, int startPosition)
		{
			// Using the split value break the text into seperate strings and return in array
			try
			{
				Regex regex = new Regex(splitExpression, SetRegexOptions());
				return regex.Split(searchText.Text, maxElements, startPosition);
			}
			catch (ArgumentException ex)
			{
				MessageBox.Show("The Split operation failed with the following message:\r\n" + ex.Message, "Regular Expression Sample", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return null;
			}
		}

		private string Replace(string replaceExpression)
		{
			// using the replace expression find the matches
			// each match is handled in the MatchEvaluator delegate function
			try
			{
				Regex regex = new Regex(replaceExpression, SetRegexOptions());
				return regex.Replace(searchText.Text, new MatchEvaluator(ReplaceIt));
			}
			catch (ArgumentException ex)
			{
				MessageBox.Show("You entered an invalid character\r\n\r\n" + "The " + replaceExpression + " character is not valid\r\n" + ex.Message, "Regular Expression Sample", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return null;
			}
		}

		private string ReplaceIt(Match match)
		{
			// Do the actual replace once a match has been made
			string resultString = match.ToString();
			string replaceString = this.ReplaceWith.Text;
			return resultString.Replace(match.ToString(), replaceString);
		}

		private RegexOptions SetRegexOptions()
		{
			// first set up the various options based on the check boxes checked
			RegexOptions options = new RegexOptions();

			if (this.IsRegexOptionsNone.Checked)
			{
				options = options | RegexOptions.None;
				// No options so no need to check the other settings
				return options;
			}

			if (this.IsRegexCompiled.Checked)
				options = options | RegexOptions.Compiled;

			if (this.IsRegexCultureInvariant.Checked)
				options = options | RegexOptions.CultureInvariant;

			if (this.IsRegexExplicitCapture.Checked)
				options = options | RegexOptions.ExplicitCapture;

			if (this.IsRegexIgnoreCase.Checked)
				options = options | RegexOptions.IgnoreCase;

			if (this.IsRegexIgnorePatternWhitespace.Checked)
				options = options | RegexOptions.IgnorePatternWhitespace;

			if (this.IsRegexMultiline.Checked)
				options = options | RegexOptions.Multiline;

			if (this.IsRegexRightToLeft.Checked)
				options = options | RegexOptions.RightToLeft;

			if (this.IsRegexSingleline.Checked)
				options = options | RegexOptions.Singleline;

			return options;
		}

		private void LoadTextFile()
		{
			// read the text from the sample file into the textbox
			string sourceFile = Path.Combine ( Application.StartupPath, "sample.txt" );

			if (File.Exists(sourceFile))
				this.searchText.Text = File.ReadAllText(sourceFile);
		}

		private void SetupResultList(int[] groupNumbers, MatchCollection matches)
		{
			this.resultsView.Clear();

			// set up the standard columns
			this.resultsView.Columns.Add("Match", this.resultsView.Width/2);
			this.resultsView.Columns.Add("Position", this.resultsView.Width / 4);
			this.resultsView.Columns.Add("Length", this.resultsView.Width / 4);

			// if there are goups in the expression add a column for each group
			foreach (int groupNumber in groupNumbers)
			{
				if (groupNumber > 0)
					this.resultsView.Columns.Add("Group " + groupNumber.ToString(), 100, HorizontalAlignment.Left);
			}

			this.resultsView.Items.Clear();

			// add all matches to the list
			foreach (Match match in matches)
			{
				ListViewItem listViewItem = this.resultsView.Items.Add(match.ToString());

				listViewItem.SubItems.Add(match.Index.ToString());
				listViewItem.SubItems.Add(match.Length.ToString());

				for (int groupNumber = 1; groupNumber < match.Groups.Count; groupNumber++)
				{
					listViewItem.SubItems.Add(match.Groups[groupNumber].Value);
				}
			}
		}

		private void SetupSearchText(MatchCollection matches)
		{
			// Highlight each match in the text in red
			this.searchText.HideSelection = true;
			this.searchText.SelectAll();
			this.searchText.SelectionColor = Color.Black;

			foreach (Match match in matches)
			{
				this.searchText.Select(match.Index, match.Length);
				this.searchText.SelectionColor = Color.Red;
			}

			this.searchText.Select(0, 0);
			this.searchText.SelectionColor = Color.Black;

			this.resultsCount.Text = matches.Count.ToString() + " matches found";
		}

		private void resultsView_SelectedIndexChanged(object sender, EventArgs e)
		{
			// Show the selected text in the search text
			if (this.resultsView.SelectedItems.Count > 0)
			{
				this.searchText.HideSelection = false;
				this.searchText.Select(0, 0);
				this.searchText.Select( Int32.Parse (this.resultsView.SelectedItems[0].SubItems[1].Text), Int32.Parse (this.resultsView.SelectedItems[0].SubItems[2].Text) );
			}
		}

		private void IsRegexOptionsNone_CheckedChanged(object sender, EventArgs e)
		{
			// If the Option none is checked then uncheck all others
			if (this.IsRegexOptionsNone.Checked == true)
			{
				foreach (Control control in this.groupBox6.Controls)
				{
					CheckBox checkbox = control as CheckBox;

					if (checkbox != null)
					{
						if (checkbox != this.IsRegexOptionsNone && checkbox.Checked == true)
						{
							checkbox.CheckedChanged -= OtherOptions_CheckChanges;
							checkbox.Checked = false;
							checkbox.CheckedChanged += new EventHandler(OtherOptions_CheckChanges);
						}
					}
				}
			}
		}

		private void OtherOptions_CheckChanges(object sender, EventArgs e)
		{
			// If any option is checked then uncheck None
			if (this.IsRegexOptionsNone.Checked == true)
				this.IsRegexOptionsNone.Checked = false;
		}

		private void SplitText_Click(object sender, EventArgs e)
		{
			// Add each split string to the results list
			this.SplitResultsView.Items.Clear();

			if (this.SplitExpression.Text.Length > 0 && this.SplitMaxElements.Text.Length > 0 && this.SplitStartPosition.Text.Length > 0)
			{
				int maxElements;
				int startPostion;
				string[] result;

				try
				{
					maxElements = Convert.ToInt32(this.SplitMaxElements.Text);
					startPostion = Convert.ToInt32(this.SplitStartPosition.Text);

					result = this.Split(this.SplitExpression.Text, maxElements, startPostion);

					if (result == null)
					{
						MessageBox.Show("The split expression returned an error. Please try another expression", "Regex Tester", MessageBoxButtons.OK, MessageBoxIcon.Stop);
						return;
					}

					foreach (string splitChunk in result)
					{
						this.SplitResultsView.Items.Add ( new ListViewItem ( splitChunk ));
					}
				}
				catch (FormatException ex)
				{
					MessageBox.Show("You must enter a valid Integer\r\n" + ex, "Regex Tester", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				}
			}
			else
			{
				MessageBox.Show("You must enter an expression, Max Elements and Start Position Value first", "Regex Tester", MessageBoxButtons.OK, MessageBoxIcon.Stop);
			}
		}

		private void TextReplace_Click(object sender, EventArgs e)
		{
			if (this.ReplaceFindWhat.Text.Length > 0 && this.ReplaceWith.Text.Length > 0)
			{
				string result = this.Replace(ReplaceFindWhat.Text);

				if (result != null)
					if (result.Length > 0)
						this.searchText.Text = result;
			}
		}
	}
}