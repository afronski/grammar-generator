grammar FiltersLanguageGrammar;

options
{
	language = 'CSharp2';
	output = template;
	backtrack = true;
}

@namespace
{
	FPDev2.Server.Filters.Grammar
}

@header
{
	using System.Collections.Generic;
}

@lexer::members
{
	/// <summary>
	/// 	User name for 'me' token in parameters with 'User' type.
	/// </summary>
	public string ActualUserName { get; set; }

	/// <summary>
	/// 	Passing errors into higher layers.
	/// </summary>
    public override void ReportError(RecognitionException e)
    {
        throw e;
    }
}

@parser::members
{
	/// <summary>
	/// 	User name for 'me' token in parameters with 'User' type.
	/// </summary>
	public string ActualUserName			{ get; set; }

	/// <summary>
	/// 	Sorting column name.
	/// </summary>
	public string SortingColumn				{ get; set; }

	/// <summary>
	/// 	Sorting direction.
	/// </summary>
	public string SortingDirection			{ get; set; }

	/// <summary>
	/// 	Lexical context for grammar.
	/// </summary>
	public string GrammarContext			{ get; set; }

	/// <summary>
	/// 	List with columns widths.
	/// </summary>
	public ArrayList ColumnsWidths
	{
		get
		{
			return _columnsWidths;
		}
	}

	/// <summary>
	/// 	List with columns names.
	/// </summary>
	public ArrayList ColumnsNames
	{
		get
		{
			return _columnsNames;
		}
	}

	/// <summary>
	/// 	Page number.
	/// </summary>
	public int PageNum						{ get; set; }

	/// <summary>
	/// 	Page size.
	/// </summary>
	public int PageSize						{ get; set; }

	/// <summary>
	/// 	Built filter text.
	/// </summary>
	private string _filterText;
	
	/// <summary>
	/// 	Public property for filter text.
	/// </summary>
	public string FilterText				
	{ 
		get
		{
			return _filterText;
		}

		set
		{
			_filterText = value;
		}
	}

	private int _tempInt = 0;
	private DateTime _tempDateTime = DateTime.Now;

	private string _startVal	= string.Empty;
	private string _paramExpr	= string.Empty;

	public string GlobalModulePrefix		{ get; set; }
	public string GlobalModuleLastView		{ get; set; }
	public string GlobalPrimaryID 			{ get; set; }
	public string GlobalFtsID				{ get; set; }
	public string GlobalModuleEverView		{ get; set; }
	public string GlobalMainTable			{ get; set; }
	public string GlobalColsDefault			{ get; set; }

	private int _n2mCount = 0;
	private int _one2manyTextifyCount = 0;
	private int _one2manyConstCount = 0;
	private int _one2manyTableMappedCount = 0;

	private List<string> _globalMainTableList	= new List<string>();
	private List<string> _globalPrimaryIDList 	= new List<string>();
	private List<string> _globalN2MTableList	= new List<string>();
	private List<string> _globalN2MReplyIDList	= new List<string>();
	private List<string> _globalN2MObjTableList	= new List<string>();
	private List<string> _globalN2MObjIDList	= new List<string>();
	private List<string> _globalN2MIsDeletedRestriction = new List<string>();

	private List<string> _globalTextifyPrimaryIDList		   = new List<string>();
	private List<string> _globalTextifyOneToManyForeignKey 	   = new List<string>();
	private List<string> _globalTextifyOneToManyTableName	   = new List<string>();
	private List<string> _globalTextifyOneToManyFieldName	   = new List<string>();
	private List<string> _globalTextifyOneToManyIsDeletedName  = new List<string>();

	private List<string> _globalConstPrimaryIDList				= new List<string>();
	private List<string> _globalConstOneToManyForeignKey 		= new List<string>();
	private List<string> _globalConstOneToManyTableName			= new List<string>();
	private List<string> _globalConstOneToManyFieldName			= new List<string>();
	private List<string> _globalConstOneToManyIsDeletedName		= new List<string>();
	private List<string> _globalConstOneToManyConstColumnName	= new List<string>();
	private List<int>	 _globalConstOneToManyConstIntValue		= new List<int>();

	private List<string> _globalTableMappedPrimaryIDList					  = new List<string>();
	private List<string> _globalTableMappedOneToManyForeignKey				  = new List<string>();
	private List<string> _globalTableMappedOneToManyTableName				  = new List<string>();
	private List<string> _globalTableMappedOneToManyFieldName				  = new List<string>();
	private List<string> _globalTableMappedOneToManySecondTableName			  = new List<string>();
	private List<string> _globalTableMappedOneToManySecondTablePrimaryKey	  = new List<string>();
	private List<string> _globalTableMappedOneToManySecondTableForeignKey	  = new List<string>();

	private Dictionary<string, string> _dictNames =		new Dictionary<string, string>()
														{
												{ "u.", "user" }, { "user.", "user" }
														};

	private Dictionary<string, string> _dictCols =		new Dictionary<string, string>()
														{
												{ "u.", "UserID, Name, Surname, Birthday, SuperPower" }, { "user.", "UserID, Name, Surname, Birthday, SuperPower" }
														};

	private Dictionary<string, string> _dictLastViews =	new Dictionary<string, string>()
														{
												{ "u.", "PeopleLastView" }, { "user.", "PeopleLastView" }
														};

	private Dictionary<string, string> _dictEverViews =	new Dictionary<string, string>()
														{
												{ "u.", "PeopleEverView" }, { "user.", "PeopleEverView" }
														};

	private Dictionary<string, string> _dictMainTable = new Dictionary<string, string>()
														{
												{ "u.", "Users" }, { "user.", "Users" }
														};

	private Dictionary<string, string> _dictFtsID =	new Dictionary<string, string>()
														{
												{ "u.", "ID" }, { "user.", "ID" }
														};

	private Dictionary<string, string> _dictPrimID =	new Dictionary<string, string>()
														{
												{ "u.", "UserID" }, { "user.", "UserID" }
														};

	private Dictionary<string, string> _dictN2MTables = new Dictionary<string, string>()
														{
												{ "u.email", "Users2Emails" }, { "user.email", "Users2Emails" }
														};

	private Dictionary<string, string> _dictN2MReplyID =	new Dictionary<string, string>()
															{
												{ "u.email", "UserID" }, { "user.email", "UserID" } 
															};

	private Dictionary<string, string> _dictN2MObjTables =	new Dictionary<string, string>()
															{
												{ "u.email", "Emails" }, { "user.email", "Emails" }
															};

	private Dictionary<string, string> _dictN2MObjID =	new Dictionary<string, string>()
														{
												{ "u.email", "EmailID" }, { "user.email", "EmailID" }
														};

	private Dictionary<string, string> _dictN2MIsDeletedRestriction =	new Dictionary<string, string>()
														{
												{ "u.email", "" }, { "user.email", "" }
														};

	private Dictionary<string, string> _dictionaryTextifyOneToManyPrimaryCompareKey =	new Dictionary<string, string>()
														{

														};

	private Dictionary<string, string> _dictionaryTextifyOneToManyTextFieldName =	new Dictionary<string, string>()
														{

														};

	private Dictionary<string, string> _dictionaryTextifyOneToManyForeignKeyName =	new Dictionary<string, string>()
														{

														};

	private Dictionary<string, string> _dictionaryTextifyOneToManyTableName =	new Dictionary<string, string>()
														{

														};

	private Dictionary<string, string> _dictionaryTextifyOneToManyIsDeletedName =	new Dictionary<string, string>()
														{

														};

	private Dictionary<string, string> _dictionaryConstOneToManyPrimaryCompareKey =	new Dictionary<string, string>()
														{

														};

	private Dictionary<string, string> _dictionaryConstOneToManyTextFieldName =	new Dictionary<string, string>()
														{

														};

	private Dictionary<string, string> _dictionaryConstOneToManyForeignKeyName =	new Dictionary<string, string>()
														{

														};

	private Dictionary<string, string> _dictionaryConstOneToManyTableName =	new Dictionary<string, string>()
														{

														};

	private Dictionary<string, string> _dictionaryConstOneToManyIsDeletedName =	new Dictionary<string, string>()
														{

														};

	private Dictionary<string, string> _dictionaryConstOneToManyConstColumnName =	new Dictionary<string, string>()
														{

														};

	private Dictionary<string, int> _dictionaryConstOneToManyConstIntValue =	new Dictionary<string, int>()
														{

														};

	private Dictionary<string, string> _dictionaryTableMappedOneToManyPrimaryCompareKey =	new Dictionary<string, string>()
														{
												{ "u.gg", "UserID" }, { "user.gg", "UserID" }
														};

	private Dictionary<string, string> _dictionaryTableMappedOneToManyTextFieldName =	new Dictionary<string, string>()
														{
												{ "u.gg", "Identificator" }, { "user.gg", "Identificator" } 
														};

	private Dictionary<string, string> _dictionaryTableMappedOneToManyForeignKeyName =	new Dictionary<string, string>()
														{
												{ "u.gg", "ID" }, { "user.gg", "ID" }
														};

	private Dictionary<string, string> _dictionaryTableMappedOneToManyTableName =	new Dictionary<string, string>()
														{
												{ "u.gg", "Users" }, { "user.gg", "Users" }
														};

	private Dictionary<string, string> _dictionaryTableMappedOneToManySecondTableName =	new Dictionary<string, string>()
														{
												{ "u.gg", "vwUserCommunicatorsGg" }, { "user.gg", "vwUserCommunicatorsGg" }
														};

	private Dictionary<string, string> _dictionaryTableMappedOneToManySecondTablePrimaryKey =	new Dictionary<string, string>()
														{
												{ "u.gg", "UserID" }, { "user.gg", "UserID" }
														};

	private Dictionary<string, string> _dictionaryTableMappedOneToManyFirstTableForeignKey =	new Dictionary<string, string>()
														{
												{ "u.gg", "ID" }, { "user.gg", "ID" }
														};

	private ArrayList _columnsWidths		= new ArrayList();
	private ArrayList _columnsNames			= new ArrayList();

	private Dictionary<string, int>	_columns = new Dictionary<string, int>();
	public Dictionary<string, int> Columns
	{
		get
		{
			return _columns;
		}
		
		set
		{
			_columns = value;
		}
	}

	public override void ReportError(RecognitionException e)
	{
		throw e;
	}

	private string ConvertTimeSpentToInt(string input)
	{
		int timeValue = 0;

		if (!string.IsNullOrEmpty(input))
		{
			input = input.Trim('"');

			bool containsHours = input.Contains("h");

			if (containsHours)
			{
				timeValue += Convert.ToInt32(input.Substring(0, input.IndexOf("h"))) * 3600;
			}

			if (input.Contains("m"))
			{
				if (containsHours)
				{
					timeValue += Convert.ToInt32(input.Substring(input.IndexOf("h") + 1, input.IndexOf("m") - input.IndexOf("h") - 1)) * 60;
				}
				else
				{
					timeValue += Convert.ToInt32(input.Substring(0, input.IndexOf("m"))) * 60;
				}
			}
		}

		return timeValue.ToString();
	}

	private string ExtractModule(string input, Dictionary<string, string> tokens)
	{
		if (!string.IsNullOrEmpty(GrammarContext))
		{
			return tokens[GrammarContext];
		}

		foreach (var token in tokens)
		{
			if (input.Contains(token.Key))
			{
				return token.Value;
			}
		}

		return tokens["n."];
	}

	private string ExtractManyToManyModuleAndField(string input, string what, Dictionary<string, string> tokens)
	{
		try
		{
			var token = tokens[what];
			return token;
		}
		catch(System.Collections.Generic.KeyNotFoundException e)
		{
			return tokens["n.tag"];
		}
	}

	private string ExtractOneToManyModuleAndField(string input, string what, Dictionary<string, string> tokens)
	{
		try
		{
			var token = tokens[what];
			return token;
		}
		catch(System.Collections.Generic.KeyNotFoundException e)
		{
			return tokens["n.stage"];
		}
	}

	private int ExtractOneToManyModuleAndFieldInt(string input, string what, Dictionary<string, int> tokens)
	{
		try
		{
			var token = tokens[what];
			return token;
		}
		catch(System.Collections.Generic.KeyNotFoundException e)
		{
			return tokens["n.stage"];
		}
	}

	private string MakeColumns(string input, string prefix)
	{
		return input.Replace("columns", String.Format("{0}_columns", prefix));
	}

	private string MakeSorting(string input, string prefix)
	{
		return input.Replace("sorted_by", String.Format("{0}_sorted_by", prefix));
	}

	private void GetDates(ref DateTime startDate, ref DateTime endDate, DateTime pointOfTime)
	{
		double offset = 0;
		switch (pointOfTime.DayOfWeek)
		{
			  case DayOfWeek.Monday:
			  offset = 0;
			  break;
			  case DayOfWeek.Tuesday:
			  offset = -1;
			  break;
			  case DayOfWeek.Wednesday:
			  offset = -2;
			  break;
			  case DayOfWeek.Thursday:
			  offset = -3;
			  break;
			  case DayOfWeek.Friday:
			  offset = -4;
			  break;
			  case DayOfWeek.Saturday:
			  offset = -5;
			  break;
			  case DayOfWeek.Sunday:
			  offset = -6;
			  break;
		}

		endDate = pointOfTime.AddDays(offset);
		startDate = pointOfTime.AddDays(-7 + offset);
	}
}

