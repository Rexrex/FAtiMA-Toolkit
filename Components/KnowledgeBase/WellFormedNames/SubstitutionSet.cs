﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Utilities;

namespace KnowledgeBase.WellFormedNames
{
	//TODO improve implementation (dictionary???)
	public sealed class SubstitutionSet : IEnumerable<Substitution>
	{
		private HashSet<Substitution> m_substitutions = new HashSet<Substitution>();

		public SubstitutionSet() {
		}

		public SubstitutionSet(IEnumerable<Substitution> substitutions)
		{
			AddSubstitutions(substitutions);
		}

		public void AddSubstitution(Substitution substitution)
		{
			bool canAdd;
			if (TestConflict(substitution, m_substitutions, out canAdd))
				throw new ArgumentException("The given substitution will generate a conflict.","substitution");

			if (canAdd)
				m_substitutions.Add(substitution);
		}

		public void AddSubstitution(params Substitution[] substitutions)
		{
			this.AddSubstitutions((IEnumerable<Substitution>)substitutions);
		}

		public void AddSubstitutions(IEnumerable<Substitution> substitutions)
		{
			HashSet<Substitution> buffer = ObjectPool<HashSet<Substitution>>.GetObject();
			try
			{
				buffer.UnionWith(m_substitutions);
				foreach (var s in substitutions)
				{
					bool canAdd;
					if (!TestConflict(s, buffer, out canAdd))
						throw new ArgumentException("The given substitution set will generate conflicts.", "substitutions");

					if (canAdd)
						buffer.Add(s);
				}

				var tmp = m_substitutions;
				m_substitutions = buffer;
				buffer = tmp;
			}
			finally
			{
				buffer.Clear();
				ObjectPool<HashSet<Substitution>>.Recycle(buffer);
			}
			foreach (var s in substitutions)
				this.AddSubstitution(s);
		}

		private static bool TestConflict(Substitution subs, HashSet<Substitution> substitutions, out bool canAdd)
		{
			canAdd = true;
			var res = substitutions.FirstOrDefault(s => s.Variable.Equals(subs.Variable));
			if (res == null)
				return false;

			canAdd = false;
			var G1 = res.Value.MakeGround(substitutions);
			var G2 = subs.Value.MakeGround(substitutions);
			return !G1.Equals(G2);	//Conflict!!!
		}

		public bool Conflicts(Substitution substitution)
		{
			bool aux;
			return TestConflict(substitution,m_substitutions, out aux);
		}

		public IEnumerator<Substitution> GetEnumerator()
		{
			return m_substitutions.GetEnumerator();
		}

		IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		public IEnumerable<Substitution> GetGroundedSubstitutions()
		{
			return m_substitutions.Select(s => s.Value.IsGrounded ? s : new Substitution(s.Variable, s.Value.MakeGround(this))).Distinct();
		}

		public override int GetHashCode()
		{
			return this.GetGroundedSubstitutions().Select(s => s.GetHashCode()).Aggregate((v1, v2) => v1 ^ v2);
		}

		public override bool Equals(object obj)
		{
			SubstitutionSet other = obj as SubstitutionSet;
			if (other == null)
				return false;

			HashSet<Substitution> aux1 = ObjectPool<HashSet<Substitution>>.GetObject();
			HashSet<Substitution> aux2 = ObjectPool<HashSet<Substitution>>.GetObject();
			try 
			{	        
				aux1.UnionWith(this.GetGroundedSubstitutions());
				aux2.UnionWith(other.GetGroundedSubstitutions());

				if(aux1.Count != aux2.Count)
					return false;

				return aux1.Except(aux2).Any();
			}
			finally
			{
				aux1.Clear();
				ObjectPool<HashSet<Substitution>>.Recycle(aux1);
				aux2.Clear();
				ObjectPool<HashSet<Substitution>>.Recycle(aux2);
			}
		}

		public override string ToString()
		{
			return m_substitutions.AggregateToString(", ", "(", ")");
		}
	}
}