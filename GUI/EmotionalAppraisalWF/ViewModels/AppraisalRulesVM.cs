﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using EmotionalAppraisal;
using EmotionalAppraisal.DTOs;
using Equin.ApplicationFramework;
using KnowledgeBase.DTOs.Conditions;

namespace EmotionalAppraisalWF.ViewModels
{
    public class AppraisalRulesVM
    {
        private EmotionalAppraisalAsset _emotionalAppraisalAsset;

        public BindingListView<AppraisalRuleDTO> AppraisalRules {get;}
        public BindingListView<ConditionDTO> CurrentRuleConditions { get; set; }
        public AppraisalRuleDTO AppraisalRuleSelected { get; set;}

        public string[] QuantifierTypes => _emotionalAppraisalAsset.QuantifierTypes;


        public AppraisalRulesVM(EmotionalAppraisalAsset ea)
        {
            _emotionalAppraisalAsset = ea;
            
            this.AppraisalRules = new BindingListView<AppraisalRuleDTO>(ea.GetAllAppraisalRules().ToList());
            this.CurrentRuleConditions = new BindingListView<ConditionDTO>(new List<ConditionDTO>());
            this.AppraisalRuleSelected = null;
        }

        public void ChangeCurrentRule(AppraisalRuleDTO rule)
        {
            if (rule != null)
            {
                this.AppraisalRuleSelected = rule;
                this.CurrentRuleConditions = new BindingListView<ConditionDTO>(rule.Conditions.ToList());
            }
        }

        public void AddOrUpdateAppraisalRule(AppraisalRuleDTO newRule)
        {
            _emotionalAppraisalAsset.AddOrUpdateAppraisalRule(newRule);
            this.AppraisalRules.DataSource = _emotionalAppraisalAsset.GetAllAppraisalRules().ToList();
            AppraisalRules.Refresh();
        }


        public void RemoveAppraisalRules(IEnumerable<AppraisalRuleDTO> appraisalRules)
        {
            _emotionalAppraisalAsset.RemoveAppraisalRules(appraisalRules);
            foreach (var appraisalRuleDto in appraisalRules)
            {
                this.AppraisalRules.DataSource.Remove(appraisalRuleDto);
            }
            this.AppraisalRuleSelected = null;
            this.CurrentRuleConditions.DataSource.Clear();
            this.CurrentRuleConditions.Refresh();
            AppraisalRules.Refresh();
        }

        public void AddCondition(ConditionDTO newCondition)
        {
            _emotionalAppraisalAsset.AddAppraisalRuleCondition(AppraisalRuleSelected.Id, newCondition);
            AppraisalRuleSelected.Conditions.Add(newCondition);
            CurrentRuleConditions.DataSource.Add(newCondition);
            CurrentRuleConditions.Refresh();
        }

        public void RemoveConditions(IList<ConditionDTO> conditionsToRemove)
        {
            foreach (var condition in conditionsToRemove)
            {
                _emotionalAppraisalAsset.RemoveAppraisalRuleCondition(AppraisalRuleSelected.Id, condition);
            }
            this.CurrentRuleConditions = new BindingListView<ConditionDTO>(AppraisalRuleSelected.Conditions.ToList());
            CurrentRuleConditions.Refresh();
        }
    }
}
