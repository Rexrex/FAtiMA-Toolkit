﻿using System.Collections.Generic;
using KnowledgeBase.DTOs;
using Utilities;
using WellFormedNames;

namespace KnowledgeBase
{
	public delegate IEnumerable<DynamicPropertyResult> DynamicPropertyCalculator_T1(IQueryContext context, Name arg1);
	public delegate IEnumerable<DynamicPropertyResult> DynamicPropertyCalculator_T2(IQueryContext context, Name arg1, Name arg2);
	public delegate IEnumerable<DynamicPropertyResult> DynamicPropertyCalculator_T3(IQueryContext context, Name arg1, Name arg2, Name arg3);
	public delegate IEnumerable<DynamicPropertyResult> DynamicPropertyCalculator_T4(IQueryContext context, Name arg1, Name arg2, Name arg3, Name arg4);

	public interface IDynamicPropertiesRegistry
	{
		void RegistDynamicProperty(Name propertyName, DynamicPropertyCalculator_T1 surrogate);
		void RegistDynamicProperty(Name propertyName, DynamicPropertyCalculator_T2 surrogate);
		void RegistDynamicProperty(Name propertyName, DynamicPropertyCalculator_T3 surrogate);
		void RegistDynamicProperty(Name propertyName, DynamicPropertyCalculator_T4 surrogate);

		void UnregistDynamicProperty(Name propertyTemplate);

		IEnumerable<DynamicPropertyDTO> GetDynamicProperties();
	}

	public interface IQueryContext
	{
		IQueryable Queryable { get; }
		IEnumerable<SubstitutionSet> Constraints { get; }
		Name Perspective { get; }

		IEnumerable<Pair<UncertainValue, IEnumerable<SubstitutionSet>>> AskPossibleProperties(Name property);
	}

	public struct DynamicPropertyResult
	{
		public readonly Name Value;
		public readonly SubstitutionSet Constraints;

		public DynamicPropertyResult(Name value, SubstitutionSet constraint)
		{
			Value = value;
			Constraints = constraint;
		}
	}

}