/* ------------------------------------------------------------------------------------- */
/* Rules                                                                                 */
/* ------------------------------------------------------------------------------------- */

main		:	expr EOF								-> startSQL(expr={$expr.st}, pagenum={PageNum.ToString()}, pagesize={PageSize.ToString()});

expr		:	logicalexpr a = columnsspec b = sortingspec
				{
					GlobalModuleLastView 	= ExtractModule(FilterText, _dictLastViews);
					GlobalModulePrefix 		= ExtractModule(FilterText, _dictNames);
				} -> specified(val = {$logicalexpr.st}, col = {$a.st}, sort = {$b.st}, view = {GlobalModuleLastView})
			|	logicalexpr a = columnsspec
				{
					GlobalModuleLastView 	= ExtractModule(FilterText, _dictLastViews);
					GlobalPrimaryID 		= ExtractModule(FilterText, _dictPrimID);
					GlobalModulePrefix 		= ExtractModule(FilterText, _dictNames);
				} -> specifiedColumns(val = {$logicalexpr.st}, col = {$a.st}, view = {GlobalModuleLastView}, primid = {GlobalPrimaryID})
			|	logicalexpr b = sortingspec
				{
					GlobalModuleLastView 	= ExtractModule(FilterText, _dictLastViews);
					GlobalColsDefault		= ExtractModule(FilterText, _dictCols);
					GlobalModulePrefix 		= ExtractModule(FilterText, _dictNames);
				} -> specifiedSorting(val = {$logicalexpr.st}, sort = {$b.st}, view = {GlobalModuleLastView}, cols = {GlobalColsDefault})
			|	logicalexpr
				{
					GlobalModuleLastView 	= ExtractModule(FilterText, _dictLastViews);
					GlobalPrimaryID 		= ExtractModule(FilterText, _dictPrimID);
					GlobalColsDefault		= ExtractModule(FilterText, _dictCols);
				} -> defaultSQL(val = {$logicalexpr.st}, view = {GlobalModuleLastView}, cols = {GlobalColsDefault}, primid = {GlobalPrimaryID})
			|	'sql' '(' query ')'	-> builtSQL(val = {$query.st})
			|	'__cntl' logicalexpr a = columnsspec b = sortingspec
				{
					GlobalModuleLastView 	= ExtractModule(FilterText, _dictLastViews);
					GlobalModulePrefix 		= ExtractModule(FilterText, _dictNames);
				} -> countspecified_library(val = {$logicalexpr.st}, col = {$a.st}, sort = {$b.st}, view = {GlobalModuleLastView})
			|	'__cntl' logicalexpr a = columnsspec
				{
					GlobalModuleLastView 	= ExtractModule(FilterText, _dictLastViews);
					GlobalPrimaryID 		= ExtractModule(FilterText, _dictPrimID);
					GlobalModulePrefix 		= ExtractModule(FilterText, _dictNames);
				} -> countspecifiedColumns_library(val = {$logicalexpr.st}, col = {$a.st}, view = {GlobalModuleLastView}, primid = {GlobalPrimaryID})
			|	'__cntl' logicalexpr b = sortingspec
				{
					GlobalModuleLastView 	= ExtractModule(FilterText, _dictLastViews);
					GlobalColsDefault		= ExtractModule(FilterText, _dictCols);
					GlobalModulePrefix 		= ExtractModule(FilterText, _dictNames);
				} -> countspecifiedSorting_library(val = {$logicalexpr.st}, sort = {$b.st}, view = {GlobalModuleLastView}, cols = {GlobalColsDefault})
			|	'__cntl'	logicalexpr
				{
					GlobalModuleLastView 	= ExtractModule(FilterText, _dictLastViews);
					GlobalPrimaryID 		= ExtractModule(FilterText, _dictPrimID);
					GlobalColsDefault		= ExtractModule(FilterText, _dictCols);
				} -> countdefaultSQL_library(val = {$logicalexpr.st}, view = {GlobalModuleLastView}, cols = {GlobalColsDefault}, primid = {GlobalPrimaryID})
			|	'__cntl'	'sql' '(' query ')'					-> countbuiltSQL(val = {$query.st})
			|	'__cnt' logicalexpr a = columnsspec b = sortingspec
				{
					GlobalModuleLastView 	= ExtractModule(FilterText, _dictLastViews);
					GlobalModulePrefix 		= ExtractModule(FilterText, _dictNames);
				} -> countspecified(val = {$logicalexpr.st}, col = {$a.st}, sort = {$b.st}, view = {GlobalModuleLastView})
			|	'__cnt' logicalexpr a = columnsspec
				{
					GlobalModuleLastView 	= ExtractModule(FilterText, _dictLastViews);
					GlobalPrimaryID 		= ExtractModule(FilterText, _dictPrimID);
					GlobalModulePrefix 		= ExtractModule(FilterText, _dictNames);
				} -> countspecifiedColumns(val = {$logicalexpr.st}, col = {$a.st}, view = {GlobalModuleLastView}, primid = {GlobalPrimaryID})
			|	'__cnt' logicalexpr b = sortingspec
				{
					GlobalModuleLastView 	= ExtractModule(FilterText, _dictLastViews);
					GlobalColsDefault		= ExtractModule(FilterText, _dictCols);
					GlobalModulePrefix 		= ExtractModule(FilterText, _dictNames);
				} -> countspecifiedSorting(val = {$logicalexpr.st}, sort = {$b.st}, view = {GlobalModuleLastView}, cols = {GlobalColsDefault})
			|	'__cnt'	logicalexpr
				{
					GlobalModuleLastView 	= ExtractModule(FilterText, _dictLastViews);
					GlobalPrimaryID 		= ExtractModule(FilterText, _dictPrimID);
					GlobalColsDefault		= ExtractModule(FilterText, _dictCols);
				} -> countdefaultSQL(val = {$logicalexpr.st}, view = {GlobalModuleLastView}, cols = {GlobalColsDefault}, primid = {GlobalPrimaryID})
			|	'__cnt'	'sql' '(' query ')'					-> countbuiltSQL(val = {$query.st})
			;

logicalexpr :   ( a	= andatom				-> {$a.st} )
				('or' b = andatom			-> or(left={$logicalexpr.st}, right={$b.st}) )*
			;

andatom		:	( a = notexpr				-> {$a.st} )
				('and' b = notexpr			-> and(left={$andatom.st}, right={$b.st}) )*
			;

notexpr		:	'not' a = paramexpr		-> not(left={$paramexpr.st})
			|	 paramexpr				-> {$paramexpr.st}
			;

