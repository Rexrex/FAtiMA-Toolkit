﻿using System;
using System.Linq;
using System.Windows.Forms;
using IntegratedAuthoringTool;
using IntegratedAuthoringTool.DTOs;

namespace IntegratedAuthoringToolWF
{
    public partial class AddOrEditDialogueActionForm : Form
    {
	    private MainForm _parentForm;
        private IntegratedAuthoringToolAsset _iatAsset => _parentForm.LoadedAsset;
        private readonly DialogueStateActionDTO _dialogueStateActionToEdit;
        private readonly bool _isPlayerDialogue;

        public AddOrEditDialogueActionForm(MainForm form, bool isPlayerDialogue)
        {
            InitializeComponent();
	        _parentForm = form;
            _isPlayerDialogue = isPlayerDialogue;
        }

		public AddOrEditDialogueActionForm(MainForm form, bool isPlayerDialogue, Guid dialogId) : this(form,isPlayerDialogue)
		{
			buttonAddOrUpdate.Text = "Update";
			_dialogueStateActionToEdit = form.LoadedAsset.GetDialogActionById(dialogId);

			textBoxCurrentState.Text = _dialogueStateActionToEdit.CurrentState;
			textBoxNextState.Text = _dialogueStateActionToEdit.NextState;
            textBoxMeaning.Text = _dialogueStateActionToEdit.Meaning;
            textBoxStyle.Text = _dialogueStateActionToEdit.Style;
			textBoxUtterance.Text = _dialogueStateActionToEdit.Utterance;
		}

        private void buttonAddOrUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var newDialogueAction = new DialogueStateActionDTO
                {
                    CurrentState = textBoxCurrentState.Text,
					NextState = textBoxNextState.Text,
					Meaning = textBoxMeaning.Text,
                    Style = textBoxStyle.Text,
                    Utterance = textBoxUtterance.Text
                };

                if (_dialogueStateActionToEdit == null)
                {
                    _iatAsset.AddDialogAction(newDialogueAction);
                }
                else
                {
                    _iatAsset.EditDialogAction(_dialogueStateActionToEdit, newDialogueAction);
                }
				_parentForm.SetModified();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
	}
}
