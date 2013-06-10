using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Examine.LuceneEngine.Faceting;
using Examine.LuceneEngine.SearchCriteria;

namespace Examine.LuceneEngine
{
	internal class EmptySearchResults : ISearchResults
	{
		private List<ISearchResults>  _emptyResult = new List<ISearchResults>();

		public IEnumerator<SearchResult> GetEnumerator()
		{
			return Enumerable.Empty<SearchResult>().GetEnumerator();
		}
        

		IEnumerator IEnumerable.GetEnumerator()
		{
			return Enumerable.Empty<SearchResult>().GetEnumerator();
		}

		public int TotalItemCount
		{
			get { return 0; }
		}

		public IEnumerable<SearchResult> Skip(int skip)
		{
			return Enumerable.Empty<SearchResult>();
		}

        

	    public FacetCounts FacetCounts { get; private set; }
	    

	    public ICriteriaContext CriteriaContext { get; private set; }
	}
}