paramexpr	:	'(' logicalexpr ')'											-> parenthesis(val = {$logicalexpr.st})
			|	token_for_fts
				{
					GlobalMainTable 		= ExtractModule(FilterText, _dictMainTable);
					GlobalPrimaryID 		= ExtractModule(FilterText, _dictPrimID);
					GlobalFtsID				= ExtractModule(FilterText, _dictFtsID);
				} -> fts_param(val = {$token_for_fts.st}, maintable={GlobalMainTable}, primid={GlobalPrimaryID}, ftsid={GlobalFtsID})
			|	parametersStr internalop valStr								-> parameter(p = {$parametersStr.st},  o = {$internalop.st}, v = {$valStr.st})
			|	paramLongStr internalLongStrOp valLongStr					-> parameter(p = {$paramLongStr.st},  o = {$internalLongStrOp.st}, v = {$valLongStr.st})
			|	parametersStr contains containsVal							-> parameter(p = {$parametersStr.st},  o = {$contains.st}, v = {$containsVal.st})
			|	paramLongStr contains containsVal							-> parameter(p = {$paramLongStr.st},  o = {$contains.st}, v = {$containsVal.st})
			|	parametersUser contains containsVal							-> parameter(p = {$parametersUser.st},  o = {$contains.st}, v = {$containsVal.st})
			|	parametersStr doesNotContains doesNotContainsVal			-> parameter(p = {$parametersStr.st},  o = {$doesNotContains.st}, v = {$doesNotContainsVal.st})
			|	paramLongStr doesNotContains doesNotContainsVal				-> parameter(p = {$paramLongStr.st},  o = {$doesNotContains.st}, v = {$doesNotContainsVal.st})
			|	parametersUser doesNotContains doesNotContainsVal			-> parameter(p = {$parametersUser.st},  o = {$doesNotContains.st}, v = {$doesNotContainsVal.st})
			|	parametersStr startsWith startsWithVal						-> parameter(p = {$parametersStr.st},  o = {$startsWith.st}, v = {$startsWithVal.st})
			|	paramLongStr startsWith startsWithVal						-> parameter(p = {$paramLongStr.st},  o = {$startsWith.st}, v = {$startsWithVal.st})
			|	parametersUser startsWith startsWithVal						-> parameter(p = {$parametersUser.st},  o = {$startsWith.st}, v = {$startsWithVal.st})
			|	parametersStr endsWith endsWithVal							-> parameter(p = {$parametersStr.st},  o = {$endsWith.st}, v = {$endsWithVal.st})
			|	paramLongStr endsWith endsWithVal							-> parameter(p = {$paramLongStr.st},  o = {$endsWith.st}, v = {$endsWithVal.st})
			|	parametersUser endsWith endsWithVal							-> parameter(p = {$parametersUser.st},  o = {$endsWith.st}, v = {$endsWithVal.st})
			|	parametersInt internalop valInt								-> parameter(p = {$parametersInt.st},  o = {$internalop.st}, v = {$valInt.st})
			|	parametersDate internalop valDate							-> parameter(p = {$parametersDate.st}, o = {$internalop.st}, v = {$valDate.st})
			|	parametersDate internalopSpan valDateSpan					-> parameter(p = {$parametersDate.st}, o = {$internalopSpan.st}, v = {$valDateSpan.st})
			|	parametersDate lsOpSpan valDateSpanLs						-> parameter(p = {$parametersDate.st}, o = {$lsOpSpan.st}, v = {$valDateSpanLs.st})
			|	parametersDate grOpSpan valDateSpanGr						-> parameter(p = {$parametersDate.st}, o = {$grOpSpan.st}, v = {$valDateSpanGr.st})
			|	parametersDate lsOrEqOpSpan valDateSpanLsOrEq				-> parameter(p = {$parametersDate.st}, o = {$lsOrEqOpSpan.st}, v = {$valDateSpanLsOrEq.st})
			|	parametersDate grOrEqOpSpan valDateSpanGrOrEq				-> parameter(p = {$parametersDate.st}, o = {$grOrEqOpSpan.st}, v = {$valDateSpanGrOrEq.st})
			|	parametersUser internalop valUser							-> parameter(p = {$parametersUser.st}, o = {$internalop.st}, v = {$valUser.st})
			|	parametersBool internalop valBool							-> parameter(p = {$parametersBool.st}, o = {$internalop.st}, v = {$valBool.st})
			|	parametersMapped internalop valStr							-> parameter(p = {$parametersMapped.st},  o = {$internalop.st}, v = {$valStr.st})
			|	parametersStr multivalueinternalop '(' a += valStr (',' a += valStr)* ')'		-> multiparameter(p = {$parametersStr.st},  o = {$multivalueinternalop.st}, v = {$a})
			|	parametersInt multivalueinternalop '(' b += valInt (',' b += valInt)* ')'		-> multiparameter(p = {$parametersInt.st},  o = {$multivalueinternalop.st}, v = {$b})
			|	parametersDate multivalueinternalop '(' c += valDate (',' c += valDate)* ')'	-> multiparameter(p = {$parametersDate.st}, o = {$multivalueinternalop.st}, v = {$c})
			|	parametersUser multivalueinternalop '(' d += valUser (',' d += valUser)* ')'	-> multiparameter(p = {$parametersUser.st}, o = {$multivalueinternalop.st}, v = {$d})
			|	paramLongStr multivalueinternalop '(' longS += valStr (',' longS += valStr)* ')'-> multiparameter(p = {$paramLongStr.st},  o = {$multivalueinternalop.st}, v = {$longS})
			|	parametersMapped multivalueinternalop '(' mapped += valStr (',' mapped += valStr)* ')'	-> multiparameter(p = {$parametersMapped.st},  o = {$multivalueinternalop.st}, v = {$mapped})
			|	parametersStr	'wasever' '(' a += valStr (',' a += valStr)* ')'
				{
					GlobalModuleEverView 	= ExtractModule(FilterText, _dictEverViews);
					GlobalPrimaryID 		= ExtractModule(FilterText, _dictPrimID);
				} -> wasever(col = {$parametersStr.st}, val = {$a}, view={GlobalModuleEverView}, primid={GlobalPrimaryID})
			|	parametersInt	'wasever' '(' b += valInt (',' b += valInt)* ')'
				{
					GlobalModuleEverView 	= ExtractModule(FilterText, _dictEverViews);
					GlobalPrimaryID 		= ExtractModule(FilterText, _dictPrimID);
				} -> wasever(col = {$parametersInt.st}, val = {$b}, view={GlobalModuleEverView}, primid={GlobalPrimaryID})
			|	parametersDate	'wasever' '(' c += valDate (',' c += valDate)* ')'
				{
					GlobalModuleEverView 	= ExtractModule(FilterText, _dictEverViews);
					GlobalPrimaryID 		= ExtractModule(FilterText, _dictPrimID);
				} -> wasever(col = {$parametersDate.st}, val = {$c}, view={GlobalModuleEverView}, primid={GlobalPrimaryID})
			|	parametersUser	'wasever' '(' d += valUser (',' d += valUser)* ')' 
				{
					GlobalModuleEverView 	= ExtractModule(FilterText, _dictEverViews);
					GlobalPrimaryID 		= ExtractModule(FilterText, _dictPrimID);
				} -> wasever(col = {$parametersUser.st}, val = {$d}, view={GlobalModuleEverView}, primid={GlobalPrimaryID})
			|	parametersBool	'wasever' '(' e += valBool (',' e += valBool)* ')'
				{
					GlobalModuleEverView 	= ExtractModule(FilterText, _dictEverViews);
					GlobalPrimaryID 		= ExtractModule(FilterText, _dictPrimID);
				} -> wasever(col = {$parametersBool.st}, val = {$e}, view={GlobalModuleEverView}, primid={GlobalPrimaryID})
			|	parametersDate	'wasever' '(' f += valDateSpan (',' f += valDateSpan)* ')'
				{
					GlobalModuleEverView 	= ExtractModule(FilterText, _dictEverViews);
					GlobalPrimaryID 		= ExtractModule(FilterText, _dictPrimID);
				} -> wasever(col = {$parametersDate.st}, val = {$f}, view={GlobalModuleEverView}, primid={GlobalPrimaryID})
			|	paramLongStr 'wasever' '(' longS += valStr (',' longS += valStr)* ')'
				{
					GlobalModuleEverView 	= ExtractModule(FilterText, _dictEverViews);
					GlobalPrimaryID 		= ExtractModule(FilterText, _dictPrimID);
				} -> wasever(col = {$paramLongStr.st}, val = {$longS}, view={GlobalModuleEverView}, primid={GlobalPrimaryID})
			|	parametersMapped 'wasever' '(' mapped += valStr (',' mapped += valStr)* ')'
				{
					GlobalModuleEverView 	= ExtractModule(FilterText, _dictEverViews);
					GlobalPrimaryID 		= ExtractModule(FilterText, _dictPrimID);
				} -> wasever(col = {$parametersMapped.st}, val = {$mapped}, view={GlobalModuleEverView}, primid={GlobalPrimaryID})
			|	parametersManyToMany internalopN2M valStr
				{
					_globalMainTableList.Add(ExtractModule(FilterText, _dictMainTable));
					_globalPrimaryIDList.Add(ExtractModule(FilterText, _dictPrimID));
					_globalN2MTableList.Add(ExtractManyToManyModuleAndField(_filterText, _paramExpr, _dictN2MTables));
					_globalN2MReplyIDList.Add(ExtractManyToManyModuleAndField(_filterText, _paramExpr, _dictN2MReplyID));
					_globalN2MObjTableList.Add(ExtractManyToManyModuleAndField(_filterText, _paramExpr, _dictN2MObjTables));
					_globalN2MObjIDList.Add(ExtractManyToManyModuleAndField(_filterText, _paramExpr, _dictN2MObjID));
					_globalN2MIsDeletedRestriction.Add(ExtractManyToManyModuleAndField(_filterText, _paramExpr, _dictN2MIsDeletedRestriction));
					_n2mCount++;
				} -> many_to_many(	val = {$valStr.st}, op = {$internalopN2M.st}, maintable = {_globalMainTableList[_n2mCount - 1]}, 
									primid = {_globalPrimaryIDList[_n2mCount - 1]}, 
									n2mtable = {_globalN2MTableList[_n2mCount - 1]}, replyid = {_globalN2MReplyIDList[_n2mCount - 1]}, 
									objtable = {_globalN2MObjTableList[_n2mCount - 1]}, n2mobjid = {_globalN2MObjIDList[_n2mCount - 1]},
									valname = {$parametersManyToMany.st}, isdeletedrestriction = {_globalN2MIsDeletedRestriction[_n2mCount - 1]})
			|	parametersManyToMany internalopNotEqN2M valStr
				{
					_globalMainTableList.Add(ExtractModule(FilterText, _dictMainTable));
					_globalPrimaryIDList.Add(ExtractModule(FilterText, _dictPrimID));
					_globalN2MTableList.Add(ExtractManyToManyModuleAndField(_filterText, _paramExpr, _dictN2MTables));
					_globalN2MReplyIDList.Add(ExtractManyToManyModuleAndField(_filterText, _paramExpr, _dictN2MReplyID));
					_globalN2MObjTableList.Add(ExtractManyToManyModuleAndField(_filterText, _paramExpr, _dictN2MObjTables));
					_globalN2MObjIDList.Add(ExtractManyToManyModuleAndField(_filterText, _paramExpr, _dictN2MObjID));
					_globalN2MIsDeletedRestriction.Add(ExtractManyToManyModuleAndField(_filterText, _paramExpr, _dictN2MIsDeletedRestriction));
					_n2mCount++;
				} -> many_to_many_not(
									val = {$valStr.st}, maintable = {_globalMainTableList[_n2mCount - 1]}, 
									primid = {_globalPrimaryIDList[_n2mCount - 1]}, 
									n2mtable = {_globalN2MTableList[_n2mCount - 1]}, replyid = {_globalN2MReplyIDList[_n2mCount - 1]}, 
									objtable = {_globalN2MObjTableList[_n2mCount - 1]}, n2mobjid = {_globalN2MObjIDList[_n2mCount - 1]},
									valname = {$parametersManyToMany.st}, isdeletedrestriction = {_globalN2MIsDeletedRestriction[_n2mCount - 1]})
			|	parametersManyToMany multivalueinternalop '(' g += valStr (',' g += valStr)* ')'
				{
					_globalMainTableList.Add(ExtractModule(FilterText, _dictMainTable));
					_globalPrimaryIDList.Add(ExtractModule(FilterText, _dictPrimID));
					_globalN2MTableList.Add(ExtractManyToManyModuleAndField(_filterText, _paramExpr, _dictN2MTables));
					_globalN2MReplyIDList.Add(ExtractManyToManyModuleAndField(_filterText, _paramExpr, _dictN2MReplyID));
					_globalN2MObjTableList.Add(ExtractManyToManyModuleAndField(_filterText, _paramExpr, _dictN2MObjTables));
					_globalN2MObjIDList.Add(ExtractManyToManyModuleAndField(_filterText, _paramExpr, _dictN2MObjID));
					_globalN2MIsDeletedRestriction.Add(ExtractManyToManyModuleAndField(_filterText, _paramExpr, _dictN2MIsDeletedRestriction));
					_n2mCount++;
				} -> many_to_many_multi(	val = {$g}, op = {$multivalueinternalop.st}, maintable = {_globalMainTableList[_n2mCount - 1]}, 
											primid = {_globalPrimaryIDList[_n2mCount - 1]}, 
											n2mtable = {_globalN2MTableList[_n2mCount - 1]}, replyid = {_globalN2MReplyIDList[_n2mCount - 1]}, 
											objtable = {_globalN2MObjTableList[_n2mCount - 1]}, n2mobjid = {_globalN2MObjIDList[_n2mCount - 1]},
											valname = {$parametersManyToMany.st}, isdeletedrestriction = {_globalN2MIsDeletedRestriction[_n2mCount - 1]})
			|	parametersManyToMany 'wasever' '(' h += valStr (',' h += valStr)* ')'
				{
					_globalMainTableList.Add(ExtractModule(FilterText, _dictMainTable));
					_globalPrimaryIDList.Add(ExtractModule(FilterText, _dictPrimID));
					_globalN2MTableList.Add(ExtractManyToManyModuleAndField(_filterText, _paramExpr, _dictN2MTables));
					_globalN2MReplyIDList.Add(ExtractManyToManyModuleAndField(_filterText, _paramExpr, _dictN2MReplyID));
					_globalN2MObjTableList.Add(ExtractManyToManyModuleAndField(_filterText, _paramExpr, _dictN2MObjTables));
					_globalN2MObjIDList.Add(ExtractManyToManyModuleAndField(_filterText, _paramExpr, _dictN2MObjID));
					_globalN2MIsDeletedRestriction.Add(ExtractManyToManyModuleAndField(_filterText, _paramExpr, _dictN2MIsDeletedRestriction));
					_n2mCount++;
				} -> many_to_many_wasever(	val = {$h}, maintable = {_globalMainTableList[_n2mCount - 1]}, 
											primid = {_globalPrimaryIDList[_n2mCount - 1]}, 
											n2mtable = {_globalN2MTableList[_n2mCount - 1]}, replyid = {_globalN2MReplyIDList[_n2mCount - 1]}, 
											objtable = {_globalN2MObjTableList[_n2mCount - 1]}, n2mobjid = {_globalN2MObjIDList[_n2mCount - 1]},
											valname = {$parametersManyToMany.st}, isdeletedrestriction = {_globalN2MIsDeletedRestriction[_n2mCount - 1]})
			|	parametersManyToMany contains containsVal
				{
					_globalMainTableList.Add(ExtractModule(FilterText, _dictMainTable));
					_globalPrimaryIDList.Add(ExtractModule(FilterText, _dictPrimID));
					_globalN2MTableList.Add(ExtractManyToManyModuleAndField(_filterText, _paramExpr, _dictN2MTables));
					_globalN2MReplyIDList.Add(ExtractManyToManyModuleAndField(_filterText, _paramExpr, _dictN2MReplyID));
					_globalN2MObjTableList.Add(ExtractManyToManyModuleAndField(_filterText, _paramExpr, _dictN2MObjTables));
					_globalN2MObjIDList.Add(ExtractManyToManyModuleAndField(_filterText, _paramExpr, _dictN2MObjID));
					_globalN2MIsDeletedRestriction.Add(ExtractManyToManyModuleAndField(_filterText, _paramExpr, _dictN2MIsDeletedRestriction));
					_n2mCount++;
				} -> many_to_many(	val = {$containsVal.st}, op = {$contains.st}, maintable = {_globalMainTableList[_n2mCount - 1]}, 
									primid = {_globalPrimaryIDList[_n2mCount - 1]}, 
									n2mtable = {_globalN2MTableList[_n2mCount - 1]}, replyid = {_globalN2MReplyIDList[_n2mCount - 1]}, 
									objtable = {_globalN2MObjTableList[_n2mCount - 1]}, n2mobjid = {_globalN2MObjIDList[_n2mCount - 1]},
									valname = {$parametersManyToMany.st}, isdeletedrestriction = {_globalN2MIsDeletedRestriction[_n2mCount - 1]})
			|	parametersManyToMany doesNotContains doesNotContainsVal
				{
					_globalMainTableList.Add(ExtractModule(FilterText, _dictMainTable));
					_globalPrimaryIDList.Add(ExtractModule(FilterText, _dictPrimID));
					_globalN2MTableList.Add(ExtractManyToManyModuleAndField(_filterText, _paramExpr, _dictN2MTables));
					_globalN2MReplyIDList.Add(ExtractManyToManyModuleAndField(_filterText, _paramExpr, _dictN2MReplyID));
					_globalN2MObjTableList.Add(ExtractManyToManyModuleAndField(_filterText, _paramExpr, _dictN2MObjTables));
					_globalN2MObjIDList.Add(ExtractManyToManyModuleAndField(_filterText, _paramExpr, _dictN2MObjID));
					_globalN2MIsDeletedRestriction.Add(ExtractManyToManyModuleAndField(_filterText, _paramExpr, _dictN2MIsDeletedRestriction));
					_n2mCount++;
				} -> many_to_many_not_contains(
									val = {$doesNotContainsVal.st}, maintable = {_globalMainTableList[_n2mCount - 1]}, 
									primid = {_globalPrimaryIDList[_n2mCount - 1]}, 
									n2mtable = {_globalN2MTableList[_n2mCount - 1]}, replyid = {_globalN2MReplyIDList[_n2mCount - 1]}, 
									objtable = {_globalN2MObjTableList[_n2mCount - 1]}, n2mobjid = {_globalN2MObjIDList[_n2mCount - 1]},
									valname = {$parametersManyToMany.st}, isdeletedrestriction = {_globalN2MIsDeletedRestriction[_n2mCount - 1]})
			|	parametersManyToMany startsWith startsWithVal
				{
					_globalMainTableList.Add(ExtractModule(FilterText, _dictMainTable));
					_globalPrimaryIDList.Add(ExtractModule(FilterText, _dictPrimID));
					_globalN2MTableList.Add(ExtractManyToManyModuleAndField(_filterText, _paramExpr, _dictN2MTables));
					_globalN2MReplyIDList.Add(ExtractManyToManyModuleAndField(_filterText, _paramExpr, _dictN2MReplyID));
					_globalN2MObjTableList.Add(ExtractManyToManyModuleAndField(_filterText, _paramExpr, _dictN2MObjTables));
					_globalN2MObjIDList.Add(ExtractManyToManyModuleAndField(_filterText, _paramExpr, _dictN2MObjID));
					_globalN2MIsDeletedRestriction.Add(ExtractManyToManyModuleAndField(_filterText, _paramExpr, _dictN2MIsDeletedRestriction));
					_n2mCount++;
				} -> many_to_many(	val = {$startsWithVal.st}, op = {$startsWith.st}, maintable = {_globalMainTableList[_n2mCount - 1]}, 
									primid = {_globalPrimaryIDList[_n2mCount - 1]}, 
									n2mtable = {_globalN2MTableList[_n2mCount - 1]}, replyid = {_globalN2MReplyIDList[_n2mCount - 1]}, 
									objtable = {_globalN2MObjTableList[_n2mCount - 1]}, n2mobjid = {_globalN2MObjIDList[_n2mCount - 1]},
									valname = {$parametersManyToMany.st}, isdeletedrestriction = {_globalN2MIsDeletedRestriction[_n2mCount - 1]})
			|	parametersManyToMany endsWith endsWithVal
				{
					_globalMainTableList.Add(ExtractModule(FilterText, _dictMainTable));
					_globalPrimaryIDList.Add(ExtractModule(FilterText, _dictPrimID));
					_globalN2MTableList.Add(ExtractManyToManyModuleAndField(_filterText, _paramExpr, _dictN2MTables));
					_globalN2MReplyIDList.Add(ExtractManyToManyModuleAndField(_filterText, _paramExpr, _dictN2MReplyID));
					_globalN2MObjTableList.Add(ExtractManyToManyModuleAndField(_filterText, _paramExpr, _dictN2MObjTables));
					_globalN2MObjIDList.Add(ExtractManyToManyModuleAndField(_filterText, _paramExpr, _dictN2MObjID));
					_globalN2MIsDeletedRestriction.Add(ExtractManyToManyModuleAndField(_filterText, _paramExpr, _dictN2MIsDeletedRestriction));
					_n2mCount++;
				} -> many_to_many(	val = {$endsWithVal.st}, op = {$endsWith.st}, maintable = {_globalMainTableList[_n2mCount - 1]}, 
									primid = {_globalPrimaryIDList[_n2mCount - 1]}, 
									n2mtable = {_globalN2MTableList[_n2mCount - 1]}, replyid = {_globalN2MReplyIDList[_n2mCount - 1]}, 
									objtable = {_globalN2MObjTableList[_n2mCount - 1]}, n2mobjid = {_globalN2MObjIDList[_n2mCount - 1]},
									valname = {$parametersManyToMany.st}, isdeletedrestriction = {_globalN2MIsDeletedRestriction[_n2mCount - 1]})
			|	parametersTextifyOneToMany internalopN2M valStr
				{
					_one2manyTextifyCount++;
					_globalTextifyPrimaryIDList.Add(ExtractOneToManyModuleAndField(_filterText, _paramExpr, _dictionaryTextifyOneToManyPrimaryCompareKey));
					_globalTextifyOneToManyForeignKey.Add(ExtractOneToManyModuleAndField(_filterText, _paramExpr, _dictionaryTextifyOneToManyForeignKeyName));
					_globalTextifyOneToManyTableName.Add(ExtractOneToManyModuleAndField(_filterText, _paramExpr, _dictionaryTextifyOneToManyTableName));
					_globalTextifyOneToManyFieldName.Add(ExtractOneToManyModuleAndField(_filterText, _paramExpr, _dictionaryTextifyOneToManyTextFieldName));
					_globalTextifyOneToManyIsDeletedName.Add(ExtractOneToManyModuleAndField(_filterText, _paramExpr, _dictionaryTextifyOneToManyIsDeletedName));
				} -> textify_one_to_many(	val = {$valStr.st},
											op = {$internalopN2M.st},
											primid = {_globalTextifyPrimaryIDList[_one2manyTextifyCount - 1]},
											foreignKey = {_globalTextifyOneToManyForeignKey[_one2manyTextifyCount - 1]},
											tableName = {_globalTextifyOneToManyTableName[_one2manyTextifyCount - 1]},
											filteredFieldName = {_globalTextifyOneToManyFieldName[_one2manyTextifyCount - 1]},
											isDeleted = {_globalTextifyOneToManyIsDeletedName[_one2manyTextifyCount - 1]})
			|	parametersTextifyOneToMany internalopNotEqN2M valStr
				{
					_one2manyTextifyCount++;
					_globalTextifyPrimaryIDList.Add(ExtractOneToManyModuleAndField(_filterText, _paramExpr, _dictionaryTextifyOneToManyPrimaryCompareKey));
					_globalTextifyOneToManyForeignKey.Add(ExtractOneToManyModuleAndField(_filterText, _paramExpr, _dictionaryTextifyOneToManyForeignKeyName));
					_globalTextifyOneToManyTableName.Add(ExtractOneToManyModuleAndField(_filterText, _paramExpr, _dictionaryTextifyOneToManyTableName));
					_globalTextifyOneToManyFieldName.Add(ExtractOneToManyModuleAndField(_filterText, _paramExpr, _dictionaryTextifyOneToManyTextFieldName));
					_globalTextifyOneToManyIsDeletedName.Add(ExtractOneToManyModuleAndField(_filterText, _paramExpr, _dictionaryTextifyOneToManyIsDeletedName));
				} -> textify_one_to_many_not(val = {$valStr.st},
											primid = {_globalTextifyPrimaryIDList[_one2manyTextifyCount - 1]},
											foreignKey = {_globalTextifyOneToManyForeignKey[_one2manyTextifyCount - 1]},
											tableName = {_globalTextifyOneToManyTableName[_one2manyTextifyCount - 1]},
											filteredFieldName = {_globalTextifyOneToManyFieldName[_one2manyTextifyCount - 1]},
											isDeleted = {_globalTextifyOneToManyIsDeletedName[_one2manyTextifyCount - 1]})
			|	parametersConstOneToMany internalopN2M valStr
				{
					_one2manyConstCount++;
					_globalConstPrimaryIDList.Add(ExtractOneToManyModuleAndField(_filterText, _paramExpr, _dictionaryConstOneToManyPrimaryCompareKey));
					_globalConstOneToManyForeignKey.Add(ExtractOneToManyModuleAndField(_filterText, _paramExpr, _dictionaryConstOneToManyForeignKeyName));
					_globalConstOneToManyTableName.Add(ExtractOneToManyModuleAndField(_filterText, _paramExpr, _dictionaryConstOneToManyTableName));
					_globalConstOneToManyFieldName.Add(ExtractOneToManyModuleAndField(_filterText, _paramExpr, _dictionaryConstOneToManyTextFieldName));
					_globalConstOneToManyIsDeletedName.Add(ExtractOneToManyModuleAndField(_filterText, _paramExpr, _dictionaryConstOneToManyIsDeletedName));
					_globalConstOneToManyConstColumnName.Add(ExtractOneToManyModuleAndField(_filterText, _paramExpr, _dictionaryConstOneToManyConstColumnName));
					_globalConstOneToManyConstIntValue.Add(ExtractOneToManyModuleAndFieldInt(_filterText, _paramExpr, _dictionaryConstOneToManyConstIntValue));
				} -> const_one_to_many(	val = {$valStr.st}, op = {$internalopN2M.st},
										primid = {_globalConstPrimaryIDList[_one2manyConstCount - 1]},
										foreignKey = {_globalConstOneToManyForeignKey[_one2manyConstCount - 1]},
										tableName = {_globalConstOneToManyTableName[_one2manyConstCount - 1]},
										filteredFieldName = {_globalConstOneToManyFieldName[_one2manyConstCount - 1]},
										isDeleted = {_globalConstOneToManyIsDeletedName[_one2manyConstCount - 1]},
										constColumnName = {_globalConstOneToManyConstColumnName[_one2manyConstCount - 1]},
										constIntValue = {_globalConstOneToManyConstIntValue[_one2manyConstCount - 1]})
			|	parametersConstOneToMany internalopNotEqN2M valStr
				{
					_one2manyConstCount++;
					_globalConstPrimaryIDList.Add(ExtractOneToManyModuleAndField(_filterText, _paramExpr, _dictionaryConstOneToManyPrimaryCompareKey));
					_globalConstOneToManyForeignKey.Add(ExtractOneToManyModuleAndField(_filterText, _paramExpr, _dictionaryConstOneToManyForeignKeyName));
					_globalConstOneToManyTableName.Add(ExtractOneToManyModuleAndField(_filterText, _paramExpr, _dictionaryConstOneToManyTableName));
					_globalConstOneToManyFieldName.Add(ExtractOneToManyModuleAndField(_filterText, _paramExpr, _dictionaryConstOneToManyTextFieldName));
					_globalConstOneToManyIsDeletedName.Add(ExtractOneToManyModuleAndField(_filterText, _paramExpr, _dictionaryConstOneToManyIsDeletedName));
					_globalConstOneToManyConstColumnName.Add(ExtractOneToManyModuleAndField(_filterText, _paramExpr, _dictionaryConstOneToManyConstColumnName));
					_globalConstOneToManyConstIntValue.Add(ExtractOneToManyModuleAndFieldInt(_filterText, _paramExpr, _dictionaryConstOneToManyConstIntValue));
				} -> const_one_to_many_not(	val = {$valStr.st},
											primid = {_globalConstPrimaryIDList[_one2manyConstCount - 1]},
											foreignKey = {_globalConstOneToManyForeignKey[_one2manyConstCount - 1]},
											tableName = {_globalConstOneToManyTableName[_one2manyConstCount - 1]},
											filteredFieldName = {_globalConstOneToManyFieldName[_one2manyConstCount - 1]},
											isDeleted = {_globalConstOneToManyIsDeletedName[_one2manyConstCount - 1]},
											constColumnName = {_globalConstOneToManyConstColumnName[_one2manyConstCount - 1]},
											constIntValue = {_globalConstOneToManyConstIntValue[_one2manyConstCount - 1]})
			|	parametersTableMappedOneToMany internalopN2M valStr
				{
					_one2manyTableMappedCount++;
					_globalTableMappedPrimaryIDList.Add(ExtractOneToManyModuleAndField(_filterText, _paramExpr, _dictionaryTableMappedOneToManyPrimaryCompareKey));
					_globalTableMappedOneToManyForeignKey.Add(ExtractOneToManyModuleAndField(_filterText, _paramExpr, _dictionaryTableMappedOneToManyForeignKeyName));
					_globalTableMappedOneToManyTableName.Add(ExtractOneToManyModuleAndField(_filterText, _paramExpr, _dictionaryTableMappedOneToManyTableName));
					_globalTableMappedOneToManyFieldName.Add(ExtractOneToManyModuleAndField(_filterText, _paramExpr, _dictionaryTableMappedOneToManyTextFieldName));
					_globalTableMappedOneToManySecondTableName.Add(ExtractOneToManyModuleAndField(_filterText, _paramExpr, _dictionaryTableMappedOneToManySecondTableName));
					_globalTableMappedOneToManySecondTablePrimaryKey.Add(ExtractOneToManyModuleAndField(_filterText, _paramExpr, _dictionaryTableMappedOneToManySecondTablePrimaryKey));
					_globalTableMappedOneToManySecondTableForeignKey.Add(ExtractOneToManyModuleAndField(_filterText, _paramExpr, _dictionaryTableMappedOneToManyFirstTableForeignKey));
				} -> table_mapped_one_to_many(	val = {$valStr.st}, op = {$internalopN2M.st},
												primid = {_globalTableMappedPrimaryIDList[_one2manyTableMappedCount - 1]},
												foreignKey = {_globalTableMappedOneToManyForeignKey[_one2manyTableMappedCount - 1]},
												tableName = {_globalTableMappedOneToManyTableName[_one2manyTableMappedCount - 1]},
												filteredFieldName = {_globalTableMappedOneToManyFieldName[_one2manyTableMappedCount - 1]},
												secondTableName = {_globalTableMappedOneToManySecondTableName[_one2manyTableMappedCount - 1]},
												secondTablePK = {_globalTableMappedOneToManySecondTablePrimaryKey[_one2manyTableMappedCount - 1]},
												secondTableFK = {_globalTableMappedOneToManySecondTableForeignKey[_one2manyTableMappedCount - 1]})
			|	parametersTableMappedOneToMany internalopNotEqN2M valStr
				{
					_one2manyTableMappedCount++;
					_globalTableMappedPrimaryIDList.Add(ExtractOneToManyModuleAndField(_filterText, _paramExpr, _dictionaryTableMappedOneToManyPrimaryCompareKey));
					_globalTableMappedOneToManyForeignKey.Add(ExtractOneToManyModuleAndField(_filterText, _paramExpr, _dictionaryTableMappedOneToManyForeignKeyName));
					_globalTableMappedOneToManyTableName.Add(ExtractOneToManyModuleAndField(_filterText, _paramExpr, _dictionaryTableMappedOneToManyTableName));
					_globalTableMappedOneToManyFieldName.Add(ExtractOneToManyModuleAndField(_filterText, _paramExpr, _dictionaryTableMappedOneToManyTextFieldName));
					_globalTableMappedOneToManySecondTableName.Add(ExtractOneToManyModuleAndField(_filterText, _paramExpr, _dictionaryTableMappedOneToManySecondTableName));
					_globalTableMappedOneToManySecondTablePrimaryKey.Add(ExtractOneToManyModuleAndField(_filterText, _paramExpr, _dictionaryTableMappedOneToManySecondTablePrimaryKey));
					_globalTableMappedOneToManySecondTableForeignKey.Add(ExtractOneToManyModuleAndField(_filterText, _paramExpr, _dictionaryTableMappedOneToManyFirstTableForeignKey));
				} -> table_mapped_one_to_many_not(	val = {$valStr.st},
													primid = {_globalTableMappedPrimaryIDList[_one2manyTableMappedCount - 1]},
													foreignKey = {_globalTableMappedOneToManyForeignKey[_one2manyTableMappedCount - 1]},
													tableName = {_globalTableMappedOneToManyTableName[_one2manyTableMappedCount - 1]},
													filteredFieldName = {_globalTableMappedOneToManyFieldName[_one2manyTableMappedCount - 1]},
													secondTableName = {_globalTableMappedOneToManySecondTableName[_one2manyTableMappedCount - 1]},
													secondTablePK = {_globalTableMappedOneToManySecondTablePrimaryKey[_one2manyTableMappedCount - 1]},
													secondTableFK = {_globalTableMappedOneToManySecondTableForeignKey[_one2manyTableMappedCount - 1]})
			;

