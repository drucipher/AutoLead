﻿using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace AutoLead.Creators
{
	public abstract class BaseSectionCreator
	{
		#region Methods

		protected virtual List<XElement> GetIdElements(List<AdfId> adfIds, IIdXElementBuilder idXElementBuilder)
		{
			var adfIdElements = new List<XElement>();

			if (adfIds == null || !adfIds.Any())
			{
				return adfIdElements;
			}

			for (var i = 0; i < adfIds.Count; i++)
			{
				adfIdElements.Add(idXElementBuilder.BuildIdElement(adfIds[i], i + 1));
			}

			return adfIdElements;
		}

		#endregion
	}
}