/* ------------------------------------------------------------------------------------- */
/* Values                                                                                */
/* ------------------------------------------------------------------------------------- */
valInt		:	a = STRING
				{
					a.Text = a.Text.Replace("'", "''");
					a.Text = a.Text.Replace("\"", "");

					bool result = int.TryParse(a.Text, out _tempInt);

					if (!result)
					{
						throw new ArgumentException("Invalid integer value.");
					}
				}															-> intvalue(value = {_tempInt})
			|	INT															-> intvalue(value = {$INT.text})
			;

valBool		:	boolToken													-> othervalue(value = {$boolToken.st})
			;

query		:	a = STRING
				{
					// Always insert ROW_NUMBER() after select phrase...
					a.Text = a.Text.Insert(8, "ROW_NUMBER() OVER(ORDER BY NoteID DESC) AS RowNum,");
					a.Text = a.Text.Replace("\"", "");
				}															-> strvalue(value = {$STRING.text})
			;

valStr		:	a = STRING
				{
					if (_paramExpr.Contains("time_spent") || _paramExpr.Contains("estimation") || _paramExpr.Contains("remaining"))
					{
						a.Text = ConvertTimeSpentToInt(a.Text);
					}
					else
					{
						a.Text = a.Text.Replace("'", "''");
						a.Text = a.Text.Replace("\"", "\'");
						a.Text = a.Text.Insert(0, "N");
					}
				}															-> strvalue(value = {$STRING.text})
			;

valLongStr	:	a = STRING
				{
					a.Text = a.Text.Replace("'", "''");
					a.Text = a.Text.Replace("\"", "");										
				}															-> longstrvalue(value = {$STRING.text})
			;

valDate		:	a = '"now"'
				{
					a.Text = DateTime.Now.ToString("yyyy-MM-dd");	
				}															-> datevalue(value = {$a.text})
			|	a = 'now'
				{
					a.Text = DateTime.Now.ToString("yyyy-MM-dd");	
				}															-> datevalue(value = {$a.text})
			|	a = 'today'
				{
					a.Text = DateTime.Now.ToString("yyyy-MM-dd");	
				}															-> datevalue(value = {$a.text})
			|	a = '"today"'
				{
					a.Text = DateTime.Now.ToString("yyyy-MM-dd");	
				}															-> datevalue(value = {$a.text})
			|	a = 'yesterday'
				{
					a.Text = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd");
				}															-> datevalue(value = {$a.text})
			|	a = '"yesterday"'
				{
					a.Text = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd");
				}															-> datevalue(value = {$a.text})
			|	a = 'tomorrow'
				{
					a.Text = DateTime.Now.AddDays(1).ToString("yyyy-MM-dd");
				}															-> datevalue(value = {$a.text})
			|	a = '"tomorrow"'
				{
					a.Text = DateTime.Now.AddDays(1).ToString("yyyy-MM-dd");
				}															-> datevalue(value = {$a.text})
			|	a = STRING
				{
					a.Text = a.Text.Replace("'", "''");
					a.Text = a.Text.Replace("\"", "");

					DateTime tempUS = DateTime.Now, tempPL = DateTime.Now;
					bool resultUS = true, resultPL = true;

					try
					{
						tempPL = DateTime.ParseExact(a.Text, "dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture);
					}
					catch(Exception)
					{
						try
						{
							tempPL = DateTime.ParseExact(a.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
						}
						catch(Exception)
						{
							resultUS = DateTime.TryParse(a.Text, System.Globalization.CultureInfo.CreateSpecificCulture("en-US"), System.Globalization.DateTimeStyles.None, out tempUS);
							resultPL = DateTime.TryParse(a.Text, System.Globalization.CultureInfo.CreateSpecificCulture("pl-PL"), System.Globalization.DateTimeStyles.None, out tempPL);

							if (!resultUS && !resultPL)
							{
								throw new ArgumentException("Invalid date value or unsupported format.");
							}
						}
					}

					_tempDateTime = resultPL ? tempPL : tempUS;
				}															-> datevalue(value = {_tempDateTime})
			|	a = DATE
				{
					a.Text = Convert.ToDateTime(a.Text, new System.Globalization.CultureInfo("pl-PL")).ToString("yyyy-MM-dd");
				}															-> datevalue(value = {$a.text})
			;

valDateSpanLs	:	a = 'lastweek'
					{
						DateTime start = DateTime.Now;
						DateTime _startDate = DateTime.MinValue;
						DateTime _endDate = DateTime.MaxValue;

						GetDates(ref _startDate, ref _endDate, start);

						a.Text = _startDate.ToString("yyyy-MM-dd");
					}															-> datevalue(value = {$a.text})
				|	a = '"lastweek"'
					{
						DateTime start = DateTime.Now;
						DateTime _startDate = DateTime.MinValue;
						DateTime _endDate = DateTime.MaxValue;

						GetDates(ref _startDate, ref _endDate, start);

						a.Text = _startDate.ToString("yyyy-MM-dd");
					}															-> datevalue(value = {$a.text})
				|	a = 'lastmonth'
					{
						DateTime start = DateTime.Now;
	
						a.Text = new DateTime(start.Year, start.Month - 1, 1, 1, 0, 0).ToString("yyyy-MM-dd");

					}															-> datevalue(value = {$a.text})
				|	a = '"lastmonth"'
					{
						DateTime start = DateTime.Now;

						a.Text = new DateTime(start.Year, start.Month - 1, 1, 1, 0, 0).ToString("yyyy-MM-dd");

					}															-> datevalue(value = {$a.text})
				|	a = 'thisweek'
					{
						DateTime start = DateTime.Now.AddDays(7);
						DateTime _startDate = DateTime.MinValue;
						DateTime _endDate = DateTime.MaxValue;

						GetDates(ref _startDate, ref _endDate, start);

						a.Text = _startDate.ToString("yyyy-MM-dd");
					}															-> datevalue(value = {$a.text})
				|	a = '"thisweek"'
					{
						DateTime start = DateTime.Now.AddDays(7);
						DateTime _startDate = DateTime.MinValue;
						DateTime _endDate = DateTime.MaxValue;

						GetDates(ref _startDate, ref _endDate, start);

						a.Text = _startDate.ToString("yyyy-MM-dd");
					}															-> datevalue(value = {$a.text})
				|	a = 'thismonth'
					{
						DateTime start = DateTime.Now;							
						a.Text = new DateTime(start.Year, start.Month, 1, 1, 0, 0).ToString("yyyy-MM-dd");
					}															-> datevalue(value = {$a.text})
				|	a = '"thismonth"'
					{
						DateTime start = DateTime.Now;							
						a.Text = new DateTime(start.Year, start.Month, 1, 1, 0, 0).ToString("yyyy-MM-dd");
					}															-> datevalue(value = {$a.text})
				;

valDateSpanLsOrEq	:	a = 'lastweek'
						{
							DateTime start = DateTime.Now;
							DateTime _startDate = DateTime.MinValue;
							DateTime _endDate = DateTime.MaxValue;

							GetDates(ref _startDate, ref _endDate, start);

							a.Text = _endDate.ToString("yyyy-MM-dd");
						}															-> datevalue(value = {$a.text})
					|	a = '"lastweek"'
						{
							DateTime start = DateTime.Now;
							DateTime _startDate = DateTime.MinValue;
							DateTime _endDate = DateTime.MaxValue;

							GetDates(ref _startDate, ref _endDate, start);

							a.Text = _endDate.ToString("yyyy-MM-dd");
						}															-> datevalue(value = {$a.text})
					|	a = 'lastmonth'
						{
							DateTime start = DateTime.Now;

							a.Text = new DateTime(start.Year, start.Month - 1, 1, 1, 0, 0).ToString("yyyy-MM-dd");

						}															-> datevalue(value = {$a.text})
					|	a = '"lastmonth"'
						{
							DateTime start = DateTime.Now;

							a.Text = new DateTime(start.Year, start.Month - 1, 1, 1, 0, 0).ToString("yyyy-MM-dd");

						}															-> datevalue(value = {$a.text})
					|	a = 'thisweek'
						{
							DateTime start = DateTime.Now.AddDays(7);
							DateTime _startDate = DateTime.MinValue;
							DateTime _endDate = DateTime.MaxValue;

							GetDates(ref _startDate, ref _endDate, start);

							a.Text = _endDate.ToString("yyyy-MM-dd");
						}															-> datevalue(value = {$a.text})
					|	a = '"thisweek"'
						{
							DateTime start = DateTime.Now.AddDays(7);
							DateTime _startDate = DateTime.MinValue;
							DateTime _endDate = DateTime.MaxValue;

							GetDates(ref _startDate, ref _endDate, start);

							a.Text = _endDate.ToString("yyyy-MM-dd");
						}															-> datevalue(value = {$a.text})
					|	a = 'thismonth'
						{
							DateTime start = DateTime.Now;							
							a.Text = new DateTime(start.Year, start.Month, 1, 1, 0, 0).ToString("yyyy-MM-dd");
						}															-> datevalue(value = {$a.text})
					|	a = '"thismonth"'
						{
							DateTime start = DateTime.Now;							
							a.Text = new DateTime(start.Year, start.Month, 1, 1, 0, 0).ToString("yyyy-MM-dd");
						}															-> datevalue(value = {$a.text})
					;

valDateSpanGr	:	a = 'lastweek'
					{
						DateTime start = DateTime.Now;
						DateTime _startDate = DateTime.MinValue;
						DateTime _endDate = DateTime.MaxValue;

						GetDates(ref _startDate, ref _endDate, start);

						a.Text = _startDate.ToString("yyyy-MM-dd");
					}															-> datevalue(value = {$a.text})
				|	a = '"lastweek"'
					{
						DateTime start = DateTime.Now;
						DateTime _startDate = DateTime.MinValue;
						DateTime _endDate = DateTime.MaxValue;

						GetDates(ref _startDate, ref _endDate, start);

						a.Text = _startDate.ToString("yyyy-MM-dd");
					}															-> datevalue(value = {$a.text})
				|	a = 'lastmonth'
					{
						DateTime start = DateTime.Now;

						a.Text = new DateTime(start.Year, start.Month - 1, DateTime.DaysInMonth(start.Year, start.Month - 1), 1, 0, 0).ToString("yyyy-MM-dd");

					}															-> datevalue(value = {$a.text})
				|	a = '"lastmonth"'
					{
						DateTime start = DateTime.Now;

						a.Text = new DateTime(start.Year, start.Month - 1, DateTime.DaysInMonth(start.Year, start.Month - 1), 1, 0, 0).ToString("yyyy-MM-dd");

					}															-> datevalue(value = {$a.text})
				|	a = 'thisweek'
					{
						DateTime start = DateTime.Now.AddDays(7);
						DateTime _startDate = DateTime.MinValue;
						DateTime _endDate = DateTime.MaxValue;

						GetDates(ref _startDate, ref _endDate, start);

						a.Text = _startDate.ToString("yyyy-MM-dd");
					}															-> datevalue(value = {$a.text})
				|	a = '"thisweek"'
					{
						DateTime start = DateTime.Now.AddDays(7);
						DateTime _startDate = DateTime.MinValue;
						DateTime _endDate = DateTime.MaxValue;

						GetDates(ref _startDate, ref _endDate, start);

						a.Text = _startDate.ToString("yyyy-MM-dd");
					}															-> datevalue(value = {$a.text})
				|	a = 'thismonth'
					{
						DateTime start = DateTime.Now;
						a.Text = new DateTime(start.Year, start.Month, DateTime.DaysInMonth(start.Year, start.Month), 1, 0, 0).ToString("yyyy-MM-dd");
					}															-> datevalue(value = {$a.text})
				|	a = '"thismonth"'
					{
						DateTime start = DateTime.Now;
						a.Text = new DateTime(start.Year, start.Month, DateTime.DaysInMonth(start.Year, start.Month), 1, 0, 0).ToString("yyyy-MM-dd");
					}															-> datevalue(value = {$a.text})
				;

valDateSpanGrOrEq	:	a = 'lastweek'
						{
							DateTime start = DateTime.Now;
							DateTime _startDate = DateTime.MinValue;
							DateTime _endDate = DateTime.MaxValue;

							GetDates(ref _startDate, ref _endDate, start);

							a.Text = _endDate.ToString("yyyy-MM-dd");
						}															-> datevalue(value = {$a.text})
					|	a = '"lastweek"'
						{
							DateTime start = DateTime.Now;
							DateTime _startDate = DateTime.MinValue;
							DateTime _endDate = DateTime.MaxValue;

							GetDates(ref _startDate, ref _endDate, start);

							a.Text = _endDate.ToString("yyyy-MM-dd");
						}															-> datevalue(value = {$a.text})
					|	a = 'lastmonth'
						{
							DateTime start = DateTime.Now;

							a.Text = new DateTime(start.Year, start.Month - 1, DateTime.DaysInMonth(start.Year, start.Month - 1), 1, 0, 0).ToString("yyyy-MM-dd");

						}															-> datevalue(value = {$a.text})
					|	a = '"lastmonth"'
						{
							DateTime start = DateTime.Now;

							a.Text = new DateTime(start.Year, start.Month - 1, DateTime.DaysInMonth(start.Year, start.Month - 1), 1, 0, 0).ToString("yyyy-MM-dd");

						}															-> datevalue(value = {$a.text})
					|	a = 'thisweek'
						{
							DateTime start = DateTime.Now.AddDays(7);
							DateTime _startDate = DateTime.MinValue;
							DateTime _endDate = DateTime.MaxValue;

							GetDates(ref _startDate, ref _endDate, start);

							a.Text = _endDate.ToString("yyyy-MM-dd");
						}															-> datevalue(value = {$a.text})
					|	a = '"thisweek"'
						{
							DateTime start = DateTime.Now.AddDays(7);
							DateTime _startDate = DateTime.MinValue;
							DateTime _endDate = DateTime.MaxValue;

							GetDates(ref _startDate, ref _endDate, start);

							a.Text = _endDate.ToString("yyyy-MM-dd");
						}															-> datevalue(value = {$a.text})
					|	a = 'thismonth'
						{
							DateTime start = DateTime.Now;
							a.Text = new DateTime(start.Year, start.Month, DateTime.DaysInMonth(start.Year, start.Month), 1, 0, 0).ToString("yyyy-MM-dd");
						}															-> datevalue(value = {$a.text})
					|	a = '"thismonth"'
						{
							DateTime start = DateTime.Now;
							a.Text = new DateTime(start.Year, start.Month, DateTime.DaysInMonth(start.Year, start.Month), 1, 0, 0).ToString("yyyy-MM-dd");
						}															-> datevalue(value = {$a.text})
					;

valDateSpan :	a = 'lastweek'
				{ 
					DateTime start = DateTime.Now.AddDays(-1);
					DateTime _startDate = DateTime.MinValue;
					DateTime _endDate = DateTime.MaxValue;

					GetDates(ref _startDate, ref _endDate, start);

					_startVal = _startDate.ToString("yyyy-MM-dd");
					a.Text = _endDate.ToString("yyyy-MM-dd");
				}															-> datespanvalue(start = {_startVal}, end = {$a.text})
			|	a = '"lastweek"'
				{ 
					DateTime start = DateTime.Now.AddDays(-1);
					DateTime _startDate = DateTime.MinValue;
					DateTime _endDate = DateTime.MaxValue;

					GetDates(ref _startDate, ref _endDate, start);

					_startVal = _startDate.ToString("yyyy-MM-dd");
					a.Text = _endDate.ToString("yyyy-MM-dd");
				}															-> datespanvalue(start = {_startVal}, end = {$a.text})
			|	a = 'lastmonth'
				{
					DateTime start = DateTime.Now;	
					_startVal = new DateTime(start.Year, start.Month - 1, 1, 1, 0, 0).ToString("yyyy-MM-dd");
					a.Text = new DateTime(start.Year, start.Month - 1, DateTime.DaysInMonth(start.Year, start.Month - 1), 1, 0, 0).ToString("yyyy-MM-dd");

				}															-> datespanvalue(start = {_startVal}, end = {$a.text})
			|	a = '"lastmonth"'
				{
					DateTime start = DateTime.Now;	
					_startVal = new DateTime(start.Year, start.Month - 1, 1, 1, 0, 0).ToString("yyyy-MM-dd");
					a.Text = new DateTime(start.Year, start.Month - 1, DateTime.DaysInMonth(start.Year, start.Month - 1), 1, 0, 0).ToString("yyyy-MM-dd");

				}															-> datespanvalue(start = {_startVal}, end = {$a.text})
			|	a = 'thisweek'
				{
					DateTime start = DateTime.Now.AddDays(7);
					DateTime _startDate = DateTime.MinValue;
					DateTime _endDate = DateTime.MaxValue;

					GetDates(ref _startDate, ref _endDate, start);

					_startVal = _startDate.ToString("yyyy-MM-dd");
					a.Text = _endDate.ToString("yyyy-MM-dd");
				}															-> datespanvalue(start = {_startVal}, end = {$a.text})
			|	a = '"thisweek"'
				{
					DateTime start = DateTime.Now.AddDays(7);
					DateTime _startDate = DateTime.MinValue;
					DateTime _endDate = DateTime.MaxValue;

					GetDates(ref _startDate, ref _endDate, start);

					_startVal = _startDate.ToString("yyyy-MM-dd");
					a.Text = _endDate.ToString("yyyy-MM-dd");
				}															-> datespanvalue(start = {_startVal}, end = {$a.text})
			|	a = 'thismonth'
				{
					DateTime start = DateTime.Now;	
					_startVal = new DateTime(start.Year, start.Month, 1, 1, 0, 0).ToString("yyyy-MM-dd");
					a.Text = new DateTime(start.Year, start.Month, DateTime.DaysInMonth(start.Year, start.Month), 1, 0, 0).ToString("yyyy-MM-dd");
				}															-> datespanvalue(start = {_startVal}, end = {$a.text})
			|	a = '"thismonth"'
				{
					DateTime start = DateTime.Now;	
					_startVal = new DateTime(start.Year, start.Month, 1, 1, 0, 0).ToString("yyyy-MM-dd");
					a.Text = new DateTime(start.Year, start.Month, DateTime.DaysInMonth(start.Year, start.Month), 1, 0, 0).ToString("yyyy-MM-dd");
				}															-> datespanvalue(start = {_startVal}, end = {$a.text})
			;

valUser		:	a = STRING
				{
					a.Text = a.Text.Replace("'", "''");
					a.Text = a.Text.Replace("\"", "\'");
				}															-> strvalue(value = {$STRING.text})
			|	a = '"me"'
				{
					a.Text = "\'" + ActualUserName + "\'";
				}															-> othervalue(value = {$a.text})
			|	a = 'me'
				{
					a.Text = "\'" + ActualUserName + "\'";
				}															-> othervalue(value = {$a.text})
			;

/* ------------------------------------------------------------------------------------- */
/* Typed parameters                                                                      */
/* ------------------------------------------------------------------------------------- */

parametersStr			:
				'user.' 	user_stringparameters		
				{
					_paramExpr = _paramExpr.Insert(0, "user.");
				} ->	{$user_stringparameters.st}
|
				'u.' 	user_stringparameters		
				{
					_paramExpr = _paramExpr.Insert(0, "u.");
				} ->	{$user_stringparameters.st}
						;

paramLongStr			:
				'user.' 	user_longstringparameters		
				{
					_paramExpr = _paramExpr.Insert(0, "user.");
				} ->	{$user_longstringparameters.st}
|
				'u.' 	user_longstringparameters		
				{
					_paramExpr = _paramExpr.Insert(0, "u.");
				} ->	{$user_longstringparameters.st}
						;

parametersInt			:
				'user.' 	user_intparameters		
				{
					_paramExpr = _paramExpr.Insert(0, "user.");
				} ->	{$user_intparameters.st}
|
				'u.' 	user_intparameters		
				{
					_paramExpr = _paramExpr.Insert(0, "u.");
				} ->	{$user_intparameters.st}
						;

parametersDate			:
				'user.' 	user_normaldateparameters		
				{
					_paramExpr = _paramExpr.Insert(0, "user.");
				} ->	{$user_normaldateparameters.st}
|
				'u.' 	user_normaldateparameters		
				{
					_paramExpr = _paramExpr.Insert(0, "u.");
				} ->	{$user_normaldateparameters.st}
|
				'user.' 	user_pastdateparameters		
				{
					_paramExpr = _paramExpr.Insert(0, "user.");
				} ->	{$user_pastdateparameters.st}
|
				'u.' 	user_pastdateparameters		
				{
					_paramExpr = _paramExpr.Insert(0, "u.");
				} ->	{$user_pastdateparameters.st}
						;

parametersUser			:
				'user.' 	user_userparameters		
				{
					_paramExpr = _paramExpr.Insert(0, "user.");
				} ->	{$user_userparameters.st}
|
				'u.' 	user_userparameters		
				{
					_paramExpr = _paramExpr.Insert(0, "u.");
				} ->	{$user_userparameters.st}
						;

parametersBool			:
				'user.' 	user_boolparameters		
				{
					_paramExpr = _paramExpr.Insert(0, "user.");
				} ->	{$user_boolparameters.st}
|
				'u.' 	user_boolparameters		
				{
					_paramExpr = _paramExpr.Insert(0, "u.");
				} ->	{$user_boolparameters.st}
						;

parametersMapped		:
				'user.' 	user_mappedparameters		
				{
					_paramExpr = _paramExpr.Insert(0, "user.");
				} ->	{$user_mappedparameters.st}
|
				'u.' 	user_mappedparameters		
				{
					_paramExpr = _paramExpr.Insert(0, "u.");
				} ->	{$user_mappedparameters.st}
						;

parametersManyToMany	:
				'user.' 	user_manytomanyparameters		
				{
					_paramExpr = _paramExpr.Insert(0, "user.");
				} ->	{$user_manytomanyparameters.st}
|
				'u.' 	user_manytomanyparameters		
				{
					_paramExpr = _paramExpr.Insert(0, "u.");
				} ->	{$user_manytomanyparameters.st}
						;

parametersConstOneToMany		:
				'user.' 	user_constonetomanyparameters		
				{
					_paramExpr = _paramExpr.Insert(0, "user.");
				} ->	{$user_constonetomanyparameters.st}
|
				'u.' 	user_constonetomanyparameters		
				{
					_paramExpr = _paramExpr.Insert(0, "u.");
				} ->	{$user_constonetomanyparameters.st}
								;

parametersTextifyOneToMany		:
				'user.' 	user_textifyonetomanyparameters		
				{
					_paramExpr = _paramExpr.Insert(0, "user.");
				} ->	{$user_textifyonetomanyparameters.st}
|
				'u.' 	user_textifyonetomanyparameters		
				{
					_paramExpr = _paramExpr.Insert(0, "u.");
				} ->	{$user_textifyonetomanyparameters.st}
								;

parametersTableMappedOneToMany	:
				'user.' 	user_tablemappedonetomanyparameters		
				{
					_paramExpr = _paramExpr.Insert(0, "user.");
				} ->	{$user_tablemappedonetomanyparameters.st}
|
				'u.' 	user_tablemappedonetomanyparameters		
				{
					_paramExpr = _paramExpr.Insert(0, "u.");
				} ->	{$user_tablemappedonetomanyparameters.st}
								;

/* ------------------------------------------------------------------------------------- */
/* FTS - Full Text Search                                                                */
/* ------------------------------------------------------------------------------------- */
token_for_fts		:	a = STRING
						{
							if (string.IsNullOrEmpty(a.Text.Replace("\"", "").Trim()))
							{
								throw new ArgumentException("FullText Search value cannot be empty.");
							}

							a.Text = a.Text.Replace("'", "''");
							a.Text = a.Text.Replace("\"", "");

							if (a.Text.Length < 3)
							{
								throw new ArgumentException("FullText Search value is too short - Try using words longer than 3 characters.");
							}
						}													-> fts_val(val = {$a.Text});

/* ------------------------------------------------------------------------------------- */
/* Search and filtering parameters                                                       */
/* ------------------------------------------------------------------------------------- */
user_tablemappedonetomanyparameters:
				'gg' 
				{
					_paramExpr = "";
					_paramExpr += "gg";
				} -> user_type_gg()
;
user_userparameters:

;
user_longstringparameters:
				'super_power' 
				{
					_paramExpr = "";
					_paramExpr += "super_power";
				} -> user_type_super_power()
;
user_constonetomanyparameters:

;
user_textifyonetomanyparameters:

;
user_stringparameters:
				'name' 
				{
					_paramExpr = "";
					_paramExpr += "name";
				} -> user_type_name()
|
				'surname' 
				{
					_paramExpr = "";
					_paramExpr += "surname";
				} -> user_type_surname()
;
user_normaldateparameters:

;
user_boolparameters:

;
user_pastdateparameters:
				'birthdate' 
				{
					_paramExpr = "";
					_paramExpr += "birthdate";
				} -> user_type_birthdate()
;
user_mappedparameters:
				'country' 
				{
					_paramExpr = "";
					_paramExpr += "country";
				} -> user_type_country()
;
user_intparameters:
				'id' 
				{
					_paramExpr = "";
					_paramExpr += "id";
				} -> user_type_id()
;
user_manytomanyparameters:
				'email' 
				{
					_paramExpr = "";
					_paramExpr += "email";
				} -> user_type_email()
;


/* ------------------------------------------------------------------------------------- */
/* Columns clause                                                                        */
/* ------------------------------------------------------------------------------------- */
user_columnsvisible:
				'gg'
				{ 
					throw new ArgumentException("Column 'gg' is not implemented!");
				}																		-> user_column_gg()
|
				'super_power'					-> user_column_super_power()
|
				'name'					-> user_column_name()
|
				'surname'					-> user_column_surname()
|
				'birthdate'					-> user_column_birthdate()
|
				'country'					-> user_column_country()
|
				'id'					-> user_column_id()
|
				'email'
				{ 
					throw new ArgumentException("Column 'email' is not implemented!");
				}																		-> user_column_email()
;


columnsspec	:
				'user_columns' '(' u += user_columnsvisible (':' b += valInt)? (',' u += user_columnsvisible (':' b += valInt)? )* ')'
				{
					if (list_b != null)
					{
						// Add columns widths.
						_columnsWidths.Clear();
						_columnsWidths.AddRange(list_b);
					}

					if (list_u != null)
					{
						// Add columns names.
						_columnsNames.Clear();
						_columnsNames.AddRange(list_u);
					}
				}					-> columnsST(val = {$u})
			;

/* ------------------------------------------------------------------------------------- */
/* Sorting clause                                                                        */
/* ------------------------------------------------------------------------------------- */
user_sortingcolumns:
				'gg'				
				{ 
					throw new ArgumentException("Order by 'gg' is not implemented!");
				}																		-> user_sorting_column_gg()
|
				'super_power'				
				{
					SortingColumn = "super_power";
				}									-> user_sorting_column_super_power()
|
				'name'				
				{
					SortingColumn = "name";
				}									-> user_sorting_column_name()
|
				'surname'				
				{
					SortingColumn = "surname";
				}									-> user_sorting_column_surname()
|
				'birthdate'				
				{
					SortingColumn = "birthdate";
				}									-> user_sorting_column_birthdate()
|
				'country'				
				{
					SortingColumn = "country";
				}									-> user_sorting_column_country()
|
				'id'				
				{
					SortingColumn = "id";
				}									-> user_sorting_column_id()
|
				'email'				
				{ 
					throw new ArgumentException("Order by 'email' is not implemented!");
				}																		-> user_sorting_column_email()
;


sortingdir				:	'+'
							{
								SortingDirection =	"ascending";
							}						-> ascending()
						|	'-'
							{
								SortingDirection = "descending";
							}						-> descending()
						;

sortingspec :
				'user_sorted_by' ':' user_sortingcolumns sortingdir -> sortingST(col = {$user_sortingcolumns.st}, dir = {$sortingdir.st})
			;

/* ------------------------------------------------------------------------------------- */
/* Operators                                                                             */
/* ------------------------------------------------------------------------------------- */
internalLongStrOp		:	'='					-> like()
						|	'!='				-> notlike()
						;

internalopSpan			:	'='					-> between()
						|	'!='				-> notbetween()
						;

grOpSpan				:	'>'					-> greater()
						;

grOrEqOpSpan			:	'>='				-> greaterequal()
						;

lsOpSpan				:	'<'					-> less()
						;

lsOrEqOpSpan			:	'<='				-> lessequal()
						;

internalop				:	'='					-> equals()
						|	'>'					-> greater()
						|	'<'					-> less()
						|	'>='				-> greaterequal()
						|	'<='				-> lessequal()
						|	'!='				-> notequal()
						;

internalopN2M			:	'='					-> equals()
						|	'>'					-> greater()
						|	'<'					-> less()
						|	'>='				-> greaterequal()
						|	'<='				-> lessequal()
						;

internalopNotEqN2M		:	'!='				-> notequal()
						;

contains				:	'contains'			-> like()
						;

containsVal				:	a = STRING				
							{
								a.Text = a.Text.Replace("'", "''");
								a.Text = a.Text.Replace("\"", "");
							} -> contains_val(val = {$STRING.text})
							;

startsWith				:	'starts_with'		-> like()
						;

startsWithVal			:	a = STRING				
							{
								a.Text = a.Text.Replace("'", "''");
								a.Text = a.Text.Replace("\"", "");
							} -> starts_with_val(val = {$STRING.text})
						;

endsWith				:	'ends_with'			-> like()
						;

endsWithVal				:	a = STRING
							{
								a.Text = a.Text.Replace("'", "''");
								a.Text = a.Text.Replace("\"", "");
							} -> ends_with_val(val = {$STRING.text})
						;

doesNotContains			:	'does_not_contains'	-> notlike()
						;

doesNotContainsVal		:	a = STRING
							{
								a.Text = a.Text.Replace("'", "''");
								a.Text = a.Text.Replace("\"", "");
							} -> does_not_contains_val(val = {$STRING.text})
						;

multivalueinternalop	:	'in'				-> in()
						;

/* ------------------------------------------------------------------------------------- */
/* Boolean value                                                                         */
/* ------------------------------------------------------------------------------------- */
boolToken	:	'"true"'				-> true_bit()
			|	'"false"'				-> false_bit()
			|	'true'					-> true_bit()
			|	'false'					-> false_bit()
			;

/* ------------------------------------------------------------------------------------- */
/* Terminal tokens                                                                       */
/* ------------------------------------------------------------------------------------- */
INT			:	('0'..'9')+
			;

DATE		:	'0'..'9' '0'..'9' '0'..'9' '0'..'9' '-'	'0'..'9' '0'..'9' '-' '0'..'9' '0'..'9'		 					/*  yyyy-MM-dd  */
			;
			
STRING		:	STRCHAR ~(STRCHAR)* STRCHAR
			;	

STRCHAR		:	'\"'
			;

WS			:   (' ' | '\t' | '\r' | '\n')+
				{
					$channel=HIDDEN;
				}
			;