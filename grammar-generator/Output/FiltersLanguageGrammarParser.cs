// $ANTLR 3.1.3 Mar 17, 2009 19:23:44 Output\\FiltersLanguageGrammar.g 2012-08-14 22:45:36

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162


	using System.Collections.Generic;


using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;

using IDictionary	= System.Collections.IDictionary;
using Hashtable 	= System.Collections.Hashtable;
using Antlr.StringTemplate;
using Antlr.StringTemplate.Language;

namespace 
	FPDev2.Server.Filters.Grammar

{
public partial class FiltersLanguageGrammarParser : Parser
{
    public static readonly string[] tokenNames = new string[] 
	{
        "<invalid>", 
		"<EOR>", 
		"<DOWN>", 
		"<UP>", 
		"STRING", 
		"INT", 
		"DATE", 
		"STRCHAR", 
		"WS", 
		"'sql'", 
		"'('", 
		"')'", 
		"'__cntl'", 
		"'__cnt'", 
		"'or'", 
		"'and'", 
		"'not'", 
		"','", 
		"'wasever'", 
		"'\"now\"'", 
		"'now'", 
		"'today'", 
		"'\"today\"'", 
		"'yesterday'", 
		"'\"yesterday\"'", 
		"'tomorrow'", 
		"'\"tomorrow\"'", 
		"'lastweek'", 
		"'\"lastweek\"'", 
		"'lastmonth'", 
		"'\"lastmonth\"'", 
		"'thisweek'", 
		"'\"thisweek\"'", 
		"'thismonth'", 
		"'\"thismonth\"'", 
		"'\"me\"'", 
		"'me'", 
		"'user.'", 
		"'u.'", 
		"'gg'", 
		"'super_power'", 
		"'name'", 
		"'surname'", 
		"'birthdate'", 
		"'country'", 
		"'id'", 
		"'email'", 
		"'user_columns'", 
		"':'", 
		"'+'", 
		"'-'", 
		"'user_sorted_by'", 
		"'='", 
		"'!='", 
		"'>'", 
		"'>='", 
		"'<'", 
		"'<='", 
		"'contains'", 
		"'starts_with'", 
		"'ends_with'", 
		"'does_not_contains'", 
		"'in'", 
		"'\"true\"'", 
		"'\"false\"'", 
		"'true'", 
		"'false'"
    };

    public const int T__66 = 66;
    public const int T__64 = 64;
    public const int T__29 = 29;
    public const int T__65 = 65;
    public const int T__28 = 28;
    public const int T__62 = 62;
    public const int T__27 = 27;
    public const int T__63 = 63;
    public const int T__26 = 26;
    public const int T__25 = 25;
    public const int T__24 = 24;
    public const int T__23 = 23;
    public const int T__22 = 22;
    public const int T__21 = 21;
    public const int T__20 = 20;
    public const int T__61 = 61;
    public const int T__60 = 60;
    public const int EOF = -1;
    public const int T__9 = 9;
    public const int T__55 = 55;
    public const int T__56 = 56;
    public const int T__19 = 19;
    public const int T__57 = 57;
    public const int T__58 = 58;
    public const int T__51 = 51;
    public const int T__16 = 16;
    public const int T__52 = 52;
    public const int T__15 = 15;
    public const int T__53 = 53;
    public const int T__18 = 18;
    public const int T__54 = 54;
    public const int T__17 = 17;
    public const int T__12 = 12;
    public const int T__11 = 11;
    public const int T__14 = 14;
    public const int T__13 = 13;
    public const int T__59 = 59;
    public const int STRCHAR = 7;
    public const int T__10 = 10;
    public const int T__50 = 50;
    public const int T__42 = 42;
    public const int T__43 = 43;
    public const int T__40 = 40;
    public const int T__41 = 41;
    public const int T__46 = 46;
    public const int T__47 = 47;
    public const int T__44 = 44;
    public const int T__45 = 45;
    public const int T__48 = 48;
    public const int T__49 = 49;
    public const int INT = 5;
    public const int T__30 = 30;
    public const int T__31 = 31;
    public const int T__32 = 32;
    public const int WS = 8;
    public const int T__33 = 33;
    public const int T__34 = 34;
    public const int T__35 = 35;
    public const int T__36 = 36;
    public const int T__37 = 37;
    public const int T__38 = 38;
    public const int T__39 = 39;
    public const int DATE = 6;
    public const int STRING = 4;

    // delegates
    // delegators



        public FiltersLanguageGrammarParser(ITokenStream input)
    		: this(input, new RecognizerSharedState()) {
        }

        public FiltersLanguageGrammarParser(ITokenStream input, RecognizerSharedState state)
    		: base(input, state) {
            InitializeCyclicDFAs();

             
        }
        
    protected StringTemplateGroup templateLib =
      new StringTemplateGroup("FiltersLanguageGrammarParserTemplates", typeof(AngleBracketTemplateLexer));

    public StringTemplateGroup TemplateLib
    {
     	get { return this.templateLib; }
     	set { this.templateLib = value; }
    }

    /// <summary> Allows convenient multi-value initialization:
    ///  "new STAttrMap().Add(...).Add(...)"
    /// </summary>
    protected class STAttrMap : Hashtable
    {
      public STAttrMap Add(string attrName, object value) 
      {
        base.Add(attrName, value);
        return this;
      }
      public STAttrMap Add(string attrName, int value) 
      {
        base.Add(attrName, value);
        return this;
      }
    }

    override public string[] TokenNames {
		get { return FiltersLanguageGrammarParser.tokenNames; }
    }

    override public string GrammarFileName {
		get { return "Output\\FiltersLanguageGrammar.g"; }
    }


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


    public class main_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "main"
    // Output\\FiltersLanguageGrammar.g:472:1: main : expr EOF -> startSQL(expr=$expr.stpagenum=PageNum.ToString()pagesize=PageSize.ToString());
    public FiltersLanguageGrammarParser.main_return main() // throws RecognitionException [1]
    {   
        FiltersLanguageGrammarParser.main_return retval = new FiltersLanguageGrammarParser.main_return();
        retval.Start = input.LT(1);

        FiltersLanguageGrammarParser.expr_return expr1 = default(FiltersLanguageGrammarParser.expr_return);


        try 
    	{
            // Output\\FiltersLanguageGrammar.g:472:7: ( expr EOF -> startSQL(expr=$expr.stpagenum=PageNum.ToString()pagesize=PageSize.ToString()))
            // Output\\FiltersLanguageGrammar.g:472:9: expr EOF
            {
            	PushFollow(FOLLOW_expr_in_main77);
            	expr1 = expr();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	Match(input,EOF,FOLLOW_EOF_in_main79); if (state.failed) return retval;


            	// TEMPLATE REWRITE
            	if ( (state.backtracking==0) )
            	{
            	  // 472:25: -> startSQL(expr=$expr.stpagenum=PageNum.ToString()pagesize=PageSize.ToString())
            	  {
            	      retval.ST = templateLib.GetInstanceOf("startSQL",
            	    new STAttrMap().Add("expr", ((expr1 != null) ? expr1.ST : null)).Add("pagenum", PageNum.ToString()).Add("pagesize", PageSize.ToString()));
            	  }

            	}
            }

            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "main"

    public class expr_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "expr"
    // Output\\FiltersLanguageGrammar.g:474:1: expr : ( logicalexpr a= columnsspec b= sortingspec -> specified(val=$logicalexpr.stcol=$a.stsort=$b.stview=GlobalModuleLastView) | logicalexpr a= columnsspec -> specifiedColumns(val=$logicalexpr.stcol=$a.stview=GlobalModuleLastViewprimid=GlobalPrimaryID) | logicalexpr b= sortingspec -> specifiedSorting(val=$logicalexpr.stsort=$b.stview=GlobalModuleLastViewcols=GlobalColsDefault) | logicalexpr -> defaultSQL(val=$logicalexpr.stview=GlobalModuleLastViewcols=GlobalColsDefaultprimid=GlobalPrimaryID) | 'sql' '(' query ')' -> builtSQL(val=$query.st) | '__cntl' logicalexpr a= columnsspec b= sortingspec -> countspecified_library(val=$logicalexpr.stcol=$a.stsort=$b.stview=GlobalModuleLastView) | '__cntl' logicalexpr a= columnsspec -> countspecifiedColumns_library(val=$logicalexpr.stcol=$a.stview=GlobalModuleLastViewprimid=GlobalPrimaryID) | '__cntl' logicalexpr b= sortingspec -> countspecifiedSorting_library(val=$logicalexpr.stsort=$b.stview=GlobalModuleLastViewcols=GlobalColsDefault) | '__cntl' logicalexpr -> countdefaultSQL_library(val=$logicalexpr.stview=GlobalModuleLastViewcols=GlobalColsDefaultprimid=GlobalPrimaryID) | '__cntl' 'sql' '(' query ')' -> countbuiltSQL(val=$query.st) | '__cnt' logicalexpr a= columnsspec b= sortingspec -> countspecified(val=$logicalexpr.stcol=$a.stsort=$b.stview=GlobalModuleLastView) | '__cnt' logicalexpr a= columnsspec -> countspecifiedColumns(val=$logicalexpr.stcol=$a.stview=GlobalModuleLastViewprimid=GlobalPrimaryID) | '__cnt' logicalexpr b= sortingspec -> countspecifiedSorting(val=$logicalexpr.stsort=$b.stview=GlobalModuleLastViewcols=GlobalColsDefault) | '__cnt' logicalexpr -> countdefaultSQL(val=$logicalexpr.stview=GlobalModuleLastViewcols=GlobalColsDefaultprimid=GlobalPrimaryID) | '__cnt' 'sql' '(' query ')' -> countbuiltSQL(val=$query.st));
    public FiltersLanguageGrammarParser.expr_return expr() // throws RecognitionException [1]
    {   
        FiltersLanguageGrammarParser.expr_return retval = new FiltersLanguageGrammarParser.expr_return();
        retval.Start = input.LT(1);

        FiltersLanguageGrammarParser.columnsspec_return a = default(FiltersLanguageGrammarParser.columnsspec_return);

        FiltersLanguageGrammarParser.sortingspec_return b = default(FiltersLanguageGrammarParser.sortingspec_return);

        FiltersLanguageGrammarParser.logicalexpr_return logicalexpr2 = default(FiltersLanguageGrammarParser.logicalexpr_return);

        FiltersLanguageGrammarParser.logicalexpr_return logicalexpr3 = default(FiltersLanguageGrammarParser.logicalexpr_return);

        FiltersLanguageGrammarParser.logicalexpr_return logicalexpr4 = default(FiltersLanguageGrammarParser.logicalexpr_return);

        FiltersLanguageGrammarParser.logicalexpr_return logicalexpr5 = default(FiltersLanguageGrammarParser.logicalexpr_return);

        FiltersLanguageGrammarParser.query_return query6 = default(FiltersLanguageGrammarParser.query_return);

        FiltersLanguageGrammarParser.logicalexpr_return logicalexpr7 = default(FiltersLanguageGrammarParser.logicalexpr_return);

        FiltersLanguageGrammarParser.logicalexpr_return logicalexpr8 = default(FiltersLanguageGrammarParser.logicalexpr_return);

        FiltersLanguageGrammarParser.logicalexpr_return logicalexpr9 = default(FiltersLanguageGrammarParser.logicalexpr_return);

        FiltersLanguageGrammarParser.logicalexpr_return logicalexpr10 = default(FiltersLanguageGrammarParser.logicalexpr_return);

        FiltersLanguageGrammarParser.query_return query11 = default(FiltersLanguageGrammarParser.query_return);

        FiltersLanguageGrammarParser.logicalexpr_return logicalexpr12 = default(FiltersLanguageGrammarParser.logicalexpr_return);

        FiltersLanguageGrammarParser.logicalexpr_return logicalexpr13 = default(FiltersLanguageGrammarParser.logicalexpr_return);

        FiltersLanguageGrammarParser.logicalexpr_return logicalexpr14 = default(FiltersLanguageGrammarParser.logicalexpr_return);

        FiltersLanguageGrammarParser.logicalexpr_return logicalexpr15 = default(FiltersLanguageGrammarParser.logicalexpr_return);

        FiltersLanguageGrammarParser.query_return query16 = default(FiltersLanguageGrammarParser.query_return);


        try 
    	{
            // Output\\FiltersLanguageGrammar.g:474:7: ( logicalexpr a= columnsspec b= sortingspec -> specified(val=$logicalexpr.stcol=$a.stsort=$b.stview=GlobalModuleLastView) | logicalexpr a= columnsspec -> specifiedColumns(val=$logicalexpr.stcol=$a.stview=GlobalModuleLastViewprimid=GlobalPrimaryID) | logicalexpr b= sortingspec -> specifiedSorting(val=$logicalexpr.stsort=$b.stview=GlobalModuleLastViewcols=GlobalColsDefault) | logicalexpr -> defaultSQL(val=$logicalexpr.stview=GlobalModuleLastViewcols=GlobalColsDefaultprimid=GlobalPrimaryID) | 'sql' '(' query ')' -> builtSQL(val=$query.st) | '__cntl' logicalexpr a= columnsspec b= sortingspec -> countspecified_library(val=$logicalexpr.stcol=$a.stsort=$b.stview=GlobalModuleLastView) | '__cntl' logicalexpr a= columnsspec -> countspecifiedColumns_library(val=$logicalexpr.stcol=$a.stview=GlobalModuleLastViewprimid=GlobalPrimaryID) | '__cntl' logicalexpr b= sortingspec -> countspecifiedSorting_library(val=$logicalexpr.stsort=$b.stview=GlobalModuleLastViewcols=GlobalColsDefault) | '__cntl' logicalexpr -> countdefaultSQL_library(val=$logicalexpr.stview=GlobalModuleLastViewcols=GlobalColsDefaultprimid=GlobalPrimaryID) | '__cntl' 'sql' '(' query ')' -> countbuiltSQL(val=$query.st) | '__cnt' logicalexpr a= columnsspec b= sortingspec -> countspecified(val=$logicalexpr.stcol=$a.stsort=$b.stview=GlobalModuleLastView) | '__cnt' logicalexpr a= columnsspec -> countspecifiedColumns(val=$logicalexpr.stcol=$a.stview=GlobalModuleLastViewprimid=GlobalPrimaryID) | '__cnt' logicalexpr b= sortingspec -> countspecifiedSorting(val=$logicalexpr.stsort=$b.stview=GlobalModuleLastViewcols=GlobalColsDefault) | '__cnt' logicalexpr -> countdefaultSQL(val=$logicalexpr.stview=GlobalModuleLastViewcols=GlobalColsDefaultprimid=GlobalPrimaryID) | '__cnt' 'sql' '(' query ')' -> countbuiltSQL(val=$query.st))
            int alt1 = 15;
            alt1 = dfa1.Predict(input);
            switch (alt1) 
            {
                case 1 :
                    // Output\\FiltersLanguageGrammar.g:474:9: logicalexpr a= columnsspec b= sortingspec
                    {
                    	PushFollow(FOLLOW_logicalexpr_in_expr114);
                    	logicalexpr2 = logicalexpr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	PushFollow(FOLLOW_columnsspec_in_expr120);
                    	a = columnsspec();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	PushFollow(FOLLOW_sortingspec_in_expr126);
                    	b = sortingspec();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  					GlobalModuleLastView 	= ExtractModule(FilterText, _dictLastViews);
                    	  					GlobalModulePrefix 		= ExtractModule(FilterText, _dictNames);
                    	  				
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 478:7: -> specified(val=$logicalexpr.stcol=$a.stsort=$b.stview=GlobalModuleLastView)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("specified",
                    	    new STAttrMap().Add("val", ((logicalexpr2 != null) ? logicalexpr2.ST : null)).Add("col", ((a != null) ? a.ST : null)).Add("sort", ((b != null) ? b.ST : null)).Add("view", GlobalModuleLastView));
                    	  }

                    	}
                    }
                    break;
                case 2 :
                    // Output\\FiltersLanguageGrammar.g:479:6: logicalexpr a= columnsspec
                    {
                    	PushFollow(FOLLOW_logicalexpr_in_expr171);
                    	logicalexpr3 = logicalexpr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	PushFollow(FOLLOW_columnsspec_in_expr177);
                    	a = columnsspec();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  					GlobalModuleLastView 	= ExtractModule(FilterText, _dictLastViews);
                    	  					GlobalPrimaryID 		= ExtractModule(FilterText, _dictPrimID);
                    	  					GlobalModulePrefix 		= ExtractModule(FilterText, _dictNames);
                    	  				
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 484:7: -> specifiedColumns(val=$logicalexpr.stcol=$a.stview=GlobalModuleLastViewprimid=GlobalPrimaryID)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("specifiedColumns",
                    	    new STAttrMap().Add("val", ((logicalexpr3 != null) ? logicalexpr3.ST : null)).Add("col", ((a != null) ? a.ST : null)).Add("view", GlobalModuleLastView).Add("primid", GlobalPrimaryID));
                    	  }

                    	}
                    }
                    break;
                case 3 :
                    // Output\\FiltersLanguageGrammar.g:485:6: logicalexpr b= sortingspec
                    {
                    	PushFollow(FOLLOW_logicalexpr_in_expr222);
                    	logicalexpr4 = logicalexpr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	PushFollow(FOLLOW_sortingspec_in_expr228);
                    	b = sortingspec();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  					GlobalModuleLastView 	= ExtractModule(FilterText, _dictLastViews);
                    	  					GlobalColsDefault		= ExtractModule(FilterText, _dictCols);
                    	  					GlobalModulePrefix 		= ExtractModule(FilterText, _dictNames);
                    	  				
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 490:7: -> specifiedSorting(val=$logicalexpr.stsort=$b.stview=GlobalModuleLastViewcols=GlobalColsDefault)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("specifiedSorting",
                    	    new STAttrMap().Add("val", ((logicalexpr4 != null) ? logicalexpr4.ST : null)).Add("sort", ((b != null) ? b.ST : null)).Add("view", GlobalModuleLastView).Add("cols", GlobalColsDefault));
                    	  }

                    	}
                    }
                    break;
                case 4 :
                    // Output\\FiltersLanguageGrammar.g:491:6: logicalexpr
                    {
                    	PushFollow(FOLLOW_logicalexpr_in_expr273);
                    	logicalexpr5 = logicalexpr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  					GlobalModuleLastView 	= ExtractModule(FilterText, _dictLastViews);
                    	  					GlobalPrimaryID 		= ExtractModule(FilterText, _dictPrimID);
                    	  					GlobalColsDefault		= ExtractModule(FilterText, _dictCols);
                    	  				
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 496:7: -> defaultSQL(val=$logicalexpr.stview=GlobalModuleLastViewcols=GlobalColsDefaultprimid=GlobalPrimaryID)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("defaultSQL",
                    	    new STAttrMap().Add("val", ((logicalexpr5 != null) ? logicalexpr5.ST : null)).Add("view", GlobalModuleLastView).Add("cols", GlobalColsDefault).Add("primid", GlobalPrimaryID));
                    	  }

                    	}
                    }
                    break;
                case 5 :
                    // Output\\FiltersLanguageGrammar.g:497:6: 'sql' '(' query ')'
                    {
                    	Match(input,9,FOLLOW_9_in_expr318); if (state.failed) return retval;
                    	Match(input,10,FOLLOW_10_in_expr320); if (state.failed) return retval;
                    	PushFollow(FOLLOW_query_in_expr322);
                    	query6 = query();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	Match(input,11,FOLLOW_11_in_expr324); if (state.failed) return retval;


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 497:26: -> builtSQL(val=$query.st)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("builtSQL",
                    	    new STAttrMap().Add("val", ((query6 != null) ? query6.ST : null)));
                    	  }

                    	}
                    }
                    break;
                case 6 :
                    // Output\\FiltersLanguageGrammar.g:498:6: '__cntl' logicalexpr a= columnsspec b= sortingspec
                    {
                    	Match(input,12,FOLLOW_12_in_expr342); if (state.failed) return retval;
                    	PushFollow(FOLLOW_logicalexpr_in_expr344);
                    	logicalexpr7 = logicalexpr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	PushFollow(FOLLOW_columnsspec_in_expr350);
                    	a = columnsspec();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	PushFollow(FOLLOW_sortingspec_in_expr356);
                    	b = sortingspec();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  					GlobalModuleLastView 	= ExtractModule(FilterText, _dictLastViews);
                    	  					GlobalModulePrefix 		= ExtractModule(FilterText, _dictNames);
                    	  				
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 502:7: -> countspecified_library(val=$logicalexpr.stcol=$a.stsort=$b.stview=GlobalModuleLastView)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("countspecified_library",
                    	    new STAttrMap().Add("val", ((logicalexpr7 != null) ? logicalexpr7.ST : null)).Add("col", ((a != null) ? a.ST : null)).Add("sort", ((b != null) ? b.ST : null)).Add("view", GlobalModuleLastView));
                    	  }

                    	}
                    }
                    break;
                case 7 :
                    // Output\\FiltersLanguageGrammar.g:503:6: '__cntl' logicalexpr a= columnsspec
                    {
                    	Match(input,12,FOLLOW_12_in_expr401); if (state.failed) return retval;
                    	PushFollow(FOLLOW_logicalexpr_in_expr403);
                    	logicalexpr8 = logicalexpr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	PushFollow(FOLLOW_columnsspec_in_expr409);
                    	a = columnsspec();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  					GlobalModuleLastView 	= ExtractModule(FilterText, _dictLastViews);
                    	  					GlobalPrimaryID 		= ExtractModule(FilterText, _dictPrimID);
                    	  					GlobalModulePrefix 		= ExtractModule(FilterText, _dictNames);
                    	  				
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 508:7: -> countspecifiedColumns_library(val=$logicalexpr.stcol=$a.stview=GlobalModuleLastViewprimid=GlobalPrimaryID)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("countspecifiedColumns_library",
                    	    new STAttrMap().Add("val", ((logicalexpr8 != null) ? logicalexpr8.ST : null)).Add("col", ((a != null) ? a.ST : null)).Add("view", GlobalModuleLastView).Add("primid", GlobalPrimaryID));
                    	  }

                    	}
                    }
                    break;
                case 8 :
                    // Output\\FiltersLanguageGrammar.g:509:6: '__cntl' logicalexpr b= sortingspec
                    {
                    	Match(input,12,FOLLOW_12_in_expr454); if (state.failed) return retval;
                    	PushFollow(FOLLOW_logicalexpr_in_expr456);
                    	logicalexpr9 = logicalexpr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	PushFollow(FOLLOW_sortingspec_in_expr462);
                    	b = sortingspec();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  					GlobalModuleLastView 	= ExtractModule(FilterText, _dictLastViews);
                    	  					GlobalColsDefault		= ExtractModule(FilterText, _dictCols);
                    	  					GlobalModulePrefix 		= ExtractModule(FilterText, _dictNames);
                    	  				
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 514:7: -> countspecifiedSorting_library(val=$logicalexpr.stsort=$b.stview=GlobalModuleLastViewcols=GlobalColsDefault)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("countspecifiedSorting_library",
                    	    new STAttrMap().Add("val", ((logicalexpr9 != null) ? logicalexpr9.ST : null)).Add("sort", ((b != null) ? b.ST : null)).Add("view", GlobalModuleLastView).Add("cols", GlobalColsDefault));
                    	  }

                    	}
                    }
                    break;
                case 9 :
                    // Output\\FiltersLanguageGrammar.g:515:6: '__cntl' logicalexpr
                    {
                    	Match(input,12,FOLLOW_12_in_expr507); if (state.failed) return retval;
                    	PushFollow(FOLLOW_logicalexpr_in_expr509);
                    	logicalexpr10 = logicalexpr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  					GlobalModuleLastView 	= ExtractModule(FilterText, _dictLastViews);
                    	  					GlobalPrimaryID 		= ExtractModule(FilterText, _dictPrimID);
                    	  					GlobalColsDefault		= ExtractModule(FilterText, _dictCols);
                    	  				
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 520:7: -> countdefaultSQL_library(val=$logicalexpr.stview=GlobalModuleLastViewcols=GlobalColsDefaultprimid=GlobalPrimaryID)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("countdefaultSQL_library",
                    	    new STAttrMap().Add("val", ((logicalexpr10 != null) ? logicalexpr10.ST : null)).Add("view", GlobalModuleLastView).Add("cols", GlobalColsDefault).Add("primid", GlobalPrimaryID));
                    	  }

                    	}
                    }
                    break;
                case 10 :
                    // Output\\FiltersLanguageGrammar.g:521:6: '__cntl' 'sql' '(' query ')'
                    {
                    	Match(input,12,FOLLOW_12_in_expr554); if (state.failed) return retval;
                    	Match(input,9,FOLLOW_9_in_expr556); if (state.failed) return retval;
                    	Match(input,10,FOLLOW_10_in_expr558); if (state.failed) return retval;
                    	PushFollow(FOLLOW_query_in_expr560);
                    	query11 = query();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	Match(input,11,FOLLOW_11_in_expr562); if (state.failed) return retval;


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 521:39: -> countbuiltSQL(val=$query.st)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("countbuiltSQL",
                    	    new STAttrMap().Add("val", ((query11 != null) ? query11.ST : null)));
                    	  }

                    	}
                    }
                    break;
                case 11 :
                    // Output\\FiltersLanguageGrammar.g:522:6: '__cnt' logicalexpr a= columnsspec b= sortingspec
                    {
                    	Match(input,13,FOLLOW_13_in_expr584); if (state.failed) return retval;
                    	PushFollow(FOLLOW_logicalexpr_in_expr586);
                    	logicalexpr12 = logicalexpr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	PushFollow(FOLLOW_columnsspec_in_expr592);
                    	a = columnsspec();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	PushFollow(FOLLOW_sortingspec_in_expr598);
                    	b = sortingspec();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  					GlobalModuleLastView 	= ExtractModule(FilterText, _dictLastViews);
                    	  					GlobalModulePrefix 		= ExtractModule(FilterText, _dictNames);
                    	  				
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 526:7: -> countspecified(val=$logicalexpr.stcol=$a.stsort=$b.stview=GlobalModuleLastView)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("countspecified",
                    	    new STAttrMap().Add("val", ((logicalexpr12 != null) ? logicalexpr12.ST : null)).Add("col", ((a != null) ? a.ST : null)).Add("sort", ((b != null) ? b.ST : null)).Add("view", GlobalModuleLastView));
                    	  }

                    	}
                    }
                    break;
                case 12 :
                    // Output\\FiltersLanguageGrammar.g:527:6: '__cnt' logicalexpr a= columnsspec
                    {
                    	Match(input,13,FOLLOW_13_in_expr643); if (state.failed) return retval;
                    	PushFollow(FOLLOW_logicalexpr_in_expr645);
                    	logicalexpr13 = logicalexpr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	PushFollow(FOLLOW_columnsspec_in_expr651);
                    	a = columnsspec();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  					GlobalModuleLastView 	= ExtractModule(FilterText, _dictLastViews);
                    	  					GlobalPrimaryID 		= ExtractModule(FilterText, _dictPrimID);
                    	  					GlobalModulePrefix 		= ExtractModule(FilterText, _dictNames);
                    	  				
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 532:7: -> countspecifiedColumns(val=$logicalexpr.stcol=$a.stview=GlobalModuleLastViewprimid=GlobalPrimaryID)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("countspecifiedColumns",
                    	    new STAttrMap().Add("val", ((logicalexpr13 != null) ? logicalexpr13.ST : null)).Add("col", ((a != null) ? a.ST : null)).Add("view", GlobalModuleLastView).Add("primid", GlobalPrimaryID));
                    	  }

                    	}
                    }
                    break;
                case 13 :
                    // Output\\FiltersLanguageGrammar.g:533:6: '__cnt' logicalexpr b= sortingspec
                    {
                    	Match(input,13,FOLLOW_13_in_expr696); if (state.failed) return retval;
                    	PushFollow(FOLLOW_logicalexpr_in_expr698);
                    	logicalexpr14 = logicalexpr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	PushFollow(FOLLOW_sortingspec_in_expr704);
                    	b = sortingspec();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  					GlobalModuleLastView 	= ExtractModule(FilterText, _dictLastViews);
                    	  					GlobalColsDefault		= ExtractModule(FilterText, _dictCols);
                    	  					GlobalModulePrefix 		= ExtractModule(FilterText, _dictNames);
                    	  				
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 538:7: -> countspecifiedSorting(val=$logicalexpr.stsort=$b.stview=GlobalModuleLastViewcols=GlobalColsDefault)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("countspecifiedSorting",
                    	    new STAttrMap().Add("val", ((logicalexpr14 != null) ? logicalexpr14.ST : null)).Add("sort", ((b != null) ? b.ST : null)).Add("view", GlobalModuleLastView).Add("cols", GlobalColsDefault));
                    	  }

                    	}
                    }
                    break;
                case 14 :
                    // Output\\FiltersLanguageGrammar.g:539:6: '__cnt' logicalexpr
                    {
                    	Match(input,13,FOLLOW_13_in_expr749); if (state.failed) return retval;
                    	PushFollow(FOLLOW_logicalexpr_in_expr751);
                    	logicalexpr15 = logicalexpr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  					GlobalModuleLastView 	= ExtractModule(FilterText, _dictLastViews);
                    	  					GlobalPrimaryID 		= ExtractModule(FilterText, _dictPrimID);
                    	  					GlobalColsDefault		= ExtractModule(FilterText, _dictCols);
                    	  				
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 544:7: -> countdefaultSQL(val=$logicalexpr.stview=GlobalModuleLastViewcols=GlobalColsDefaultprimid=GlobalPrimaryID)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("countdefaultSQL",
                    	    new STAttrMap().Add("val", ((logicalexpr15 != null) ? logicalexpr15.ST : null)).Add("view", GlobalModuleLastView).Add("cols", GlobalColsDefault).Add("primid", GlobalPrimaryID));
                    	  }

                    	}
                    }
                    break;
                case 15 :
                    // Output\\FiltersLanguageGrammar.g:545:6: '__cnt' 'sql' '(' query ')'
                    {
                    	Match(input,13,FOLLOW_13_in_expr796); if (state.failed) return retval;
                    	Match(input,9,FOLLOW_9_in_expr798); if (state.failed) return retval;
                    	Match(input,10,FOLLOW_10_in_expr800); if (state.failed) return retval;
                    	PushFollow(FOLLOW_query_in_expr802);
                    	query16 = query();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	Match(input,11,FOLLOW_11_in_expr804); if (state.failed) return retval;


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 545:38: -> countbuiltSQL(val=$query.st)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("countbuiltSQL",
                    	    new STAttrMap().Add("val", ((query16 != null) ? query16.ST : null)));
                    	  }

                    	}
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "expr"

    public class logicalexpr_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "logicalexpr"
    // Output\\FiltersLanguageGrammar.g:548:1: logicalexpr : (a= andatom -> {$a.st}) ( 'or' b= andatom -> or(left=$logicalexpr.stright=$b.st))* ;
    public FiltersLanguageGrammarParser.logicalexpr_return logicalexpr() // throws RecognitionException [1]
    {   
        FiltersLanguageGrammarParser.logicalexpr_return retval = new FiltersLanguageGrammarParser.logicalexpr_return();
        retval.Start = input.LT(1);

        FiltersLanguageGrammarParser.andatom_return a = default(FiltersLanguageGrammarParser.andatom_return);

        FiltersLanguageGrammarParser.andatom_return b = default(FiltersLanguageGrammarParser.andatom_return);


        try 
    	{
            // Output\\FiltersLanguageGrammar.g:548:13: ( (a= andatom -> {$a.st}) ( 'or' b= andatom -> or(left=$logicalexpr.stright=$b.st))* )
            // Output\\FiltersLanguageGrammar.g:548:17: (a= andatom -> {$a.st}) ( 'or' b= andatom -> or(left=$logicalexpr.stright=$b.st))*
            {
            	// Output\\FiltersLanguageGrammar.g:548:17: (a= andatom -> {$a.st})
            	// Output\\FiltersLanguageGrammar.g:548:19: a= andatom
            	{
            		PushFollow(FOLLOW_andatom_in_logicalexpr839);
            		a = andatom();
            		state.followingStackPointer--;
            		if (state.failed) return retval;


            		// TEMPLATE REWRITE
            		if ( (state.backtracking==0) )
            		{
            		  // 548:34: -> {$a.st}
            		  {
            		      retval.ST = ((a != null) ? a.ST : null);
            		  }

            		}
            	}

            	// Output\\FiltersLanguageGrammar.g:549:5: ( 'or' b= andatom -> or(left=$logicalexpr.stright=$b.st))*
            	do 
            	{
            	    int alt2 = 2;
            	    int LA2_0 = input.LA(1);

            	    if ( (LA2_0 == 14) )
            	    {
            	        alt2 = 1;
            	    }


            	    switch (alt2) 
            		{
            			case 1 :
            			    // Output\\FiltersLanguageGrammar.g:549:6: 'or' b= andatom
            			    {
            			    	Match(input,14,FOLLOW_14_in_logicalexpr855); if (state.failed) return retval;
            			    	PushFollow(FOLLOW_andatom_in_logicalexpr861);
            			    	b = andatom();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;


            			    	// TEMPLATE REWRITE
            			    	if ( (state.backtracking==0) )
            			    	{
            			    	  // 549:25: -> or(left=$logicalexpr.stright=$b.st)
            			    	  {
            			    	      retval.ST = templateLib.GetInstanceOf("or",
            			    	    new STAttrMap().Add("left", retval.ST).Add("right", ((b != null) ? b.ST : null)));
            			    	  }

            			    	}
            			    }
            			    break;

            			default:
            			    goto loop2;
            	    }
            	} while (true);

            	loop2:
            		;	// Stops C# compiler whining that label 'loop2' has no statements


            }

            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "logicalexpr"

    public class andatom_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "andatom"
    // Output\\FiltersLanguageGrammar.g:552:1: andatom : (a= notexpr -> {$a.st}) ( 'and' b= notexpr -> and(left=$andatom.stright=$b.st))* ;
    public FiltersLanguageGrammarParser.andatom_return andatom() // throws RecognitionException [1]
    {   
        FiltersLanguageGrammarParser.andatom_return retval = new FiltersLanguageGrammarParser.andatom_return();
        retval.Start = input.LT(1);

        FiltersLanguageGrammarParser.notexpr_return a = default(FiltersLanguageGrammarParser.notexpr_return);

        FiltersLanguageGrammarParser.notexpr_return b = default(FiltersLanguageGrammarParser.notexpr_return);


        try 
    	{
            // Output\\FiltersLanguageGrammar.g:552:10: ( (a= notexpr -> {$a.st}) ( 'and' b= notexpr -> and(left=$andatom.stright=$b.st))* )
            // Output\\FiltersLanguageGrammar.g:552:12: (a= notexpr -> {$a.st}) ( 'and' b= notexpr -> and(left=$andatom.stright=$b.st))*
            {
            	// Output\\FiltersLanguageGrammar.g:552:12: (a= notexpr -> {$a.st})
            	// Output\\FiltersLanguageGrammar.g:552:14: a= notexpr
            	{
            		PushFollow(FOLLOW_notexpr_in_andatom899);
            		a = notexpr();
            		state.followingStackPointer--;
            		if (state.failed) return retval;


            		// TEMPLATE REWRITE
            		if ( (state.backtracking==0) )
            		{
            		  // 552:29: -> {$a.st}
            		  {
            		      retval.ST = ((a != null) ? a.ST : null);
            		  }

            		}
            	}

            	// Output\\FiltersLanguageGrammar.g:553:5: ( 'and' b= notexpr -> and(left=$andatom.stright=$b.st))*
            	do 
            	{
            	    int alt3 = 2;
            	    int LA3_0 = input.LA(1);

            	    if ( (LA3_0 == 15) )
            	    {
            	        alt3 = 1;
            	    }


            	    switch (alt3) 
            		{
            			case 1 :
            			    // Output\\FiltersLanguageGrammar.g:553:6: 'and' b= notexpr
            			    {
            			    	Match(input,15,FOLLOW_15_in_andatom915); if (state.failed) return retval;
            			    	PushFollow(FOLLOW_notexpr_in_andatom921);
            			    	b = notexpr();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;


            			    	// TEMPLATE REWRITE
            			    	if ( (state.backtracking==0) )
            			    	{
            			    	  // 553:26: -> and(left=$andatom.stright=$b.st)
            			    	  {
            			    	      retval.ST = templateLib.GetInstanceOf("and",
            			    	    new STAttrMap().Add("left", retval.ST).Add("right", ((b != null) ? b.ST : null)));
            			    	  }

            			    	}
            			    }
            			    break;

            			default:
            			    goto loop3;
            	    }
            	} while (true);

            	loop3:
            		;	// Stops C# compiler whining that label 'loop3' has no statements


            }

            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "andatom"

    public class notexpr_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "notexpr"
    // Output\\FiltersLanguageGrammar.g:556:1: notexpr : ( 'not' a= paramexpr -> not(left=$paramexpr.st) | paramexpr -> {$paramexpr.st});
    public FiltersLanguageGrammarParser.notexpr_return notexpr() // throws RecognitionException [1]
    {   
        FiltersLanguageGrammarParser.notexpr_return retval = new FiltersLanguageGrammarParser.notexpr_return();
        retval.Start = input.LT(1);

        FiltersLanguageGrammarParser.paramexpr_return a = default(FiltersLanguageGrammarParser.paramexpr_return);

        FiltersLanguageGrammarParser.paramexpr_return paramexpr17 = default(FiltersLanguageGrammarParser.paramexpr_return);


        try 
    	{
            // Output\\FiltersLanguageGrammar.g:556:10: ( 'not' a= paramexpr -> not(left=$paramexpr.st) | paramexpr -> {$paramexpr.st})
            int alt4 = 2;
            int LA4_0 = input.LA(1);

            if ( (LA4_0 == 16) )
            {
                alt4 = 1;
            }
            else if ( (LA4_0 == STRING || LA4_0 == 10 || (LA4_0 >= 37 && LA4_0 <= 38)) )
            {
                alt4 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d4s0 =
                    new NoViableAltException("", 4, 0, input);

                throw nvae_d4s0;
            }
            switch (alt4) 
            {
                case 1 :
                    // Output\\FiltersLanguageGrammar.g:556:12: 'not' a= paramexpr
                    {
                    	Match(input,16,FOLLOW_16_in_notexpr953); if (state.failed) return retval;
                    	PushFollow(FOLLOW_paramexpr_in_notexpr959);
                    	a = paramexpr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 556:33: -> not(left=$paramexpr.st)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("not",
                    	    new STAttrMap().Add("left", ((a != null) ? a.ST : null)));
                    	  }

                    	}
                    }
                    break;
                case 2 :
                    // Output\\FiltersLanguageGrammar.g:557:7: paramexpr
                    {
                    	PushFollow(FOLLOW_paramexpr_in_notexpr977);
                    	paramexpr17 = paramexpr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 557:20: -> {$paramexpr.st}
                    	  {
                    	      retval.ST = ((paramexpr17 != null) ? paramexpr17.ST : null);
                    	  }

                    	}
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "notexpr"

    public class paramexpr_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "paramexpr"
    // Output\\FiltersLanguageGrammar.g:560:1: paramexpr : ( '(' logicalexpr ')' -> parenthesis(val=$logicalexpr.st) | token_for_fts -> fts_param(val=$token_for_fts.stmaintable=GlobalMainTableprimid=GlobalPrimaryIDftsid=GlobalFtsID) | parametersStr internalop valStr -> parameter(p=$parametersStr.sto=$internalop.stv=$valStr.st) | paramLongStr internalLongStrOp valLongStr -> parameter(p=$paramLongStr.sto=$internalLongStrOp.stv=$valLongStr.st) | parametersStr contains containsVal -> parameter(p=$parametersStr.sto=$contains.stv=$containsVal.st) | paramLongStr contains containsVal -> parameter(p=$paramLongStr.sto=$contains.stv=$containsVal.st) | parametersUser contains containsVal -> parameter(p=$parametersUser.sto=$contains.stv=$containsVal.st) | parametersStr doesNotContains doesNotContainsVal -> parameter(p=$parametersStr.sto=$doesNotContains.stv=$doesNotContainsVal.st) | paramLongStr doesNotContains doesNotContainsVal -> parameter(p=$paramLongStr.sto=$doesNotContains.stv=$doesNotContainsVal.st) | parametersUser doesNotContains doesNotContainsVal -> parameter(p=$parametersUser.sto=$doesNotContains.stv=$doesNotContainsVal.st) | parametersStr startsWith startsWithVal -> parameter(p=$parametersStr.sto=$startsWith.stv=$startsWithVal.st) | paramLongStr startsWith startsWithVal -> parameter(p=$paramLongStr.sto=$startsWith.stv=$startsWithVal.st) | parametersUser startsWith startsWithVal -> parameter(p=$parametersUser.sto=$startsWith.stv=$startsWithVal.st) | parametersStr endsWith endsWithVal -> parameter(p=$parametersStr.sto=$endsWith.stv=$endsWithVal.st) | paramLongStr endsWith endsWithVal -> parameter(p=$paramLongStr.sto=$endsWith.stv=$endsWithVal.st) | parametersUser endsWith endsWithVal -> parameter(p=$parametersUser.sto=$endsWith.stv=$endsWithVal.st) | parametersInt internalop valInt -> parameter(p=$parametersInt.sto=$internalop.stv=$valInt.st) | parametersDate internalop valDate -> parameter(p=$parametersDate.sto=$internalop.stv=$valDate.st) | parametersDate internalopSpan valDateSpan -> parameter(p=$parametersDate.sto=$internalopSpan.stv=$valDateSpan.st) | parametersDate lsOpSpan valDateSpanLs -> parameter(p=$parametersDate.sto=$lsOpSpan.stv=$valDateSpanLs.st) | parametersDate grOpSpan valDateSpanGr -> parameter(p=$parametersDate.sto=$grOpSpan.stv=$valDateSpanGr.st) | parametersDate lsOrEqOpSpan valDateSpanLsOrEq -> parameter(p=$parametersDate.sto=$lsOrEqOpSpan.stv=$valDateSpanLsOrEq.st) | parametersDate grOrEqOpSpan valDateSpanGrOrEq -> parameter(p=$parametersDate.sto=$grOrEqOpSpan.stv=$valDateSpanGrOrEq.st) | parametersUser internalop valUser -> parameter(p=$parametersUser.sto=$internalop.stv=$valUser.st) | parametersBool internalop valBool -> parameter(p=$parametersBool.sto=$internalop.stv=$valBool.st) | parametersMapped internalop valStr -> parameter(p=$parametersMapped.sto=$internalop.stv=$valStr.st) | parametersStr multivalueinternalop '(' a+= valStr ( ',' a+= valStr )* ')' -> multiparameter(p=$parametersStr.sto=$multivalueinternalop.stv=$a) | parametersInt multivalueinternalop '(' b+= valInt ( ',' b+= valInt )* ')' -> multiparameter(p=$parametersInt.sto=$multivalueinternalop.stv=$b) | parametersDate multivalueinternalop '(' c+= valDate ( ',' c+= valDate )* ')' -> multiparameter(p=$parametersDate.sto=$multivalueinternalop.stv=$c) | parametersUser multivalueinternalop '(' d+= valUser ( ',' d+= valUser )* ')' -> multiparameter(p=$parametersUser.sto=$multivalueinternalop.stv=$d) | paramLongStr multivalueinternalop '(' longS+= valStr ( ',' longS+= valStr )* ')' -> multiparameter(p=$paramLongStr.sto=$multivalueinternalop.stv=$longS) | parametersMapped multivalueinternalop '(' mapped+= valStr ( ',' mapped+= valStr )* ')' -> multiparameter(p=$parametersMapped.sto=$multivalueinternalop.stv=$mapped) | parametersStr 'wasever' '(' a+= valStr ( ',' a+= valStr )* ')' -> wasever(col=$parametersStr.stval=$aview=GlobalModuleEverViewprimid=GlobalPrimaryID) | parametersInt 'wasever' '(' b+= valInt ( ',' b+= valInt )* ')' -> wasever(col=$parametersInt.stval=$bview=GlobalModuleEverViewprimid=GlobalPrimaryID) | parametersDate 'wasever' '(' c+= valDate ( ',' c+= valDate )* ')' -> wasever(col=$parametersDate.stval=$cview=GlobalModuleEverViewprimid=GlobalPrimaryID) | parametersUser 'wasever' '(' d+= valUser ( ',' d+= valUser )* ')' -> wasever(col=$parametersUser.stval=$dview=GlobalModuleEverViewprimid=GlobalPrimaryID) | parametersBool 'wasever' '(' e+= valBool ( ',' e+= valBool )* ')' -> wasever(col=$parametersBool.stval=$eview=GlobalModuleEverViewprimid=GlobalPrimaryID) | parametersDate 'wasever' '(' f+= valDateSpan ( ',' f+= valDateSpan )* ')' -> wasever(col=$parametersDate.stval=$fview=GlobalModuleEverViewprimid=GlobalPrimaryID) | paramLongStr 'wasever' '(' longS+= valStr ( ',' longS+= valStr )* ')' -> wasever(col=$paramLongStr.stval=$longSview=GlobalModuleEverViewprimid=GlobalPrimaryID) | parametersMapped 'wasever' '(' mapped+= valStr ( ',' mapped+= valStr )* ')' -> wasever(col=$parametersMapped.stval=$mappedview=GlobalModuleEverViewprimid=GlobalPrimaryID) | parametersManyToMany internalopN2M valStr -> many_to_many(val=$valStr.stop=$internalopN2M.stmaintable=_globalMainTableList[_n2mCount - 1]primid=_globalPrimaryIDList[_n2mCount - 1]n2mtable=_globalN2MTableList[_n2mCount - 1]replyid=_globalN2MReplyIDList[_n2mCount - 1]objtable=_globalN2MObjTableList[_n2mCount - 1]n2mobjid=_globalN2MObjIDList[_n2mCount - 1]valname=$parametersManyToMany.stisdeletedrestriction=_globalN2MIsDeletedRestriction[_n2mCount - 1]) | parametersManyToMany internalopNotEqN2M valStr -> many_to_many_not(val=$valStr.stmaintable=_globalMainTableList[_n2mCount - 1]primid=_globalPrimaryIDList[_n2mCount - 1]n2mtable=_globalN2MTableList[_n2mCount - 1]replyid=_globalN2MReplyIDList[_n2mCount - 1]objtable=_globalN2MObjTableList[_n2mCount - 1]n2mobjid=_globalN2MObjIDList[_n2mCount - 1]valname=$parametersManyToMany.stisdeletedrestriction=_globalN2MIsDeletedRestriction[_n2mCount - 1]) | parametersManyToMany multivalueinternalop '(' g+= valStr ( ',' g+= valStr )* ')' -> many_to_many_multi(val=$gop=$multivalueinternalop.stmaintable=_globalMainTableList[_n2mCount - 1]primid=_globalPrimaryIDList[_n2mCount - 1]n2mtable=_globalN2MTableList[_n2mCount - 1]replyid=_globalN2MReplyIDList[_n2mCount - 1]objtable=_globalN2MObjTableList[_n2mCount - 1]n2mobjid=_globalN2MObjIDList[_n2mCount - 1]valname=$parametersManyToMany.stisdeletedrestriction=_globalN2MIsDeletedRestriction[_n2mCount - 1]) | parametersManyToMany 'wasever' '(' h+= valStr ( ',' h+= valStr )* ')' -> many_to_many_wasever(val=$hmaintable=_globalMainTableList[_n2mCount - 1]primid=_globalPrimaryIDList[_n2mCount - 1]n2mtable=_globalN2MTableList[_n2mCount - 1]replyid=_globalN2MReplyIDList[_n2mCount - 1]objtable=_globalN2MObjTableList[_n2mCount - 1]n2mobjid=_globalN2MObjIDList[_n2mCount - 1]valname=$parametersManyToMany.stisdeletedrestriction=_globalN2MIsDeletedRestriction[_n2mCount - 1]) | parametersManyToMany contains containsVal -> many_to_many(val=$containsVal.stop=$contains.stmaintable=_globalMainTableList[_n2mCount - 1]primid=_globalPrimaryIDList[_n2mCount - 1]n2mtable=_globalN2MTableList[_n2mCount - 1]replyid=_globalN2MReplyIDList[_n2mCount - 1]objtable=_globalN2MObjTableList[_n2mCount - 1]n2mobjid=_globalN2MObjIDList[_n2mCount - 1]valname=$parametersManyToMany.stisdeletedrestriction=_globalN2MIsDeletedRestriction[_n2mCount - 1]) | parametersManyToMany doesNotContains doesNotContainsVal -> many_to_many_not_contains(val=$doesNotContainsVal.stmaintable=_globalMainTableList[_n2mCount - 1]primid=_globalPrimaryIDList[_n2mCount - 1]n2mtable=_globalN2MTableList[_n2mCount - 1]replyid=_globalN2MReplyIDList[_n2mCount - 1]objtable=_globalN2MObjTableList[_n2mCount - 1]n2mobjid=_globalN2MObjIDList[_n2mCount - 1]valname=$parametersManyToMany.stisdeletedrestriction=_globalN2MIsDeletedRestriction[_n2mCount - 1]) | parametersManyToMany startsWith startsWithVal -> many_to_many(val=$startsWithVal.stop=$startsWith.stmaintable=_globalMainTableList[_n2mCount - 1]primid=_globalPrimaryIDList[_n2mCount - 1]n2mtable=_globalN2MTableList[_n2mCount - 1]replyid=_globalN2MReplyIDList[_n2mCount - 1]objtable=_globalN2MObjTableList[_n2mCount - 1]n2mobjid=_globalN2MObjIDList[_n2mCount - 1]valname=$parametersManyToMany.stisdeletedrestriction=_globalN2MIsDeletedRestriction[_n2mCount - 1]) | parametersManyToMany endsWith endsWithVal -> many_to_many(val=$endsWithVal.stop=$endsWith.stmaintable=_globalMainTableList[_n2mCount - 1]primid=_globalPrimaryIDList[_n2mCount - 1]n2mtable=_globalN2MTableList[_n2mCount - 1]replyid=_globalN2MReplyIDList[_n2mCount - 1]objtable=_globalN2MObjTableList[_n2mCount - 1]n2mobjid=_globalN2MObjIDList[_n2mCount - 1]valname=$parametersManyToMany.stisdeletedrestriction=_globalN2MIsDeletedRestriction[_n2mCount - 1]) | parametersTextifyOneToMany internalopN2M valStr -> textify_one_to_many(val=$valStr.stop=$internalopN2M.stprimid=_globalTextifyPrimaryIDList[_one2manyTextifyCount - 1]foreignKey=_globalTextifyOneToManyForeignKey[_one2manyTextifyCount - 1]tableName=_globalTextifyOneToManyTableName[_one2manyTextifyCount - 1]filteredFieldName=_globalTextifyOneToManyFieldName[_one2manyTextifyCount - 1]isDeleted=_globalTextifyOneToManyIsDeletedName[_one2manyTextifyCount - 1]) | parametersTextifyOneToMany internalopNotEqN2M valStr -> textify_one_to_many_not(val=$valStr.stprimid=_globalTextifyPrimaryIDList[_one2manyTextifyCount - 1]foreignKey=_globalTextifyOneToManyForeignKey[_one2manyTextifyCount - 1]tableName=_globalTextifyOneToManyTableName[_one2manyTextifyCount - 1]filteredFieldName=_globalTextifyOneToManyFieldName[_one2manyTextifyCount - 1]isDeleted=_globalTextifyOneToManyIsDeletedName[_one2manyTextifyCount - 1]) | parametersConstOneToMany internalopN2M valStr -> const_one_to_many(val=$valStr.stop=$internalopN2M.stprimid=_globalConstPrimaryIDList[_one2manyConstCount - 1]foreignKey=_globalConstOneToManyForeignKey[_one2manyConstCount - 1]tableName=_globalConstOneToManyTableName[_one2manyConstCount - 1]filteredFieldName=_globalConstOneToManyFieldName[_one2manyConstCount - 1]isDeleted=_globalConstOneToManyIsDeletedName[_one2manyConstCount - 1]constColumnName=_globalConstOneToManyConstColumnName[_one2manyConstCount - 1]constIntValue=_globalConstOneToManyConstIntValue[_one2manyConstCount - 1]) | parametersConstOneToMany internalopNotEqN2M valStr -> const_one_to_many_not(val=$valStr.stprimid=_globalConstPrimaryIDList[_one2manyConstCount - 1]foreignKey=_globalConstOneToManyForeignKey[_one2manyConstCount - 1]tableName=_globalConstOneToManyTableName[_one2manyConstCount - 1]filteredFieldName=_globalConstOneToManyFieldName[_one2manyConstCount - 1]isDeleted=_globalConstOneToManyIsDeletedName[_one2manyConstCount - 1]constColumnName=_globalConstOneToManyConstColumnName[_one2manyConstCount - 1]constIntValue=_globalConstOneToManyConstIntValue[_one2manyConstCount - 1]) | parametersTableMappedOneToMany internalopN2M valStr -> table_mapped_one_to_many(val=$valStr.stop=$internalopN2M.stprimid=_globalTableMappedPrimaryIDList[_one2manyTableMappedCount - 1]foreignKey=_globalTableMappedOneToManyForeignKey[_one2manyTableMappedCount - 1]tableName=_globalTableMappedOneToManyTableName[_one2manyTableMappedCount - 1]filteredFieldName=_globalTableMappedOneToManyFieldName[_one2manyTableMappedCount - 1]secondTableName=_globalTableMappedOneToManySecondTableName[_one2manyTableMappedCount - 1]secondTablePK=_globalTableMappedOneToManySecondTablePrimaryKey[_one2manyTableMappedCount - 1]secondTableFK=_globalTableMappedOneToManySecondTableForeignKey[_one2manyTableMappedCount - 1]) | parametersTableMappedOneToMany internalopNotEqN2M valStr -> table_mapped_one_to_many_not(val=$valStr.stprimid=_globalTableMappedPrimaryIDList[_one2manyTableMappedCount - 1]foreignKey=_globalTableMappedOneToManyForeignKey[_one2manyTableMappedCount - 1]tableName=_globalTableMappedOneToManyTableName[_one2manyTableMappedCount - 1]filteredFieldName=_globalTableMappedOneToManyFieldName[_one2manyTableMappedCount - 1]secondTableName=_globalTableMappedOneToManySecondTableName[_one2manyTableMappedCount - 1]secondTablePK=_globalTableMappedOneToManySecondTablePrimaryKey[_one2manyTableMappedCount - 1]secondTableFK=_globalTableMappedOneToManySecondTableForeignKey[_one2manyTableMappedCount - 1]));
    public FiltersLanguageGrammarParser.paramexpr_return paramexpr() // throws RecognitionException [1]
    {   
        FiltersLanguageGrammarParser.paramexpr_return retval = new FiltersLanguageGrammarParser.paramexpr_return();
        retval.Start = input.LT(1);

        IList list_a = null;
        IList list_b = null;
        IList list_c = null;
        IList list_d = null;
        IList list_longS = null;
        IList list_mapped = null;
        IList list_e = null;
        IList list_f = null;
        IList list_g = null;
        IList list_h = null;
        FiltersLanguageGrammarParser.logicalexpr_return logicalexpr18 = default(FiltersLanguageGrammarParser.logicalexpr_return);

        FiltersLanguageGrammarParser.token_for_fts_return token_for_fts19 = default(FiltersLanguageGrammarParser.token_for_fts_return);

        FiltersLanguageGrammarParser.parametersStr_return parametersStr20 = default(FiltersLanguageGrammarParser.parametersStr_return);

        FiltersLanguageGrammarParser.internalop_return internalop21 = default(FiltersLanguageGrammarParser.internalop_return);

        FiltersLanguageGrammarParser.valStr_return valStr22 = default(FiltersLanguageGrammarParser.valStr_return);

        FiltersLanguageGrammarParser.paramLongStr_return paramLongStr23 = default(FiltersLanguageGrammarParser.paramLongStr_return);

        FiltersLanguageGrammarParser.internalLongStrOp_return internalLongStrOp24 = default(FiltersLanguageGrammarParser.internalLongStrOp_return);

        FiltersLanguageGrammarParser.valLongStr_return valLongStr25 = default(FiltersLanguageGrammarParser.valLongStr_return);

        FiltersLanguageGrammarParser.parametersStr_return parametersStr26 = default(FiltersLanguageGrammarParser.parametersStr_return);

        FiltersLanguageGrammarParser.contains_return contains27 = default(FiltersLanguageGrammarParser.contains_return);

        FiltersLanguageGrammarParser.containsVal_return containsVal28 = default(FiltersLanguageGrammarParser.containsVal_return);

        FiltersLanguageGrammarParser.paramLongStr_return paramLongStr29 = default(FiltersLanguageGrammarParser.paramLongStr_return);

        FiltersLanguageGrammarParser.contains_return contains30 = default(FiltersLanguageGrammarParser.contains_return);

        FiltersLanguageGrammarParser.containsVal_return containsVal31 = default(FiltersLanguageGrammarParser.containsVal_return);

        FiltersLanguageGrammarParser.parametersUser_return parametersUser32 = default(FiltersLanguageGrammarParser.parametersUser_return);

        FiltersLanguageGrammarParser.contains_return contains33 = default(FiltersLanguageGrammarParser.contains_return);

        FiltersLanguageGrammarParser.containsVal_return containsVal34 = default(FiltersLanguageGrammarParser.containsVal_return);

        FiltersLanguageGrammarParser.parametersStr_return parametersStr35 = default(FiltersLanguageGrammarParser.parametersStr_return);

        FiltersLanguageGrammarParser.doesNotContains_return doesNotContains36 = default(FiltersLanguageGrammarParser.doesNotContains_return);

        FiltersLanguageGrammarParser.doesNotContainsVal_return doesNotContainsVal37 = default(FiltersLanguageGrammarParser.doesNotContainsVal_return);

        FiltersLanguageGrammarParser.paramLongStr_return paramLongStr38 = default(FiltersLanguageGrammarParser.paramLongStr_return);

        FiltersLanguageGrammarParser.doesNotContains_return doesNotContains39 = default(FiltersLanguageGrammarParser.doesNotContains_return);

        FiltersLanguageGrammarParser.doesNotContainsVal_return doesNotContainsVal40 = default(FiltersLanguageGrammarParser.doesNotContainsVal_return);

        FiltersLanguageGrammarParser.parametersUser_return parametersUser41 = default(FiltersLanguageGrammarParser.parametersUser_return);

        FiltersLanguageGrammarParser.doesNotContains_return doesNotContains42 = default(FiltersLanguageGrammarParser.doesNotContains_return);

        FiltersLanguageGrammarParser.doesNotContainsVal_return doesNotContainsVal43 = default(FiltersLanguageGrammarParser.doesNotContainsVal_return);

        FiltersLanguageGrammarParser.parametersStr_return parametersStr44 = default(FiltersLanguageGrammarParser.parametersStr_return);

        FiltersLanguageGrammarParser.startsWith_return startsWith45 = default(FiltersLanguageGrammarParser.startsWith_return);

        FiltersLanguageGrammarParser.startsWithVal_return startsWithVal46 = default(FiltersLanguageGrammarParser.startsWithVal_return);

        FiltersLanguageGrammarParser.paramLongStr_return paramLongStr47 = default(FiltersLanguageGrammarParser.paramLongStr_return);

        FiltersLanguageGrammarParser.startsWith_return startsWith48 = default(FiltersLanguageGrammarParser.startsWith_return);

        FiltersLanguageGrammarParser.startsWithVal_return startsWithVal49 = default(FiltersLanguageGrammarParser.startsWithVal_return);

        FiltersLanguageGrammarParser.parametersUser_return parametersUser50 = default(FiltersLanguageGrammarParser.parametersUser_return);

        FiltersLanguageGrammarParser.startsWith_return startsWith51 = default(FiltersLanguageGrammarParser.startsWith_return);

        FiltersLanguageGrammarParser.startsWithVal_return startsWithVal52 = default(FiltersLanguageGrammarParser.startsWithVal_return);

        FiltersLanguageGrammarParser.parametersStr_return parametersStr53 = default(FiltersLanguageGrammarParser.parametersStr_return);

        FiltersLanguageGrammarParser.endsWith_return endsWith54 = default(FiltersLanguageGrammarParser.endsWith_return);

        FiltersLanguageGrammarParser.endsWithVal_return endsWithVal55 = default(FiltersLanguageGrammarParser.endsWithVal_return);

        FiltersLanguageGrammarParser.paramLongStr_return paramLongStr56 = default(FiltersLanguageGrammarParser.paramLongStr_return);

        FiltersLanguageGrammarParser.endsWith_return endsWith57 = default(FiltersLanguageGrammarParser.endsWith_return);

        FiltersLanguageGrammarParser.endsWithVal_return endsWithVal58 = default(FiltersLanguageGrammarParser.endsWithVal_return);

        FiltersLanguageGrammarParser.parametersUser_return parametersUser59 = default(FiltersLanguageGrammarParser.parametersUser_return);

        FiltersLanguageGrammarParser.endsWith_return endsWith60 = default(FiltersLanguageGrammarParser.endsWith_return);

        FiltersLanguageGrammarParser.endsWithVal_return endsWithVal61 = default(FiltersLanguageGrammarParser.endsWithVal_return);

        FiltersLanguageGrammarParser.parametersInt_return parametersInt62 = default(FiltersLanguageGrammarParser.parametersInt_return);

        FiltersLanguageGrammarParser.internalop_return internalop63 = default(FiltersLanguageGrammarParser.internalop_return);

        FiltersLanguageGrammarParser.valInt_return valInt64 = default(FiltersLanguageGrammarParser.valInt_return);

        FiltersLanguageGrammarParser.parametersDate_return parametersDate65 = default(FiltersLanguageGrammarParser.parametersDate_return);

        FiltersLanguageGrammarParser.internalop_return internalop66 = default(FiltersLanguageGrammarParser.internalop_return);

        FiltersLanguageGrammarParser.valDate_return valDate67 = default(FiltersLanguageGrammarParser.valDate_return);

        FiltersLanguageGrammarParser.parametersDate_return parametersDate68 = default(FiltersLanguageGrammarParser.parametersDate_return);

        FiltersLanguageGrammarParser.internalopSpan_return internalopSpan69 = default(FiltersLanguageGrammarParser.internalopSpan_return);

        FiltersLanguageGrammarParser.valDateSpan_return valDateSpan70 = default(FiltersLanguageGrammarParser.valDateSpan_return);

        FiltersLanguageGrammarParser.parametersDate_return parametersDate71 = default(FiltersLanguageGrammarParser.parametersDate_return);

        FiltersLanguageGrammarParser.lsOpSpan_return lsOpSpan72 = default(FiltersLanguageGrammarParser.lsOpSpan_return);

        FiltersLanguageGrammarParser.valDateSpanLs_return valDateSpanLs73 = default(FiltersLanguageGrammarParser.valDateSpanLs_return);

        FiltersLanguageGrammarParser.parametersDate_return parametersDate74 = default(FiltersLanguageGrammarParser.parametersDate_return);

        FiltersLanguageGrammarParser.grOpSpan_return grOpSpan75 = default(FiltersLanguageGrammarParser.grOpSpan_return);

        FiltersLanguageGrammarParser.valDateSpanGr_return valDateSpanGr76 = default(FiltersLanguageGrammarParser.valDateSpanGr_return);

        FiltersLanguageGrammarParser.parametersDate_return parametersDate77 = default(FiltersLanguageGrammarParser.parametersDate_return);

        FiltersLanguageGrammarParser.lsOrEqOpSpan_return lsOrEqOpSpan78 = default(FiltersLanguageGrammarParser.lsOrEqOpSpan_return);

        FiltersLanguageGrammarParser.valDateSpanLsOrEq_return valDateSpanLsOrEq79 = default(FiltersLanguageGrammarParser.valDateSpanLsOrEq_return);

        FiltersLanguageGrammarParser.parametersDate_return parametersDate80 = default(FiltersLanguageGrammarParser.parametersDate_return);

        FiltersLanguageGrammarParser.grOrEqOpSpan_return grOrEqOpSpan81 = default(FiltersLanguageGrammarParser.grOrEqOpSpan_return);

        FiltersLanguageGrammarParser.valDateSpanGrOrEq_return valDateSpanGrOrEq82 = default(FiltersLanguageGrammarParser.valDateSpanGrOrEq_return);

        FiltersLanguageGrammarParser.parametersUser_return parametersUser83 = default(FiltersLanguageGrammarParser.parametersUser_return);

        FiltersLanguageGrammarParser.internalop_return internalop84 = default(FiltersLanguageGrammarParser.internalop_return);

        FiltersLanguageGrammarParser.valUser_return valUser85 = default(FiltersLanguageGrammarParser.valUser_return);

        FiltersLanguageGrammarParser.parametersBool_return parametersBool86 = default(FiltersLanguageGrammarParser.parametersBool_return);

        FiltersLanguageGrammarParser.internalop_return internalop87 = default(FiltersLanguageGrammarParser.internalop_return);

        FiltersLanguageGrammarParser.valBool_return valBool88 = default(FiltersLanguageGrammarParser.valBool_return);

        FiltersLanguageGrammarParser.parametersMapped_return parametersMapped89 = default(FiltersLanguageGrammarParser.parametersMapped_return);

        FiltersLanguageGrammarParser.internalop_return internalop90 = default(FiltersLanguageGrammarParser.internalop_return);

        FiltersLanguageGrammarParser.valStr_return valStr91 = default(FiltersLanguageGrammarParser.valStr_return);

        FiltersLanguageGrammarParser.parametersStr_return parametersStr92 = default(FiltersLanguageGrammarParser.parametersStr_return);

        FiltersLanguageGrammarParser.multivalueinternalop_return multivalueinternalop93 = default(FiltersLanguageGrammarParser.multivalueinternalop_return);

        FiltersLanguageGrammarParser.parametersInt_return parametersInt94 = default(FiltersLanguageGrammarParser.parametersInt_return);

        FiltersLanguageGrammarParser.multivalueinternalop_return multivalueinternalop95 = default(FiltersLanguageGrammarParser.multivalueinternalop_return);

        FiltersLanguageGrammarParser.parametersDate_return parametersDate96 = default(FiltersLanguageGrammarParser.parametersDate_return);

        FiltersLanguageGrammarParser.multivalueinternalop_return multivalueinternalop97 = default(FiltersLanguageGrammarParser.multivalueinternalop_return);

        FiltersLanguageGrammarParser.parametersUser_return parametersUser98 = default(FiltersLanguageGrammarParser.parametersUser_return);

        FiltersLanguageGrammarParser.multivalueinternalop_return multivalueinternalop99 = default(FiltersLanguageGrammarParser.multivalueinternalop_return);

        FiltersLanguageGrammarParser.paramLongStr_return paramLongStr100 = default(FiltersLanguageGrammarParser.paramLongStr_return);

        FiltersLanguageGrammarParser.multivalueinternalop_return multivalueinternalop101 = default(FiltersLanguageGrammarParser.multivalueinternalop_return);

        FiltersLanguageGrammarParser.parametersMapped_return parametersMapped102 = default(FiltersLanguageGrammarParser.parametersMapped_return);

        FiltersLanguageGrammarParser.multivalueinternalop_return multivalueinternalop103 = default(FiltersLanguageGrammarParser.multivalueinternalop_return);

        FiltersLanguageGrammarParser.parametersStr_return parametersStr104 = default(FiltersLanguageGrammarParser.parametersStr_return);

        FiltersLanguageGrammarParser.parametersInt_return parametersInt105 = default(FiltersLanguageGrammarParser.parametersInt_return);

        FiltersLanguageGrammarParser.parametersDate_return parametersDate106 = default(FiltersLanguageGrammarParser.parametersDate_return);

        FiltersLanguageGrammarParser.parametersUser_return parametersUser107 = default(FiltersLanguageGrammarParser.parametersUser_return);

        FiltersLanguageGrammarParser.parametersBool_return parametersBool108 = default(FiltersLanguageGrammarParser.parametersBool_return);

        FiltersLanguageGrammarParser.parametersDate_return parametersDate109 = default(FiltersLanguageGrammarParser.parametersDate_return);

        FiltersLanguageGrammarParser.paramLongStr_return paramLongStr110 = default(FiltersLanguageGrammarParser.paramLongStr_return);

        FiltersLanguageGrammarParser.parametersMapped_return parametersMapped111 = default(FiltersLanguageGrammarParser.parametersMapped_return);

        FiltersLanguageGrammarParser.valStr_return valStr112 = default(FiltersLanguageGrammarParser.valStr_return);

        FiltersLanguageGrammarParser.internalopN2M_return internalopN2M113 = default(FiltersLanguageGrammarParser.internalopN2M_return);

        FiltersLanguageGrammarParser.parametersManyToMany_return parametersManyToMany114 = default(FiltersLanguageGrammarParser.parametersManyToMany_return);

        FiltersLanguageGrammarParser.valStr_return valStr115 = default(FiltersLanguageGrammarParser.valStr_return);

        FiltersLanguageGrammarParser.parametersManyToMany_return parametersManyToMany116 = default(FiltersLanguageGrammarParser.parametersManyToMany_return);

        FiltersLanguageGrammarParser.multivalueinternalop_return multivalueinternalop117 = default(FiltersLanguageGrammarParser.multivalueinternalop_return);

        FiltersLanguageGrammarParser.parametersManyToMany_return parametersManyToMany118 = default(FiltersLanguageGrammarParser.parametersManyToMany_return);

        FiltersLanguageGrammarParser.parametersManyToMany_return parametersManyToMany119 = default(FiltersLanguageGrammarParser.parametersManyToMany_return);

        FiltersLanguageGrammarParser.containsVal_return containsVal120 = default(FiltersLanguageGrammarParser.containsVal_return);

        FiltersLanguageGrammarParser.contains_return contains121 = default(FiltersLanguageGrammarParser.contains_return);

        FiltersLanguageGrammarParser.parametersManyToMany_return parametersManyToMany122 = default(FiltersLanguageGrammarParser.parametersManyToMany_return);

        FiltersLanguageGrammarParser.doesNotContainsVal_return doesNotContainsVal123 = default(FiltersLanguageGrammarParser.doesNotContainsVal_return);

        FiltersLanguageGrammarParser.parametersManyToMany_return parametersManyToMany124 = default(FiltersLanguageGrammarParser.parametersManyToMany_return);

        FiltersLanguageGrammarParser.startsWithVal_return startsWithVal125 = default(FiltersLanguageGrammarParser.startsWithVal_return);

        FiltersLanguageGrammarParser.startsWith_return startsWith126 = default(FiltersLanguageGrammarParser.startsWith_return);

        FiltersLanguageGrammarParser.parametersManyToMany_return parametersManyToMany127 = default(FiltersLanguageGrammarParser.parametersManyToMany_return);

        FiltersLanguageGrammarParser.endsWithVal_return endsWithVal128 = default(FiltersLanguageGrammarParser.endsWithVal_return);

        FiltersLanguageGrammarParser.endsWith_return endsWith129 = default(FiltersLanguageGrammarParser.endsWith_return);

        FiltersLanguageGrammarParser.parametersManyToMany_return parametersManyToMany130 = default(FiltersLanguageGrammarParser.parametersManyToMany_return);

        FiltersLanguageGrammarParser.valStr_return valStr131 = default(FiltersLanguageGrammarParser.valStr_return);

        FiltersLanguageGrammarParser.internalopN2M_return internalopN2M132 = default(FiltersLanguageGrammarParser.internalopN2M_return);

        FiltersLanguageGrammarParser.valStr_return valStr133 = default(FiltersLanguageGrammarParser.valStr_return);

        FiltersLanguageGrammarParser.valStr_return valStr134 = default(FiltersLanguageGrammarParser.valStr_return);

        FiltersLanguageGrammarParser.internalopN2M_return internalopN2M135 = default(FiltersLanguageGrammarParser.internalopN2M_return);

        FiltersLanguageGrammarParser.valStr_return valStr136 = default(FiltersLanguageGrammarParser.valStr_return);

        FiltersLanguageGrammarParser.valStr_return valStr137 = default(FiltersLanguageGrammarParser.valStr_return);

        FiltersLanguageGrammarParser.internalopN2M_return internalopN2M138 = default(FiltersLanguageGrammarParser.internalopN2M_return);

        FiltersLanguageGrammarParser.valStr_return valStr139 = default(FiltersLanguageGrammarParser.valStr_return);

        FiltersLanguageGrammarParser.valStr_return a = default(FiltersLanguageGrammarParser.valStr_return);
         a = null;
        FiltersLanguageGrammarParser.valInt_return b = default(FiltersLanguageGrammarParser.valInt_return);
         b = null;
        FiltersLanguageGrammarParser.valDate_return c = default(FiltersLanguageGrammarParser.valDate_return);
         c = null;
        FiltersLanguageGrammarParser.valUser_return d = default(FiltersLanguageGrammarParser.valUser_return);
         d = null;
        FiltersLanguageGrammarParser.valStr_return longS = default(FiltersLanguageGrammarParser.valStr_return);
         longS = null;
        FiltersLanguageGrammarParser.valStr_return mapped = default(FiltersLanguageGrammarParser.valStr_return);
         mapped = null;
        FiltersLanguageGrammarParser.valBool_return e = default(FiltersLanguageGrammarParser.valBool_return);
         e = null;
        FiltersLanguageGrammarParser.valDateSpan_return f = default(FiltersLanguageGrammarParser.valDateSpan_return);
         f = null;
        FiltersLanguageGrammarParser.valStr_return g = default(FiltersLanguageGrammarParser.valStr_return);
         g = null;
        FiltersLanguageGrammarParser.valStr_return h = default(FiltersLanguageGrammarParser.valStr_return);
         h = null;
        try 
    	{
            // Output\\FiltersLanguageGrammar.g:560:11: ( '(' logicalexpr ')' -> parenthesis(val=$logicalexpr.st) | token_for_fts -> fts_param(val=$token_for_fts.stmaintable=GlobalMainTableprimid=GlobalPrimaryIDftsid=GlobalFtsID) | parametersStr internalop valStr -> parameter(p=$parametersStr.sto=$internalop.stv=$valStr.st) | paramLongStr internalLongStrOp valLongStr -> parameter(p=$paramLongStr.sto=$internalLongStrOp.stv=$valLongStr.st) | parametersStr contains containsVal -> parameter(p=$parametersStr.sto=$contains.stv=$containsVal.st) | paramLongStr contains containsVal -> parameter(p=$paramLongStr.sto=$contains.stv=$containsVal.st) | parametersUser contains containsVal -> parameter(p=$parametersUser.sto=$contains.stv=$containsVal.st) | parametersStr doesNotContains doesNotContainsVal -> parameter(p=$parametersStr.sto=$doesNotContains.stv=$doesNotContainsVal.st) | paramLongStr doesNotContains doesNotContainsVal -> parameter(p=$paramLongStr.sto=$doesNotContains.stv=$doesNotContainsVal.st) | parametersUser doesNotContains doesNotContainsVal -> parameter(p=$parametersUser.sto=$doesNotContains.stv=$doesNotContainsVal.st) | parametersStr startsWith startsWithVal -> parameter(p=$parametersStr.sto=$startsWith.stv=$startsWithVal.st) | paramLongStr startsWith startsWithVal -> parameter(p=$paramLongStr.sto=$startsWith.stv=$startsWithVal.st) | parametersUser startsWith startsWithVal -> parameter(p=$parametersUser.sto=$startsWith.stv=$startsWithVal.st) | parametersStr endsWith endsWithVal -> parameter(p=$parametersStr.sto=$endsWith.stv=$endsWithVal.st) | paramLongStr endsWith endsWithVal -> parameter(p=$paramLongStr.sto=$endsWith.stv=$endsWithVal.st) | parametersUser endsWith endsWithVal -> parameter(p=$parametersUser.sto=$endsWith.stv=$endsWithVal.st) | parametersInt internalop valInt -> parameter(p=$parametersInt.sto=$internalop.stv=$valInt.st) | parametersDate internalop valDate -> parameter(p=$parametersDate.sto=$internalop.stv=$valDate.st) | parametersDate internalopSpan valDateSpan -> parameter(p=$parametersDate.sto=$internalopSpan.stv=$valDateSpan.st) | parametersDate lsOpSpan valDateSpanLs -> parameter(p=$parametersDate.sto=$lsOpSpan.stv=$valDateSpanLs.st) | parametersDate grOpSpan valDateSpanGr -> parameter(p=$parametersDate.sto=$grOpSpan.stv=$valDateSpanGr.st) | parametersDate lsOrEqOpSpan valDateSpanLsOrEq -> parameter(p=$parametersDate.sto=$lsOrEqOpSpan.stv=$valDateSpanLsOrEq.st) | parametersDate grOrEqOpSpan valDateSpanGrOrEq -> parameter(p=$parametersDate.sto=$grOrEqOpSpan.stv=$valDateSpanGrOrEq.st) | parametersUser internalop valUser -> parameter(p=$parametersUser.sto=$internalop.stv=$valUser.st) | parametersBool internalop valBool -> parameter(p=$parametersBool.sto=$internalop.stv=$valBool.st) | parametersMapped internalop valStr -> parameter(p=$parametersMapped.sto=$internalop.stv=$valStr.st) | parametersStr multivalueinternalop '(' a+= valStr ( ',' a+= valStr )* ')' -> multiparameter(p=$parametersStr.sto=$multivalueinternalop.stv=$a) | parametersInt multivalueinternalop '(' b+= valInt ( ',' b+= valInt )* ')' -> multiparameter(p=$parametersInt.sto=$multivalueinternalop.stv=$b) | parametersDate multivalueinternalop '(' c+= valDate ( ',' c+= valDate )* ')' -> multiparameter(p=$parametersDate.sto=$multivalueinternalop.stv=$c) | parametersUser multivalueinternalop '(' d+= valUser ( ',' d+= valUser )* ')' -> multiparameter(p=$parametersUser.sto=$multivalueinternalop.stv=$d) | paramLongStr multivalueinternalop '(' longS+= valStr ( ',' longS+= valStr )* ')' -> multiparameter(p=$paramLongStr.sto=$multivalueinternalop.stv=$longS) | parametersMapped multivalueinternalop '(' mapped+= valStr ( ',' mapped+= valStr )* ')' -> multiparameter(p=$parametersMapped.sto=$multivalueinternalop.stv=$mapped) | parametersStr 'wasever' '(' a+= valStr ( ',' a+= valStr )* ')' -> wasever(col=$parametersStr.stval=$aview=GlobalModuleEverViewprimid=GlobalPrimaryID) | parametersInt 'wasever' '(' b+= valInt ( ',' b+= valInt )* ')' -> wasever(col=$parametersInt.stval=$bview=GlobalModuleEverViewprimid=GlobalPrimaryID) | parametersDate 'wasever' '(' c+= valDate ( ',' c+= valDate )* ')' -> wasever(col=$parametersDate.stval=$cview=GlobalModuleEverViewprimid=GlobalPrimaryID) | parametersUser 'wasever' '(' d+= valUser ( ',' d+= valUser )* ')' -> wasever(col=$parametersUser.stval=$dview=GlobalModuleEverViewprimid=GlobalPrimaryID) | parametersBool 'wasever' '(' e+= valBool ( ',' e+= valBool )* ')' -> wasever(col=$parametersBool.stval=$eview=GlobalModuleEverViewprimid=GlobalPrimaryID) | parametersDate 'wasever' '(' f+= valDateSpan ( ',' f+= valDateSpan )* ')' -> wasever(col=$parametersDate.stval=$fview=GlobalModuleEverViewprimid=GlobalPrimaryID) | paramLongStr 'wasever' '(' longS+= valStr ( ',' longS+= valStr )* ')' -> wasever(col=$paramLongStr.stval=$longSview=GlobalModuleEverViewprimid=GlobalPrimaryID) | parametersMapped 'wasever' '(' mapped+= valStr ( ',' mapped+= valStr )* ')' -> wasever(col=$parametersMapped.stval=$mappedview=GlobalModuleEverViewprimid=GlobalPrimaryID) | parametersManyToMany internalopN2M valStr -> many_to_many(val=$valStr.stop=$internalopN2M.stmaintable=_globalMainTableList[_n2mCount - 1]primid=_globalPrimaryIDList[_n2mCount - 1]n2mtable=_globalN2MTableList[_n2mCount - 1]replyid=_globalN2MReplyIDList[_n2mCount - 1]objtable=_globalN2MObjTableList[_n2mCount - 1]n2mobjid=_globalN2MObjIDList[_n2mCount - 1]valname=$parametersManyToMany.stisdeletedrestriction=_globalN2MIsDeletedRestriction[_n2mCount - 1]) | parametersManyToMany internalopNotEqN2M valStr -> many_to_many_not(val=$valStr.stmaintable=_globalMainTableList[_n2mCount - 1]primid=_globalPrimaryIDList[_n2mCount - 1]n2mtable=_globalN2MTableList[_n2mCount - 1]replyid=_globalN2MReplyIDList[_n2mCount - 1]objtable=_globalN2MObjTableList[_n2mCount - 1]n2mobjid=_globalN2MObjIDList[_n2mCount - 1]valname=$parametersManyToMany.stisdeletedrestriction=_globalN2MIsDeletedRestriction[_n2mCount - 1]) | parametersManyToMany multivalueinternalop '(' g+= valStr ( ',' g+= valStr )* ')' -> many_to_many_multi(val=$gop=$multivalueinternalop.stmaintable=_globalMainTableList[_n2mCount - 1]primid=_globalPrimaryIDList[_n2mCount - 1]n2mtable=_globalN2MTableList[_n2mCount - 1]replyid=_globalN2MReplyIDList[_n2mCount - 1]objtable=_globalN2MObjTableList[_n2mCount - 1]n2mobjid=_globalN2MObjIDList[_n2mCount - 1]valname=$parametersManyToMany.stisdeletedrestriction=_globalN2MIsDeletedRestriction[_n2mCount - 1]) | parametersManyToMany 'wasever' '(' h+= valStr ( ',' h+= valStr )* ')' -> many_to_many_wasever(val=$hmaintable=_globalMainTableList[_n2mCount - 1]primid=_globalPrimaryIDList[_n2mCount - 1]n2mtable=_globalN2MTableList[_n2mCount - 1]replyid=_globalN2MReplyIDList[_n2mCount - 1]objtable=_globalN2MObjTableList[_n2mCount - 1]n2mobjid=_globalN2MObjIDList[_n2mCount - 1]valname=$parametersManyToMany.stisdeletedrestriction=_globalN2MIsDeletedRestriction[_n2mCount - 1]) | parametersManyToMany contains containsVal -> many_to_many(val=$containsVal.stop=$contains.stmaintable=_globalMainTableList[_n2mCount - 1]primid=_globalPrimaryIDList[_n2mCount - 1]n2mtable=_globalN2MTableList[_n2mCount - 1]replyid=_globalN2MReplyIDList[_n2mCount - 1]objtable=_globalN2MObjTableList[_n2mCount - 1]n2mobjid=_globalN2MObjIDList[_n2mCount - 1]valname=$parametersManyToMany.stisdeletedrestriction=_globalN2MIsDeletedRestriction[_n2mCount - 1]) | parametersManyToMany doesNotContains doesNotContainsVal -> many_to_many_not_contains(val=$doesNotContainsVal.stmaintable=_globalMainTableList[_n2mCount - 1]primid=_globalPrimaryIDList[_n2mCount - 1]n2mtable=_globalN2MTableList[_n2mCount - 1]replyid=_globalN2MReplyIDList[_n2mCount - 1]objtable=_globalN2MObjTableList[_n2mCount - 1]n2mobjid=_globalN2MObjIDList[_n2mCount - 1]valname=$parametersManyToMany.stisdeletedrestriction=_globalN2MIsDeletedRestriction[_n2mCount - 1]) | parametersManyToMany startsWith startsWithVal -> many_to_many(val=$startsWithVal.stop=$startsWith.stmaintable=_globalMainTableList[_n2mCount - 1]primid=_globalPrimaryIDList[_n2mCount - 1]n2mtable=_globalN2MTableList[_n2mCount - 1]replyid=_globalN2MReplyIDList[_n2mCount - 1]objtable=_globalN2MObjTableList[_n2mCount - 1]n2mobjid=_globalN2MObjIDList[_n2mCount - 1]valname=$parametersManyToMany.stisdeletedrestriction=_globalN2MIsDeletedRestriction[_n2mCount - 1]) | parametersManyToMany endsWith endsWithVal -> many_to_many(val=$endsWithVal.stop=$endsWith.stmaintable=_globalMainTableList[_n2mCount - 1]primid=_globalPrimaryIDList[_n2mCount - 1]n2mtable=_globalN2MTableList[_n2mCount - 1]replyid=_globalN2MReplyIDList[_n2mCount - 1]objtable=_globalN2MObjTableList[_n2mCount - 1]n2mobjid=_globalN2MObjIDList[_n2mCount - 1]valname=$parametersManyToMany.stisdeletedrestriction=_globalN2MIsDeletedRestriction[_n2mCount - 1]) | parametersTextifyOneToMany internalopN2M valStr -> textify_one_to_many(val=$valStr.stop=$internalopN2M.stprimid=_globalTextifyPrimaryIDList[_one2manyTextifyCount - 1]foreignKey=_globalTextifyOneToManyForeignKey[_one2manyTextifyCount - 1]tableName=_globalTextifyOneToManyTableName[_one2manyTextifyCount - 1]filteredFieldName=_globalTextifyOneToManyFieldName[_one2manyTextifyCount - 1]isDeleted=_globalTextifyOneToManyIsDeletedName[_one2manyTextifyCount - 1]) | parametersTextifyOneToMany internalopNotEqN2M valStr -> textify_one_to_many_not(val=$valStr.stprimid=_globalTextifyPrimaryIDList[_one2manyTextifyCount - 1]foreignKey=_globalTextifyOneToManyForeignKey[_one2manyTextifyCount - 1]tableName=_globalTextifyOneToManyTableName[_one2manyTextifyCount - 1]filteredFieldName=_globalTextifyOneToManyFieldName[_one2manyTextifyCount - 1]isDeleted=_globalTextifyOneToManyIsDeletedName[_one2manyTextifyCount - 1]) | parametersConstOneToMany internalopN2M valStr -> const_one_to_many(val=$valStr.stop=$internalopN2M.stprimid=_globalConstPrimaryIDList[_one2manyConstCount - 1]foreignKey=_globalConstOneToManyForeignKey[_one2manyConstCount - 1]tableName=_globalConstOneToManyTableName[_one2manyConstCount - 1]filteredFieldName=_globalConstOneToManyFieldName[_one2manyConstCount - 1]isDeleted=_globalConstOneToManyIsDeletedName[_one2manyConstCount - 1]constColumnName=_globalConstOneToManyConstColumnName[_one2manyConstCount - 1]constIntValue=_globalConstOneToManyConstIntValue[_one2manyConstCount - 1]) | parametersConstOneToMany internalopNotEqN2M valStr -> const_one_to_many_not(val=$valStr.stprimid=_globalConstPrimaryIDList[_one2manyConstCount - 1]foreignKey=_globalConstOneToManyForeignKey[_one2manyConstCount - 1]tableName=_globalConstOneToManyTableName[_one2manyConstCount - 1]filteredFieldName=_globalConstOneToManyFieldName[_one2manyConstCount - 1]isDeleted=_globalConstOneToManyIsDeletedName[_one2manyConstCount - 1]constColumnName=_globalConstOneToManyConstColumnName[_one2manyConstCount - 1]constIntValue=_globalConstOneToManyConstIntValue[_one2manyConstCount - 1]) | parametersTableMappedOneToMany internalopN2M valStr -> table_mapped_one_to_many(val=$valStr.stop=$internalopN2M.stprimid=_globalTableMappedPrimaryIDList[_one2manyTableMappedCount - 1]foreignKey=_globalTableMappedOneToManyForeignKey[_one2manyTableMappedCount - 1]tableName=_globalTableMappedOneToManyTableName[_one2manyTableMappedCount - 1]filteredFieldName=_globalTableMappedOneToManyFieldName[_one2manyTableMappedCount - 1]secondTableName=_globalTableMappedOneToManySecondTableName[_one2manyTableMappedCount - 1]secondTablePK=_globalTableMappedOneToManySecondTablePrimaryKey[_one2manyTableMappedCount - 1]secondTableFK=_globalTableMappedOneToManySecondTableForeignKey[_one2manyTableMappedCount - 1]) | parametersTableMappedOneToMany internalopNotEqN2M valStr -> table_mapped_one_to_many_not(val=$valStr.stprimid=_globalTableMappedPrimaryIDList[_one2manyTableMappedCount - 1]foreignKey=_globalTableMappedOneToManyForeignKey[_one2manyTableMappedCount - 1]tableName=_globalTableMappedOneToManyTableName[_one2manyTableMappedCount - 1]filteredFieldName=_globalTableMappedOneToManyFieldName[_one2manyTableMappedCount - 1]secondTableName=_globalTableMappedOneToManySecondTableName[_one2manyTableMappedCount - 1]secondTablePK=_globalTableMappedOneToManySecondTablePrimaryKey[_one2manyTableMappedCount - 1]secondTableFK=_globalTableMappedOneToManySecondTableForeignKey[_one2manyTableMappedCount - 1]))
            int alt21 = 54;
            alt21 = dfa21.Predict(input);
            switch (alt21) 
            {
                case 1 :
                    // Output\\FiltersLanguageGrammar.g:560:13: '(' logicalexpr ')'
                    {
                    	Match(input,10,FOLLOW_10_in_paramexpr996); if (state.failed) return retval;
                    	PushFollow(FOLLOW_logicalexpr_in_paramexpr998);
                    	logicalexpr18 = logicalexpr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	Match(input,11,FOLLOW_11_in_paramexpr1000); if (state.failed) return retval;


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 560:43: -> parenthesis(val=$logicalexpr.st)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("parenthesis",
                    	    new STAttrMap().Add("val", ((logicalexpr18 != null) ? logicalexpr18.ST : null)));
                    	  }

                    	}
                    }
                    break;
                case 2 :
                    // Output\\FiltersLanguageGrammar.g:561:6: token_for_fts
                    {
                    	PushFollow(FOLLOW_token_for_fts_in_paramexpr1028);
                    	token_for_fts19 = token_for_fts();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  					GlobalMainTable 		= ExtractModule(FilterText, _dictMainTable);
                    	  					GlobalPrimaryID 		= ExtractModule(FilterText, _dictPrimID);
                    	  					GlobalFtsID				= ExtractModule(FilterText, _dictFtsID);
                    	  				
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 566:7: -> fts_param(val=$token_for_fts.stmaintable=GlobalMainTableprimid=GlobalPrimaryIDftsid=GlobalFtsID)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("fts_param",
                    	    new STAttrMap().Add("val", ((token_for_fts19 != null) ? token_for_fts19.ST : null)).Add("maintable", GlobalMainTable).Add("primid", GlobalPrimaryID).Add("ftsid", GlobalFtsID));
                    	  }

                    	}
                    }
                    break;
                case 3 :
                    // Output\\FiltersLanguageGrammar.g:567:6: parametersStr internalop valStr
                    {
                    	PushFollow(FOLLOW_parametersStr_in_paramexpr1067);
                    	parametersStr20 = parametersStr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	PushFollow(FOLLOW_internalop_in_paramexpr1069);
                    	internalop21 = internalop();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	PushFollow(FOLLOW_valStr_in_paramexpr1071);
                    	valStr22 = valStr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 567:45: -> parameter(p=$parametersStr.sto=$internalop.stv=$valStr.st)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("parameter",
                    	    new STAttrMap().Add("p", ((parametersStr20 != null) ? parametersStr20.ST : null)).Add("o", ((internalop21 != null) ? internalop21.ST : null)).Add("v", ((valStr22 != null) ? valStr22.ST : null)));
                    	  }

                    	}
                    }
                    break;
                case 4 :
                    // Output\\FiltersLanguageGrammar.g:568:6: paramLongStr internalLongStrOp valLongStr
                    {
                    	PushFollow(FOLLOW_paramLongStr_in_paramexpr1111);
                    	paramLongStr23 = paramLongStr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	PushFollow(FOLLOW_internalLongStrOp_in_paramexpr1113);
                    	internalLongStrOp24 = internalLongStrOp();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	PushFollow(FOLLOW_valLongStr_in_paramexpr1115);
                    	valLongStr25 = valLongStr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 568:52: -> parameter(p=$paramLongStr.sto=$internalLongStrOp.stv=$valLongStr.st)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("parameter",
                    	    new STAttrMap().Add("p", ((paramLongStr23 != null) ? paramLongStr23.ST : null)).Add("o", ((internalLongStrOp24 != null) ? internalLongStrOp24.ST : null)).Add("v", ((valLongStr25 != null) ? valLongStr25.ST : null)));
                    	  }

                    	}
                    }
                    break;
                case 5 :
                    // Output\\FiltersLanguageGrammar.g:569:6: parametersStr contains containsVal
                    {
                    	PushFollow(FOLLOW_parametersStr_in_paramexpr1152);
                    	parametersStr26 = parametersStr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	PushFollow(FOLLOW_contains_in_paramexpr1154);
                    	contains27 = contains();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	PushFollow(FOLLOW_containsVal_in_paramexpr1156);
                    	containsVal28 = containsVal();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 569:47: -> parameter(p=$parametersStr.sto=$contains.stv=$containsVal.st)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("parameter",
                    	    new STAttrMap().Add("p", ((parametersStr26 != null) ? parametersStr26.ST : null)).Add("o", ((contains27 != null) ? contains27.ST : null)).Add("v", ((containsVal28 != null) ? containsVal28.ST : null)));
                    	  }

                    	}
                    }
                    break;
                case 6 :
                    // Output\\FiltersLanguageGrammar.g:570:6: paramLongStr contains containsVal
                    {
                    	PushFollow(FOLLOW_paramLongStr_in_paramexpr1195);
                    	paramLongStr29 = paramLongStr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	PushFollow(FOLLOW_contains_in_paramexpr1197);
                    	contains30 = contains();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	PushFollow(FOLLOW_containsVal_in_paramexpr1199);
                    	containsVal31 = containsVal();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 570:46: -> parameter(p=$paramLongStr.sto=$contains.stv=$containsVal.st)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("parameter",
                    	    new STAttrMap().Add("p", ((paramLongStr29 != null) ? paramLongStr29.ST : null)).Add("o", ((contains30 != null) ? contains30.ST : null)).Add("v", ((containsVal31 != null) ? containsVal31.ST : null)));
                    	  }

                    	}
                    }
                    break;
                case 7 :
                    // Output\\FiltersLanguageGrammar.g:571:6: parametersUser contains containsVal
                    {
                    	PushFollow(FOLLOW_parametersUser_in_paramexpr1238);
                    	parametersUser32 = parametersUser();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	PushFollow(FOLLOW_contains_in_paramexpr1240);
                    	contains33 = contains();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	PushFollow(FOLLOW_containsVal_in_paramexpr1242);
                    	containsVal34 = containsVal();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 571:48: -> parameter(p=$parametersUser.sto=$contains.stv=$containsVal.st)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("parameter",
                    	    new STAttrMap().Add("p", ((parametersUser32 != null) ? parametersUser32.ST : null)).Add("o", ((contains33 != null) ? contains33.ST : null)).Add("v", ((containsVal34 != null) ? containsVal34.ST : null)));
                    	  }

                    	}
                    }
                    break;
                case 8 :
                    // Output\\FiltersLanguageGrammar.g:572:6: parametersStr doesNotContains doesNotContainsVal
                    {
                    	PushFollow(FOLLOW_parametersStr_in_paramexpr1281);
                    	parametersStr35 = parametersStr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	PushFollow(FOLLOW_doesNotContains_in_paramexpr1283);
                    	doesNotContains36 = doesNotContains();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	PushFollow(FOLLOW_doesNotContainsVal_in_paramexpr1285);
                    	doesNotContainsVal37 = doesNotContainsVal();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 572:57: -> parameter(p=$parametersStr.sto=$doesNotContains.stv=$doesNotContainsVal.st)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("parameter",
                    	    new STAttrMap().Add("p", ((parametersStr35 != null) ? parametersStr35.ST : null)).Add("o", ((doesNotContains36 != null) ? doesNotContains36.ST : null)).Add("v", ((doesNotContainsVal37 != null) ? doesNotContainsVal37.ST : null)));
                    	  }

                    	}
                    }
                    break;
                case 9 :
                    // Output\\FiltersLanguageGrammar.g:573:6: paramLongStr doesNotContains doesNotContainsVal
                    {
                    	PushFollow(FOLLOW_paramLongStr_in_paramexpr1320);
                    	paramLongStr38 = paramLongStr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	PushFollow(FOLLOW_doesNotContains_in_paramexpr1322);
                    	doesNotContains39 = doesNotContains();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	PushFollow(FOLLOW_doesNotContainsVal_in_paramexpr1324);
                    	doesNotContainsVal40 = doesNotContainsVal();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 573:57: -> parameter(p=$paramLongStr.sto=$doesNotContains.stv=$doesNotContainsVal.st)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("parameter",
                    	    new STAttrMap().Add("p", ((paramLongStr38 != null) ? paramLongStr38.ST : null)).Add("o", ((doesNotContains39 != null) ? doesNotContains39.ST : null)).Add("v", ((doesNotContainsVal40 != null) ? doesNotContainsVal40.ST : null)));
                    	  }

                    	}
                    }
                    break;
                case 10 :
                    // Output\\FiltersLanguageGrammar.g:574:6: parametersUser doesNotContains doesNotContainsVal
                    {
                    	PushFollow(FOLLOW_parametersUser_in_paramexpr1360);
                    	parametersUser41 = parametersUser();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	PushFollow(FOLLOW_doesNotContains_in_paramexpr1362);
                    	doesNotContains42 = doesNotContains();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	PushFollow(FOLLOW_doesNotContainsVal_in_paramexpr1364);
                    	doesNotContainsVal43 = doesNotContainsVal();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 574:58: -> parameter(p=$parametersUser.sto=$doesNotContains.stv=$doesNotContainsVal.st)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("parameter",
                    	    new STAttrMap().Add("p", ((parametersUser41 != null) ? parametersUser41.ST : null)).Add("o", ((doesNotContains42 != null) ? doesNotContains42.ST : null)).Add("v", ((doesNotContainsVal43 != null) ? doesNotContainsVal43.ST : null)));
                    	  }

                    	}
                    }
                    break;
                case 11 :
                    // Output\\FiltersLanguageGrammar.g:575:6: parametersStr startsWith startsWithVal
                    {
                    	PushFollow(FOLLOW_parametersStr_in_paramexpr1399);
                    	parametersStr44 = parametersStr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	PushFollow(FOLLOW_startsWith_in_paramexpr1401);
                    	startsWith45 = startsWith();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	PushFollow(FOLLOW_startsWithVal_in_paramexpr1403);
                    	startsWithVal46 = startsWithVal();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 575:50: -> parameter(p=$parametersStr.sto=$startsWith.stv=$startsWithVal.st)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("parameter",
                    	    new STAttrMap().Add("p", ((parametersStr44 != null) ? parametersStr44.ST : null)).Add("o", ((startsWith45 != null) ? startsWith45.ST : null)).Add("v", ((startsWithVal46 != null) ? startsWithVal46.ST : null)));
                    	  }

                    	}
                    }
                    break;
                case 12 :
                    // Output\\FiltersLanguageGrammar.g:576:6: paramLongStr startsWith startsWithVal
                    {
                    	PushFollow(FOLLOW_paramLongStr_in_paramexpr1441);
                    	paramLongStr47 = paramLongStr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	PushFollow(FOLLOW_startsWith_in_paramexpr1443);
                    	startsWith48 = startsWith();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	PushFollow(FOLLOW_startsWithVal_in_paramexpr1445);
                    	startsWithVal49 = startsWithVal();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 576:49: -> parameter(p=$paramLongStr.sto=$startsWith.stv=$startsWithVal.st)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("parameter",
                    	    new STAttrMap().Add("p", ((paramLongStr47 != null) ? paramLongStr47.ST : null)).Add("o", ((startsWith48 != null) ? startsWith48.ST : null)).Add("v", ((startsWithVal49 != null) ? startsWithVal49.ST : null)));
                    	  }

                    	}
                    }
                    break;
                case 13 :
                    // Output\\FiltersLanguageGrammar.g:577:6: parametersUser startsWith startsWithVal
                    {
                    	PushFollow(FOLLOW_parametersUser_in_paramexpr1483);
                    	parametersUser50 = parametersUser();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	PushFollow(FOLLOW_startsWith_in_paramexpr1485);
                    	startsWith51 = startsWith();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	PushFollow(FOLLOW_startsWithVal_in_paramexpr1487);
                    	startsWithVal52 = startsWithVal();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 577:51: -> parameter(p=$parametersUser.sto=$startsWith.stv=$startsWithVal.st)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("parameter",
                    	    new STAttrMap().Add("p", ((parametersUser50 != null) ? parametersUser50.ST : null)).Add("o", ((startsWith51 != null) ? startsWith51.ST : null)).Add("v", ((startsWithVal52 != null) ? startsWithVal52.ST : null)));
                    	  }

                    	}
                    }
                    break;
                case 14 :
                    // Output\\FiltersLanguageGrammar.g:578:6: parametersStr endsWith endsWithVal
                    {
                    	PushFollow(FOLLOW_parametersStr_in_paramexpr1525);
                    	parametersStr53 = parametersStr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	PushFollow(FOLLOW_endsWith_in_paramexpr1527);
                    	endsWith54 = endsWith();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	PushFollow(FOLLOW_endsWithVal_in_paramexpr1529);
                    	endsWithVal55 = endsWithVal();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 578:47: -> parameter(p=$parametersStr.sto=$endsWith.stv=$endsWithVal.st)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("parameter",
                    	    new STAttrMap().Add("p", ((parametersStr53 != null) ? parametersStr53.ST : null)).Add("o", ((endsWith54 != null) ? endsWith54.ST : null)).Add("v", ((endsWithVal55 != null) ? endsWithVal55.ST : null)));
                    	  }

                    	}
                    }
                    break;
                case 15 :
                    // Output\\FiltersLanguageGrammar.g:579:6: paramLongStr endsWith endsWithVal
                    {
                    	PushFollow(FOLLOW_paramLongStr_in_paramexpr1568);
                    	paramLongStr56 = paramLongStr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	PushFollow(FOLLOW_endsWith_in_paramexpr1570);
                    	endsWith57 = endsWith();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	PushFollow(FOLLOW_endsWithVal_in_paramexpr1572);
                    	endsWithVal58 = endsWithVal();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 579:46: -> parameter(p=$paramLongStr.sto=$endsWith.stv=$endsWithVal.st)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("parameter",
                    	    new STAttrMap().Add("p", ((paramLongStr56 != null) ? paramLongStr56.ST : null)).Add("o", ((endsWith57 != null) ? endsWith57.ST : null)).Add("v", ((endsWithVal58 != null) ? endsWithVal58.ST : null)));
                    	  }

                    	}
                    }
                    break;
                case 16 :
                    // Output\\FiltersLanguageGrammar.g:580:6: parametersUser endsWith endsWithVal
                    {
                    	PushFollow(FOLLOW_parametersUser_in_paramexpr1611);
                    	parametersUser59 = parametersUser();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	PushFollow(FOLLOW_endsWith_in_paramexpr1613);
                    	endsWith60 = endsWith();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	PushFollow(FOLLOW_endsWithVal_in_paramexpr1615);
                    	endsWithVal61 = endsWithVal();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 580:48: -> parameter(p=$parametersUser.sto=$endsWith.stv=$endsWithVal.st)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("parameter",
                    	    new STAttrMap().Add("p", ((parametersUser59 != null) ? parametersUser59.ST : null)).Add("o", ((endsWith60 != null) ? endsWith60.ST : null)).Add("v", ((endsWithVal61 != null) ? endsWithVal61.ST : null)));
                    	  }

                    	}
                    }
                    break;
                case 17 :
                    // Output\\FiltersLanguageGrammar.g:581:6: parametersInt internalop valInt
                    {
                    	PushFollow(FOLLOW_parametersInt_in_paramexpr1654);
                    	parametersInt62 = parametersInt();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	PushFollow(FOLLOW_internalop_in_paramexpr1656);
                    	internalop63 = internalop();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	PushFollow(FOLLOW_valInt_in_paramexpr1658);
                    	valInt64 = valInt();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 581:45: -> parameter(p=$parametersInt.sto=$internalop.stv=$valInt.st)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("parameter",
                    	    new STAttrMap().Add("p", ((parametersInt62 != null) ? parametersInt62.ST : null)).Add("o", ((internalop63 != null) ? internalop63.ST : null)).Add("v", ((valInt64 != null) ? valInt64.ST : null)));
                    	  }

                    	}
                    }
                    break;
                case 18 :
                    // Output\\FiltersLanguageGrammar.g:582:6: parametersDate internalop valDate
                    {
                    	PushFollow(FOLLOW_parametersDate_in_paramexpr1698);
                    	parametersDate65 = parametersDate();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	PushFollow(FOLLOW_internalop_in_paramexpr1700);
                    	internalop66 = internalop();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	PushFollow(FOLLOW_valDate_in_paramexpr1702);
                    	valDate67 = valDate();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 582:46: -> parameter(p=$parametersDate.sto=$internalop.stv=$valDate.st)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("parameter",
                    	    new STAttrMap().Add("p", ((parametersDate65 != null) ? parametersDate65.ST : null)).Add("o", ((internalop66 != null) ? internalop66.ST : null)).Add("v", ((valDate67 != null) ? valDate67.ST : null)));
                    	  }

                    	}
                    }
                    break;
                case 19 :
                    // Output\\FiltersLanguageGrammar.g:583:6: parametersDate internalopSpan valDateSpan
                    {
                    	PushFollow(FOLLOW_parametersDate_in_paramexpr1740);
                    	parametersDate68 = parametersDate();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	PushFollow(FOLLOW_internalopSpan_in_paramexpr1742);
                    	internalopSpan69 = internalopSpan();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	PushFollow(FOLLOW_valDateSpan_in_paramexpr1744);
                    	valDateSpan70 = valDateSpan();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 583:52: -> parameter(p=$parametersDate.sto=$internalopSpan.stv=$valDateSpan.st)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("parameter",
                    	    new STAttrMap().Add("p", ((parametersDate68 != null) ? parametersDate68.ST : null)).Add("o", ((internalopSpan69 != null) ? internalopSpan69.ST : null)).Add("v", ((valDateSpan70 != null) ? valDateSpan70.ST : null)));
                    	  }

                    	}
                    }
                    break;
                case 20 :
                    // Output\\FiltersLanguageGrammar.g:584:6: parametersDate lsOpSpan valDateSpanLs
                    {
                    	PushFollow(FOLLOW_parametersDate_in_paramexpr1780);
                    	parametersDate71 = parametersDate();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	PushFollow(FOLLOW_lsOpSpan_in_paramexpr1782);
                    	lsOpSpan72 = lsOpSpan();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	PushFollow(FOLLOW_valDateSpanLs_in_paramexpr1784);
                    	valDateSpanLs73 = valDateSpanLs();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 584:49: -> parameter(p=$parametersDate.sto=$lsOpSpan.stv=$valDateSpanLs.st)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("parameter",
                    	    new STAttrMap().Add("p", ((parametersDate71 != null) ? parametersDate71.ST : null)).Add("o", ((lsOpSpan72 != null) ? lsOpSpan72.ST : null)).Add("v", ((valDateSpanLs73 != null) ? valDateSpanLs73.ST : null)));
                    	  }

                    	}
                    }
                    break;
                case 21 :
                    // Output\\FiltersLanguageGrammar.g:585:6: parametersDate grOpSpan valDateSpanGr
                    {
                    	PushFollow(FOLLOW_parametersDate_in_paramexpr1821);
                    	parametersDate74 = parametersDate();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	PushFollow(FOLLOW_grOpSpan_in_paramexpr1823);
                    	grOpSpan75 = grOpSpan();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	PushFollow(FOLLOW_valDateSpanGr_in_paramexpr1825);
                    	valDateSpanGr76 = valDateSpanGr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 585:49: -> parameter(p=$parametersDate.sto=$grOpSpan.stv=$valDateSpanGr.st)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("parameter",
                    	    new STAttrMap().Add("p", ((parametersDate74 != null) ? parametersDate74.ST : null)).Add("o", ((grOpSpan75 != null) ? grOpSpan75.ST : null)).Add("v", ((valDateSpanGr76 != null) ? valDateSpanGr76.ST : null)));
                    	  }

                    	}
                    }
                    break;
                case 22 :
                    // Output\\FiltersLanguageGrammar.g:586:6: parametersDate lsOrEqOpSpan valDateSpanLsOrEq
                    {
                    	PushFollow(FOLLOW_parametersDate_in_paramexpr1862);
                    	parametersDate77 = parametersDate();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	PushFollow(FOLLOW_lsOrEqOpSpan_in_paramexpr1864);
                    	lsOrEqOpSpan78 = lsOrEqOpSpan();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	PushFollow(FOLLOW_valDateSpanLsOrEq_in_paramexpr1866);
                    	valDateSpanLsOrEq79 = valDateSpanLsOrEq();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 586:55: -> parameter(p=$parametersDate.sto=$lsOrEqOpSpan.stv=$valDateSpanLsOrEq.st)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("parameter",
                    	    new STAttrMap().Add("p", ((parametersDate77 != null) ? parametersDate77.ST : null)).Add("o", ((lsOrEqOpSpan78 != null) ? lsOrEqOpSpan78.ST : null)).Add("v", ((valDateSpanLsOrEq79 != null) ? valDateSpanLsOrEq79.ST : null)));
                    	  }

                    	}
                    }
                    break;
                case 23 :
                    // Output\\FiltersLanguageGrammar.g:587:6: parametersDate grOrEqOpSpan valDateSpanGrOrEq
                    {
                    	PushFollow(FOLLOW_parametersDate_in_paramexpr1901);
                    	parametersDate80 = parametersDate();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	PushFollow(FOLLOW_grOrEqOpSpan_in_paramexpr1903);
                    	grOrEqOpSpan81 = grOrEqOpSpan();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	PushFollow(FOLLOW_valDateSpanGrOrEq_in_paramexpr1905);
                    	valDateSpanGrOrEq82 = valDateSpanGrOrEq();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 587:55: -> parameter(p=$parametersDate.sto=$grOrEqOpSpan.stv=$valDateSpanGrOrEq.st)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("parameter",
                    	    new STAttrMap().Add("p", ((parametersDate80 != null) ? parametersDate80.ST : null)).Add("o", ((grOrEqOpSpan81 != null) ? grOrEqOpSpan81.ST : null)).Add("v", ((valDateSpanGrOrEq82 != null) ? valDateSpanGrOrEq82.ST : null)));
                    	  }

                    	}
                    }
                    break;
                case 24 :
                    // Output\\FiltersLanguageGrammar.g:588:6: parametersUser internalop valUser
                    {
                    	PushFollow(FOLLOW_parametersUser_in_paramexpr1940);
                    	parametersUser83 = parametersUser();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	PushFollow(FOLLOW_internalop_in_paramexpr1942);
                    	internalop84 = internalop();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	PushFollow(FOLLOW_valUser_in_paramexpr1944);
                    	valUser85 = valUser();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 588:46: -> parameter(p=$parametersUser.sto=$internalop.stv=$valUser.st)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("parameter",
                    	    new STAttrMap().Add("p", ((parametersUser83 != null) ? parametersUser83.ST : null)).Add("o", ((internalop84 != null) ? internalop84.ST : null)).Add("v", ((valUser85 != null) ? valUser85.ST : null)));
                    	  }

                    	}
                    }
                    break;
                case 25 :
                    // Output\\FiltersLanguageGrammar.g:589:6: parametersBool internalop valBool
                    {
                    	PushFollow(FOLLOW_parametersBool_in_paramexpr1982);
                    	parametersBool86 = parametersBool();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	PushFollow(FOLLOW_internalop_in_paramexpr1984);
                    	internalop87 = internalop();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	PushFollow(FOLLOW_valBool_in_paramexpr1986);
                    	valBool88 = valBool();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 589:46: -> parameter(p=$parametersBool.sto=$internalop.stv=$valBool.st)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("parameter",
                    	    new STAttrMap().Add("p", ((parametersBool86 != null) ? parametersBool86.ST : null)).Add("o", ((internalop87 != null) ? internalop87.ST : null)).Add("v", ((valBool88 != null) ? valBool88.ST : null)));
                    	  }

                    	}
                    }
                    break;
                case 26 :
                    // Output\\FiltersLanguageGrammar.g:590:6: parametersMapped internalop valStr
                    {
                    	PushFollow(FOLLOW_parametersMapped_in_paramexpr2024);
                    	parametersMapped89 = parametersMapped();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	PushFollow(FOLLOW_internalop_in_paramexpr2026);
                    	internalop90 = internalop();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	PushFollow(FOLLOW_valStr_in_paramexpr2028);
                    	valStr91 = valStr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 590:47: -> parameter(p=$parametersMapped.sto=$internalop.stv=$valStr.st)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("parameter",
                    	    new STAttrMap().Add("p", ((parametersMapped89 != null) ? parametersMapped89.ST : null)).Add("o", ((internalop90 != null) ? internalop90.ST : null)).Add("v", ((valStr91 != null) ? valStr91.ST : null)));
                    	  }

                    	}
                    }
                    break;
                case 27 :
                    // Output\\FiltersLanguageGrammar.g:591:6: parametersStr multivalueinternalop '(' a+= valStr ( ',' a+= valStr )* ')'
                    {
                    	PushFollow(FOLLOW_parametersStr_in_paramexpr2067);
                    	parametersStr92 = parametersStr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	PushFollow(FOLLOW_multivalueinternalop_in_paramexpr2069);
                    	multivalueinternalop93 = multivalueinternalop();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	Match(input,10,FOLLOW_10_in_paramexpr2071); if (state.failed) return retval;
                    	PushFollow(FOLLOW_valStr_in_paramexpr2077);
                    	a = valStr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if (list_a == null) list_a = new ArrayList();
                    	list_a.Add(a.Template);

                    	// Output\\FiltersLanguageGrammar.g:591:57: ( ',' a+= valStr )*
                    	do 
                    	{
                    	    int alt5 = 2;
                    	    int LA5_0 = input.LA(1);

                    	    if ( (LA5_0 == 17) )
                    	    {
                    	        alt5 = 1;
                    	    }


                    	    switch (alt5) 
                    		{
                    			case 1 :
                    			    // Output\\FiltersLanguageGrammar.g:591:58: ',' a+= valStr
                    			    {
                    			    	Match(input,17,FOLLOW_17_in_paramexpr2080); if (state.failed) return retval;
                    			    	PushFollow(FOLLOW_valStr_in_paramexpr2086);
                    			    	a = valStr();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if (list_a == null) list_a = new ArrayList();
                    			    	list_a.Add(a.Template);


                    			    }
                    			    break;

                    			default:
                    			    goto loop5;
                    	    }
                    	} while (true);

                    	loop5:
                    		;	// Stops C# compiler whining that label 'loop5' has no statements

                    	Match(input,11,FOLLOW_11_in_paramexpr2090); if (state.failed) return retval;


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 591:81: -> multiparameter(p=$parametersStr.sto=$multivalueinternalop.stv=$a)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("multiparameter",
                    	    new STAttrMap().Add("p", ((parametersStr92 != null) ? parametersStr92.ST : null)).Add("o", ((multivalueinternalop93 != null) ? multivalueinternalop93.ST : null)).Add("v", list_a));
                    	  }

                    	}
                    }
                    break;
                case 28 :
                    // Output\\FiltersLanguageGrammar.g:592:6: parametersInt multivalueinternalop '(' b+= valInt ( ',' b+= valInt )* ')'
                    {
                    	PushFollow(FOLLOW_parametersInt_in_paramexpr2124);
                    	parametersInt94 = parametersInt();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	PushFollow(FOLLOW_multivalueinternalop_in_paramexpr2126);
                    	multivalueinternalop95 = multivalueinternalop();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	Match(input,10,FOLLOW_10_in_paramexpr2128); if (state.failed) return retval;
                    	PushFollow(FOLLOW_valInt_in_paramexpr2134);
                    	b = valInt();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if (list_b == null) list_b = new ArrayList();
                    	list_b.Add(b.Template);

                    	// Output\\FiltersLanguageGrammar.g:592:57: ( ',' b+= valInt )*
                    	do 
                    	{
                    	    int alt6 = 2;
                    	    int LA6_0 = input.LA(1);

                    	    if ( (LA6_0 == 17) )
                    	    {
                    	        alt6 = 1;
                    	    }


                    	    switch (alt6) 
                    		{
                    			case 1 :
                    			    // Output\\FiltersLanguageGrammar.g:592:58: ',' b+= valInt
                    			    {
                    			    	Match(input,17,FOLLOW_17_in_paramexpr2137); if (state.failed) return retval;
                    			    	PushFollow(FOLLOW_valInt_in_paramexpr2143);
                    			    	b = valInt();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if (list_b == null) list_b = new ArrayList();
                    			    	list_b.Add(b.Template);


                    			    }
                    			    break;

                    			default:
                    			    goto loop6;
                    	    }
                    	} while (true);

                    	loop6:
                    		;	// Stops C# compiler whining that label 'loop6' has no statements

                    	Match(input,11,FOLLOW_11_in_paramexpr2147); if (state.failed) return retval;


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 592:81: -> multiparameter(p=$parametersInt.sto=$multivalueinternalop.stv=$b)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("multiparameter",
                    	    new STAttrMap().Add("p", ((parametersInt94 != null) ? parametersInt94.ST : null)).Add("o", ((multivalueinternalop95 != null) ? multivalueinternalop95.ST : null)).Add("v", list_b));
                    	  }

                    	}
                    }
                    break;
                case 29 :
                    // Output\\FiltersLanguageGrammar.g:593:6: parametersDate multivalueinternalop '(' c+= valDate ( ',' c+= valDate )* ')'
                    {
                    	PushFollow(FOLLOW_parametersDate_in_paramexpr2181);
                    	parametersDate96 = parametersDate();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	PushFollow(FOLLOW_multivalueinternalop_in_paramexpr2183);
                    	multivalueinternalop97 = multivalueinternalop();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	Match(input,10,FOLLOW_10_in_paramexpr2185); if (state.failed) return retval;
                    	PushFollow(FOLLOW_valDate_in_paramexpr2191);
                    	c = valDate();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if (list_c == null) list_c = new ArrayList();
                    	list_c.Add(c.Template);

                    	// Output\\FiltersLanguageGrammar.g:593:59: ( ',' c+= valDate )*
                    	do 
                    	{
                    	    int alt7 = 2;
                    	    int LA7_0 = input.LA(1);

                    	    if ( (LA7_0 == 17) )
                    	    {
                    	        alt7 = 1;
                    	    }


                    	    switch (alt7) 
                    		{
                    			case 1 :
                    			    // Output\\FiltersLanguageGrammar.g:593:60: ',' c+= valDate
                    			    {
                    			    	Match(input,17,FOLLOW_17_in_paramexpr2194); if (state.failed) return retval;
                    			    	PushFollow(FOLLOW_valDate_in_paramexpr2200);
                    			    	c = valDate();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if (list_c == null) list_c = new ArrayList();
                    			    	list_c.Add(c.Template);


                    			    }
                    			    break;

                    			default:
                    			    goto loop7;
                    	    }
                    	} while (true);

                    	loop7:
                    		;	// Stops C# compiler whining that label 'loop7' has no statements

                    	Match(input,11,FOLLOW_11_in_paramexpr2204); if (state.failed) return retval;


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 593:83: -> multiparameter(p=$parametersDate.sto=$multivalueinternalop.stv=$c)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("multiparameter",
                    	    new STAttrMap().Add("p", ((parametersDate96 != null) ? parametersDate96.ST : null)).Add("o", ((multivalueinternalop97 != null) ? multivalueinternalop97.ST : null)).Add("v", list_c));
                    	  }

                    	}
                    }
                    break;
                case 30 :
                    // Output\\FiltersLanguageGrammar.g:594:6: parametersUser multivalueinternalop '(' d+= valUser ( ',' d+= valUser )* ')'
                    {
                    	PushFollow(FOLLOW_parametersUser_in_paramexpr2236);
                    	parametersUser98 = parametersUser();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	PushFollow(FOLLOW_multivalueinternalop_in_paramexpr2238);
                    	multivalueinternalop99 = multivalueinternalop();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	Match(input,10,FOLLOW_10_in_paramexpr2240); if (state.failed) return retval;
                    	PushFollow(FOLLOW_valUser_in_paramexpr2246);
                    	d = valUser();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if (list_d == null) list_d = new ArrayList();
                    	list_d.Add(d.Template);

                    	// Output\\FiltersLanguageGrammar.g:594:59: ( ',' d+= valUser )*
                    	do 
                    	{
                    	    int alt8 = 2;
                    	    int LA8_0 = input.LA(1);

                    	    if ( (LA8_0 == 17) )
                    	    {
                    	        alt8 = 1;
                    	    }


                    	    switch (alt8) 
                    		{
                    			case 1 :
                    			    // Output\\FiltersLanguageGrammar.g:594:60: ',' d+= valUser
                    			    {
                    			    	Match(input,17,FOLLOW_17_in_paramexpr2249); if (state.failed) return retval;
                    			    	PushFollow(FOLLOW_valUser_in_paramexpr2255);
                    			    	d = valUser();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if (list_d == null) list_d = new ArrayList();
                    			    	list_d.Add(d.Template);


                    			    }
                    			    break;

                    			default:
                    			    goto loop8;
                    	    }
                    	} while (true);

                    	loop8:
                    		;	// Stops C# compiler whining that label 'loop8' has no statements

                    	Match(input,11,FOLLOW_11_in_paramexpr2259); if (state.failed) return retval;


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 594:83: -> multiparameter(p=$parametersUser.sto=$multivalueinternalop.stv=$d)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("multiparameter",
                    	    new STAttrMap().Add("p", ((parametersUser98 != null) ? parametersUser98.ST : null)).Add("o", ((multivalueinternalop99 != null) ? multivalueinternalop99.ST : null)).Add("v", list_d));
                    	  }

                    	}
                    }
                    break;
                case 31 :
                    // Output\\FiltersLanguageGrammar.g:595:6: paramLongStr multivalueinternalop '(' longS+= valStr ( ',' longS+= valStr )* ')'
                    {
                    	PushFollow(FOLLOW_paramLongStr_in_paramexpr2291);
                    	paramLongStr100 = paramLongStr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	PushFollow(FOLLOW_multivalueinternalop_in_paramexpr2293);
                    	multivalueinternalop101 = multivalueinternalop();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	Match(input,10,FOLLOW_10_in_paramexpr2295); if (state.failed) return retval;
                    	PushFollow(FOLLOW_valStr_in_paramexpr2301);
                    	longS = valStr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if (list_longS == null) list_longS = new ArrayList();
                    	list_longS.Add(longS.Template);

                    	// Output\\FiltersLanguageGrammar.g:595:60: ( ',' longS+= valStr )*
                    	do 
                    	{
                    	    int alt9 = 2;
                    	    int LA9_0 = input.LA(1);

                    	    if ( (LA9_0 == 17) )
                    	    {
                    	        alt9 = 1;
                    	    }


                    	    switch (alt9) 
                    		{
                    			case 1 :
                    			    // Output\\FiltersLanguageGrammar.g:595:61: ',' longS+= valStr
                    			    {
                    			    	Match(input,17,FOLLOW_17_in_paramexpr2304); if (state.failed) return retval;
                    			    	PushFollow(FOLLOW_valStr_in_paramexpr2310);
                    			    	longS = valStr();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if (list_longS == null) list_longS = new ArrayList();
                    			    	list_longS.Add(longS.Template);


                    			    }
                    			    break;

                    			default:
                    			    goto loop9;
                    	    }
                    	} while (true);

                    	loop9:
                    		;	// Stops C# compiler whining that label 'loop9' has no statements

                    	Match(input,11,FOLLOW_11_in_paramexpr2314); if (state.failed) return retval;


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 595:86: -> multiparameter(p=$paramLongStr.sto=$multivalueinternalop.stv=$longS)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("multiparameter",
                    	    new STAttrMap().Add("p", ((paramLongStr100 != null) ? paramLongStr100.ST : null)).Add("o", ((multivalueinternalop101 != null) ? multivalueinternalop101.ST : null)).Add("v", list_longS));
                    	  }

                    	}
                    }
                    break;
                case 32 :
                    // Output\\FiltersLanguageGrammar.g:596:6: parametersMapped multivalueinternalop '(' mapped+= valStr ( ',' mapped+= valStr )* ')'
                    {
                    	PushFollow(FOLLOW_parametersMapped_in_paramexpr2346);
                    	parametersMapped102 = parametersMapped();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	PushFollow(FOLLOW_multivalueinternalop_in_paramexpr2348);
                    	multivalueinternalop103 = multivalueinternalop();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	Match(input,10,FOLLOW_10_in_paramexpr2350); if (state.failed) return retval;
                    	PushFollow(FOLLOW_valStr_in_paramexpr2356);
                    	mapped = valStr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if (list_mapped == null) list_mapped = new ArrayList();
                    	list_mapped.Add(mapped.Template);

                    	// Output\\FiltersLanguageGrammar.g:596:65: ( ',' mapped+= valStr )*
                    	do 
                    	{
                    	    int alt10 = 2;
                    	    int LA10_0 = input.LA(1);

                    	    if ( (LA10_0 == 17) )
                    	    {
                    	        alt10 = 1;
                    	    }


                    	    switch (alt10) 
                    		{
                    			case 1 :
                    			    // Output\\FiltersLanguageGrammar.g:596:66: ',' mapped+= valStr
                    			    {
                    			    	Match(input,17,FOLLOW_17_in_paramexpr2359); if (state.failed) return retval;
                    			    	PushFollow(FOLLOW_valStr_in_paramexpr2365);
                    			    	mapped = valStr();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if (list_mapped == null) list_mapped = new ArrayList();
                    			    	list_mapped.Add(mapped.Template);


                    			    }
                    			    break;

                    			default:
                    			    goto loop10;
                    	    }
                    	} while (true);

                    	loop10:
                    		;	// Stops C# compiler whining that label 'loop10' has no statements

                    	Match(input,11,FOLLOW_11_in_paramexpr2369); if (state.failed) return retval;


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 596:93: -> multiparameter(p=$parametersMapped.sto=$multivalueinternalop.stv=$mapped)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("multiparameter",
                    	    new STAttrMap().Add("p", ((parametersMapped102 != null) ? parametersMapped102.ST : null)).Add("o", ((multivalueinternalop103 != null) ? multivalueinternalop103.ST : null)).Add("v", list_mapped));
                    	  }

                    	}
                    }
                    break;
                case 33 :
                    // Output\\FiltersLanguageGrammar.g:597:6: parametersStr 'wasever' '(' a+= valStr ( ',' a+= valStr )* ')'
                    {
                    	PushFollow(FOLLOW_parametersStr_in_paramexpr2402);
                    	parametersStr104 = parametersStr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	Match(input,18,FOLLOW_18_in_paramexpr2404); if (state.failed) return retval;
                    	Match(input,10,FOLLOW_10_in_paramexpr2406); if (state.failed) return retval;
                    	PushFollow(FOLLOW_valStr_in_paramexpr2412);
                    	a = valStr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if (list_a == null) list_a = new ArrayList();
                    	list_a.Add(a.Template);

                    	// Output\\FiltersLanguageGrammar.g:597:46: ( ',' a+= valStr )*
                    	do 
                    	{
                    	    int alt11 = 2;
                    	    int LA11_0 = input.LA(1);

                    	    if ( (LA11_0 == 17) )
                    	    {
                    	        alt11 = 1;
                    	    }


                    	    switch (alt11) 
                    		{
                    			case 1 :
                    			    // Output\\FiltersLanguageGrammar.g:597:47: ',' a+= valStr
                    			    {
                    			    	Match(input,17,FOLLOW_17_in_paramexpr2415); if (state.failed) return retval;
                    			    	PushFollow(FOLLOW_valStr_in_paramexpr2421);
                    			    	a = valStr();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if (list_a == null) list_a = new ArrayList();
                    			    	list_a.Add(a.Template);


                    			    }
                    			    break;

                    			default:
                    			    goto loop11;
                    	    }
                    	} while (true);

                    	loop11:
                    		;	// Stops C# compiler whining that label 'loop11' has no statements

                    	Match(input,11,FOLLOW_11_in_paramexpr2425); if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  					GlobalModuleEverView 	= ExtractModule(FilterText, _dictEverViews);
                    	  					GlobalPrimaryID 		= ExtractModule(FilterText, _dictPrimID);
                    	  				
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 601:7: -> wasever(col=$parametersStr.stval=$aview=GlobalModuleEverViewprimid=GlobalPrimaryID)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("wasever",
                    	    new STAttrMap().Add("col", ((parametersStr104 != null) ? parametersStr104.ST : null)).Add("val", list_a).Add("view", GlobalModuleEverView).Add("primid", GlobalPrimaryID));
                    	  }

                    	}
                    }
                    break;
                case 34 :
                    // Output\\FiltersLanguageGrammar.g:602:6: parametersInt 'wasever' '(' b+= valInt ( ',' b+= valInt )* ')'
                    {
                    	PushFollow(FOLLOW_parametersInt_in_paramexpr2466);
                    	parametersInt105 = parametersInt();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	Match(input,18,FOLLOW_18_in_paramexpr2468); if (state.failed) return retval;
                    	Match(input,10,FOLLOW_10_in_paramexpr2470); if (state.failed) return retval;
                    	PushFollow(FOLLOW_valInt_in_paramexpr2476);
                    	b = valInt();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if (list_b == null) list_b = new ArrayList();
                    	list_b.Add(b.Template);

                    	// Output\\FiltersLanguageGrammar.g:602:46: ( ',' b+= valInt )*
                    	do 
                    	{
                    	    int alt12 = 2;
                    	    int LA12_0 = input.LA(1);

                    	    if ( (LA12_0 == 17) )
                    	    {
                    	        alt12 = 1;
                    	    }


                    	    switch (alt12) 
                    		{
                    			case 1 :
                    			    // Output\\FiltersLanguageGrammar.g:602:47: ',' b+= valInt
                    			    {
                    			    	Match(input,17,FOLLOW_17_in_paramexpr2479); if (state.failed) return retval;
                    			    	PushFollow(FOLLOW_valInt_in_paramexpr2485);
                    			    	b = valInt();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if (list_b == null) list_b = new ArrayList();
                    			    	list_b.Add(b.Template);


                    			    }
                    			    break;

                    			default:
                    			    goto loop12;
                    	    }
                    	} while (true);

                    	loop12:
                    		;	// Stops C# compiler whining that label 'loop12' has no statements

                    	Match(input,11,FOLLOW_11_in_paramexpr2489); if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  					GlobalModuleEverView 	= ExtractModule(FilterText, _dictEverViews);
                    	  					GlobalPrimaryID 		= ExtractModule(FilterText, _dictPrimID);
                    	  				
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 606:7: -> wasever(col=$parametersInt.stval=$bview=GlobalModuleEverViewprimid=GlobalPrimaryID)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("wasever",
                    	    new STAttrMap().Add("col", ((parametersInt105 != null) ? parametersInt105.ST : null)).Add("val", list_b).Add("view", GlobalModuleEverView).Add("primid", GlobalPrimaryID));
                    	  }

                    	}
                    }
                    break;
                case 35 :
                    // Output\\FiltersLanguageGrammar.g:607:6: parametersDate 'wasever' '(' c+= valDate ( ',' c+= valDate )* ')'
                    {
                    	PushFollow(FOLLOW_parametersDate_in_paramexpr2530);
                    	parametersDate106 = parametersDate();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	Match(input,18,FOLLOW_18_in_paramexpr2532); if (state.failed) return retval;
                    	Match(input,10,FOLLOW_10_in_paramexpr2534); if (state.failed) return retval;
                    	PushFollow(FOLLOW_valDate_in_paramexpr2540);
                    	c = valDate();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if (list_c == null) list_c = new ArrayList();
                    	list_c.Add(c.Template);

                    	// Output\\FiltersLanguageGrammar.g:607:48: ( ',' c+= valDate )*
                    	do 
                    	{
                    	    int alt13 = 2;
                    	    int LA13_0 = input.LA(1);

                    	    if ( (LA13_0 == 17) )
                    	    {
                    	        alt13 = 1;
                    	    }


                    	    switch (alt13) 
                    		{
                    			case 1 :
                    			    // Output\\FiltersLanguageGrammar.g:607:49: ',' c+= valDate
                    			    {
                    			    	Match(input,17,FOLLOW_17_in_paramexpr2543); if (state.failed) return retval;
                    			    	PushFollow(FOLLOW_valDate_in_paramexpr2549);
                    			    	c = valDate();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if (list_c == null) list_c = new ArrayList();
                    			    	list_c.Add(c.Template);


                    			    }
                    			    break;

                    			default:
                    			    goto loop13;
                    	    }
                    	} while (true);

                    	loop13:
                    		;	// Stops C# compiler whining that label 'loop13' has no statements

                    	Match(input,11,FOLLOW_11_in_paramexpr2553); if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  					GlobalModuleEverView 	= ExtractModule(FilterText, _dictEverViews);
                    	  					GlobalPrimaryID 		= ExtractModule(FilterText, _dictPrimID);
                    	  				
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 611:7: -> wasever(col=$parametersDate.stval=$cview=GlobalModuleEverViewprimid=GlobalPrimaryID)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("wasever",
                    	    new STAttrMap().Add("col", ((parametersDate106 != null) ? parametersDate106.ST : null)).Add("val", list_c).Add("view", GlobalModuleEverView).Add("primid", GlobalPrimaryID));
                    	  }

                    	}
                    }
                    break;
                case 36 :
                    // Output\\FiltersLanguageGrammar.g:612:6: parametersUser 'wasever' '(' d+= valUser ( ',' d+= valUser )* ')'
                    {
                    	PushFollow(FOLLOW_parametersUser_in_paramexpr2594);
                    	parametersUser107 = parametersUser();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	Match(input,18,FOLLOW_18_in_paramexpr2596); if (state.failed) return retval;
                    	Match(input,10,FOLLOW_10_in_paramexpr2598); if (state.failed) return retval;
                    	PushFollow(FOLLOW_valUser_in_paramexpr2604);
                    	d = valUser();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if (list_d == null) list_d = new ArrayList();
                    	list_d.Add(d.Template);

                    	// Output\\FiltersLanguageGrammar.g:612:48: ( ',' d+= valUser )*
                    	do 
                    	{
                    	    int alt14 = 2;
                    	    int LA14_0 = input.LA(1);

                    	    if ( (LA14_0 == 17) )
                    	    {
                    	        alt14 = 1;
                    	    }


                    	    switch (alt14) 
                    		{
                    			case 1 :
                    			    // Output\\FiltersLanguageGrammar.g:612:49: ',' d+= valUser
                    			    {
                    			    	Match(input,17,FOLLOW_17_in_paramexpr2607); if (state.failed) return retval;
                    			    	PushFollow(FOLLOW_valUser_in_paramexpr2613);
                    			    	d = valUser();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if (list_d == null) list_d = new ArrayList();
                    			    	list_d.Add(d.Template);


                    			    }
                    			    break;

                    			default:
                    			    goto loop14;
                    	    }
                    	} while (true);

                    	loop14:
                    		;	// Stops C# compiler whining that label 'loop14' has no statements

                    	Match(input,11,FOLLOW_11_in_paramexpr2617); if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  					GlobalModuleEverView 	= ExtractModule(FilterText, _dictEverViews);
                    	  					GlobalPrimaryID 		= ExtractModule(FilterText, _dictPrimID);
                    	  				
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 616:7: -> wasever(col=$parametersUser.stval=$dview=GlobalModuleEverViewprimid=GlobalPrimaryID)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("wasever",
                    	    new STAttrMap().Add("col", ((parametersUser107 != null) ? parametersUser107.ST : null)).Add("val", list_d).Add("view", GlobalModuleEverView).Add("primid", GlobalPrimaryID));
                    	  }

                    	}
                    }
                    break;
                case 37 :
                    // Output\\FiltersLanguageGrammar.g:617:6: parametersBool 'wasever' '(' e+= valBool ( ',' e+= valBool )* ')'
                    {
                    	PushFollow(FOLLOW_parametersBool_in_paramexpr2659);
                    	parametersBool108 = parametersBool();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	Match(input,18,FOLLOW_18_in_paramexpr2661); if (state.failed) return retval;
                    	Match(input,10,FOLLOW_10_in_paramexpr2663); if (state.failed) return retval;
                    	PushFollow(FOLLOW_valBool_in_paramexpr2669);
                    	e = valBool();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if (list_e == null) list_e = new ArrayList();
                    	list_e.Add(e.Template);

                    	// Output\\FiltersLanguageGrammar.g:617:48: ( ',' e+= valBool )*
                    	do 
                    	{
                    	    int alt15 = 2;
                    	    int LA15_0 = input.LA(1);

                    	    if ( (LA15_0 == 17) )
                    	    {
                    	        alt15 = 1;
                    	    }


                    	    switch (alt15) 
                    		{
                    			case 1 :
                    			    // Output\\FiltersLanguageGrammar.g:617:49: ',' e+= valBool
                    			    {
                    			    	Match(input,17,FOLLOW_17_in_paramexpr2672); if (state.failed) return retval;
                    			    	PushFollow(FOLLOW_valBool_in_paramexpr2678);
                    			    	e = valBool();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if (list_e == null) list_e = new ArrayList();
                    			    	list_e.Add(e.Template);


                    			    }
                    			    break;

                    			default:
                    			    goto loop15;
                    	    }
                    	} while (true);

                    	loop15:
                    		;	// Stops C# compiler whining that label 'loop15' has no statements

                    	Match(input,11,FOLLOW_11_in_paramexpr2682); if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  					GlobalModuleEverView 	= ExtractModule(FilterText, _dictEverViews);
                    	  					GlobalPrimaryID 		= ExtractModule(FilterText, _dictPrimID);
                    	  				
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 621:7: -> wasever(col=$parametersBool.stval=$eview=GlobalModuleEverViewprimid=GlobalPrimaryID)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("wasever",
                    	    new STAttrMap().Add("col", ((parametersBool108 != null) ? parametersBool108.ST : null)).Add("val", list_e).Add("view", GlobalModuleEverView).Add("primid", GlobalPrimaryID));
                    	  }

                    	}
                    }
                    break;
                case 38 :
                    // Output\\FiltersLanguageGrammar.g:622:6: parametersDate 'wasever' '(' f+= valDateSpan ( ',' f+= valDateSpan )* ')'
                    {
                    	PushFollow(FOLLOW_parametersDate_in_paramexpr2723);
                    	parametersDate109 = parametersDate();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	Match(input,18,FOLLOW_18_in_paramexpr2725); if (state.failed) return retval;
                    	Match(input,10,FOLLOW_10_in_paramexpr2727); if (state.failed) return retval;
                    	PushFollow(FOLLOW_valDateSpan_in_paramexpr2733);
                    	f = valDateSpan();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if (list_f == null) list_f = new ArrayList();
                    	list_f.Add(f.Template);

                    	// Output\\FiltersLanguageGrammar.g:622:52: ( ',' f+= valDateSpan )*
                    	do 
                    	{
                    	    int alt16 = 2;
                    	    int LA16_0 = input.LA(1);

                    	    if ( (LA16_0 == 17) )
                    	    {
                    	        alt16 = 1;
                    	    }


                    	    switch (alt16) 
                    		{
                    			case 1 :
                    			    // Output\\FiltersLanguageGrammar.g:622:53: ',' f+= valDateSpan
                    			    {
                    			    	Match(input,17,FOLLOW_17_in_paramexpr2736); if (state.failed) return retval;
                    			    	PushFollow(FOLLOW_valDateSpan_in_paramexpr2742);
                    			    	f = valDateSpan();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if (list_f == null) list_f = new ArrayList();
                    			    	list_f.Add(f.Template);


                    			    }
                    			    break;

                    			default:
                    			    goto loop16;
                    	    }
                    	} while (true);

                    	loop16:
                    		;	// Stops C# compiler whining that label 'loop16' has no statements

                    	Match(input,11,FOLLOW_11_in_paramexpr2746); if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  					GlobalModuleEverView 	= ExtractModule(FilterText, _dictEverViews);
                    	  					GlobalPrimaryID 		= ExtractModule(FilterText, _dictPrimID);
                    	  				
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 626:7: -> wasever(col=$parametersDate.stval=$fview=GlobalModuleEverViewprimid=GlobalPrimaryID)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("wasever",
                    	    new STAttrMap().Add("col", ((parametersDate109 != null) ? parametersDate109.ST : null)).Add("val", list_f).Add("view", GlobalModuleEverView).Add("primid", GlobalPrimaryID));
                    	  }

                    	}
                    }
                    break;
                case 39 :
                    // Output\\FiltersLanguageGrammar.g:627:6: paramLongStr 'wasever' '(' longS+= valStr ( ',' longS+= valStr )* ')'
                    {
                    	PushFollow(FOLLOW_paramLongStr_in_paramexpr2787);
                    	paramLongStr110 = paramLongStr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	Match(input,18,FOLLOW_18_in_paramexpr2789); if (state.failed) return retval;
                    	Match(input,10,FOLLOW_10_in_paramexpr2791); if (state.failed) return retval;
                    	PushFollow(FOLLOW_valStr_in_paramexpr2797);
                    	longS = valStr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if (list_longS == null) list_longS = new ArrayList();
                    	list_longS.Add(longS.Template);

                    	// Output\\FiltersLanguageGrammar.g:627:49: ( ',' longS+= valStr )*
                    	do 
                    	{
                    	    int alt17 = 2;
                    	    int LA17_0 = input.LA(1);

                    	    if ( (LA17_0 == 17) )
                    	    {
                    	        alt17 = 1;
                    	    }


                    	    switch (alt17) 
                    		{
                    			case 1 :
                    			    // Output\\FiltersLanguageGrammar.g:627:50: ',' longS+= valStr
                    			    {
                    			    	Match(input,17,FOLLOW_17_in_paramexpr2800); if (state.failed) return retval;
                    			    	PushFollow(FOLLOW_valStr_in_paramexpr2806);
                    			    	longS = valStr();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if (list_longS == null) list_longS = new ArrayList();
                    			    	list_longS.Add(longS.Template);


                    			    }
                    			    break;

                    			default:
                    			    goto loop17;
                    	    }
                    	} while (true);

                    	loop17:
                    		;	// Stops C# compiler whining that label 'loop17' has no statements

                    	Match(input,11,FOLLOW_11_in_paramexpr2810); if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  					GlobalModuleEverView 	= ExtractModule(FilterText, _dictEverViews);
                    	  					GlobalPrimaryID 		= ExtractModule(FilterText, _dictPrimID);
                    	  				
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 631:7: -> wasever(col=$paramLongStr.stval=$longSview=GlobalModuleEverViewprimid=GlobalPrimaryID)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("wasever",
                    	    new STAttrMap().Add("col", ((paramLongStr110 != null) ? paramLongStr110.ST : null)).Add("val", list_longS).Add("view", GlobalModuleEverView).Add("primid", GlobalPrimaryID));
                    	  }

                    	}
                    }
                    break;
                case 40 :
                    // Output\\FiltersLanguageGrammar.g:632:6: parametersMapped 'wasever' '(' mapped+= valStr ( ',' mapped+= valStr )* ')'
                    {
                    	PushFollow(FOLLOW_parametersMapped_in_paramexpr2851);
                    	parametersMapped111 = parametersMapped();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	Match(input,18,FOLLOW_18_in_paramexpr2853); if (state.failed) return retval;
                    	Match(input,10,FOLLOW_10_in_paramexpr2855); if (state.failed) return retval;
                    	PushFollow(FOLLOW_valStr_in_paramexpr2861);
                    	mapped = valStr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if (list_mapped == null) list_mapped = new ArrayList();
                    	list_mapped.Add(mapped.Template);

                    	// Output\\FiltersLanguageGrammar.g:632:54: ( ',' mapped+= valStr )*
                    	do 
                    	{
                    	    int alt18 = 2;
                    	    int LA18_0 = input.LA(1);

                    	    if ( (LA18_0 == 17) )
                    	    {
                    	        alt18 = 1;
                    	    }


                    	    switch (alt18) 
                    		{
                    			case 1 :
                    			    // Output\\FiltersLanguageGrammar.g:632:55: ',' mapped+= valStr
                    			    {
                    			    	Match(input,17,FOLLOW_17_in_paramexpr2864); if (state.failed) return retval;
                    			    	PushFollow(FOLLOW_valStr_in_paramexpr2870);
                    			    	mapped = valStr();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if (list_mapped == null) list_mapped = new ArrayList();
                    			    	list_mapped.Add(mapped.Template);


                    			    }
                    			    break;

                    			default:
                    			    goto loop18;
                    	    }
                    	} while (true);

                    	loop18:
                    		;	// Stops C# compiler whining that label 'loop18' has no statements

                    	Match(input,11,FOLLOW_11_in_paramexpr2874); if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  					GlobalModuleEverView 	= ExtractModule(FilterText, _dictEverViews);
                    	  					GlobalPrimaryID 		= ExtractModule(FilterText, _dictPrimID);
                    	  				
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 636:7: -> wasever(col=$parametersMapped.stval=$mappedview=GlobalModuleEverViewprimid=GlobalPrimaryID)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("wasever",
                    	    new STAttrMap().Add("col", ((parametersMapped111 != null) ? parametersMapped111.ST : null)).Add("val", list_mapped).Add("view", GlobalModuleEverView).Add("primid", GlobalPrimaryID));
                    	  }

                    	}
                    }
                    break;
                case 41 :
                    // Output\\FiltersLanguageGrammar.g:637:6: parametersManyToMany internalopN2M valStr
                    {
                    	PushFollow(FOLLOW_parametersManyToMany_in_paramexpr2915);
                    	parametersManyToMany114 = parametersManyToMany();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	PushFollow(FOLLOW_internalopN2M_in_paramexpr2917);
                    	internalopN2M113 = internalopN2M();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	PushFollow(FOLLOW_valStr_in_paramexpr2919);
                    	valStr112 = valStr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  					_globalMainTableList.Add(ExtractModule(FilterText, _dictMainTable));
                    	  					_globalPrimaryIDList.Add(ExtractModule(FilterText, _dictPrimID));
                    	  					_globalN2MTableList.Add(ExtractManyToManyModuleAndField(_filterText, _paramExpr, _dictN2MTables));
                    	  					_globalN2MReplyIDList.Add(ExtractManyToManyModuleAndField(_filterText, _paramExpr, _dictN2MReplyID));
                    	  					_globalN2MObjTableList.Add(ExtractManyToManyModuleAndField(_filterText, _paramExpr, _dictN2MObjTables));
                    	  					_globalN2MObjIDList.Add(ExtractManyToManyModuleAndField(_filterText, _paramExpr, _dictN2MObjID));
                    	  					_globalN2MIsDeletedRestriction.Add(ExtractManyToManyModuleAndField(_filterText, _paramExpr, _dictN2MIsDeletedRestriction));
                    	  					_n2mCount++;
                    	  				
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 647:7: -> many_to_many(val=$valStr.stop=$internalopN2M.stmaintable=_globalMainTableList[_n2mCount - 1]primid=_globalPrimaryIDList[_n2mCount - 1]n2mtable=_globalN2MTableList[_n2mCount - 1]replyid=_globalN2MReplyIDList[_n2mCount - 1]objtable=_globalN2MObjTableList[_n2mCount - 1]n2mobjid=_globalN2MObjIDList[_n2mCount - 1]valname=$parametersManyToMany.stisdeletedrestriction=_globalN2MIsDeletedRestriction[_n2mCount - 1])
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("many_to_many",
                    	    new STAttrMap().Add("val", ((valStr112 != null) ? valStr112.ST : null)).Add("op", ((internalopN2M113 != null) ? internalopN2M113.ST : null)).Add("maintable", _globalMainTableList[_n2mCount - 1]).Add("primid", _globalPrimaryIDList[_n2mCount - 1]).Add("n2mtable", _globalN2MTableList[_n2mCount - 1]).Add("replyid", _globalN2MReplyIDList[_n2mCount - 1]).Add("objtable", _globalN2MObjTableList[_n2mCount - 1]).Add("n2mobjid", _globalN2MObjIDList[_n2mCount - 1]).Add("valname", ((parametersManyToMany114 != null) ? parametersManyToMany114.ST : null)).Add("isdeletedrestriction", _globalN2MIsDeletedRestriction[_n2mCount - 1]));
                    	  }

                    	}
                    }
                    break;
                case 42 :
                    // Output\\FiltersLanguageGrammar.g:652:6: parametersManyToMany internalopNotEqN2M valStr
                    {
                    	PushFollow(FOLLOW_parametersManyToMany_in_paramexpr3046);
                    	parametersManyToMany116 = parametersManyToMany();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	PushFollow(FOLLOW_internalopNotEqN2M_in_paramexpr3048);
                    	internalopNotEqN2M();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	PushFollow(FOLLOW_valStr_in_paramexpr3050);
                    	valStr115 = valStr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  					_globalMainTableList.Add(ExtractModule(FilterText, _dictMainTable));
                    	  					_globalPrimaryIDList.Add(ExtractModule(FilterText, _dictPrimID));
                    	  					_globalN2MTableList.Add(ExtractManyToManyModuleAndField(_filterText, _paramExpr, _dictN2MTables));
                    	  					_globalN2MReplyIDList.Add(ExtractManyToManyModuleAndField(_filterText, _paramExpr, _dictN2MReplyID));
                    	  					_globalN2MObjTableList.Add(ExtractManyToManyModuleAndField(_filterText, _paramExpr, _dictN2MObjTables));
                    	  					_globalN2MObjIDList.Add(ExtractManyToManyModuleAndField(_filterText, _paramExpr, _dictN2MObjID));
                    	  					_globalN2MIsDeletedRestriction.Add(ExtractManyToManyModuleAndField(_filterText, _paramExpr, _dictN2MIsDeletedRestriction));
                    	  					_n2mCount++;
                    	  				
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 662:7: -> many_to_many_not(val=$valStr.stmaintable=_globalMainTableList[_n2mCount - 1]primid=_globalPrimaryIDList[_n2mCount - 1]n2mtable=_globalN2MTableList[_n2mCount - 1]replyid=_globalN2MReplyIDList[_n2mCount - 1]objtable=_globalN2MObjTableList[_n2mCount - 1]n2mobjid=_globalN2MObjIDList[_n2mCount - 1]valname=$parametersManyToMany.stisdeletedrestriction=_globalN2MIsDeletedRestriction[_n2mCount - 1])
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("many_to_many_not",
                    	    new STAttrMap().Add("val", ((valStr115 != null) ? valStr115.ST : null)).Add("maintable", _globalMainTableList[_n2mCount - 1]).Add("primid", _globalPrimaryIDList[_n2mCount - 1]).Add("n2mtable", _globalN2MTableList[_n2mCount - 1]).Add("replyid", _globalN2MReplyIDList[_n2mCount - 1]).Add("objtable", _globalN2MObjTableList[_n2mCount - 1]).Add("n2mobjid", _globalN2MObjIDList[_n2mCount - 1]).Add("valname", ((parametersManyToMany116 != null) ? parametersManyToMany116.ST : null)).Add("isdeletedrestriction", _globalN2MIsDeletedRestriction[_n2mCount - 1]));
                    	  }

                    	}
                    }
                    break;
                case 43 :
                    // Output\\FiltersLanguageGrammar.g:668:6: parametersManyToMany multivalueinternalop '(' g+= valStr ( ',' g+= valStr )* ')'
                    {
                    	PushFollow(FOLLOW_parametersManyToMany_in_paramexpr3179);
                    	parametersManyToMany118 = parametersManyToMany();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	PushFollow(FOLLOW_multivalueinternalop_in_paramexpr3181);
                    	multivalueinternalop117 = multivalueinternalop();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	Match(input,10,FOLLOW_10_in_paramexpr3183); if (state.failed) return retval;
                    	PushFollow(FOLLOW_valStr_in_paramexpr3189);
                    	g = valStr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if (list_g == null) list_g = new ArrayList();
                    	list_g.Add(g.Template);

                    	// Output\\FiltersLanguageGrammar.g:668:64: ( ',' g+= valStr )*
                    	do 
                    	{
                    	    int alt19 = 2;
                    	    int LA19_0 = input.LA(1);

                    	    if ( (LA19_0 == 17) )
                    	    {
                    	        alt19 = 1;
                    	    }


                    	    switch (alt19) 
                    		{
                    			case 1 :
                    			    // Output\\FiltersLanguageGrammar.g:668:65: ',' g+= valStr
                    			    {
                    			    	Match(input,17,FOLLOW_17_in_paramexpr3192); if (state.failed) return retval;
                    			    	PushFollow(FOLLOW_valStr_in_paramexpr3198);
                    			    	g = valStr();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if (list_g == null) list_g = new ArrayList();
                    			    	list_g.Add(g.Template);


                    			    }
                    			    break;

                    			default:
                    			    goto loop19;
                    	    }
                    	} while (true);

                    	loop19:
                    		;	// Stops C# compiler whining that label 'loop19' has no statements

                    	Match(input,11,FOLLOW_11_in_paramexpr3202); if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  					_globalMainTableList.Add(ExtractModule(FilterText, _dictMainTable));
                    	  					_globalPrimaryIDList.Add(ExtractModule(FilterText, _dictPrimID));
                    	  					_globalN2MTableList.Add(ExtractManyToManyModuleAndField(_filterText, _paramExpr, _dictN2MTables));
                    	  					_globalN2MReplyIDList.Add(ExtractManyToManyModuleAndField(_filterText, _paramExpr, _dictN2MReplyID));
                    	  					_globalN2MObjTableList.Add(ExtractManyToManyModuleAndField(_filterText, _paramExpr, _dictN2MObjTables));
                    	  					_globalN2MObjIDList.Add(ExtractManyToManyModuleAndField(_filterText, _paramExpr, _dictN2MObjID));
                    	  					_globalN2MIsDeletedRestriction.Add(ExtractManyToManyModuleAndField(_filterText, _paramExpr, _dictN2MIsDeletedRestriction));
                    	  					_n2mCount++;
                    	  				
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 678:7: -> many_to_many_multi(val=$gop=$multivalueinternalop.stmaintable=_globalMainTableList[_n2mCount - 1]primid=_globalPrimaryIDList[_n2mCount - 1]n2mtable=_globalN2MTableList[_n2mCount - 1]replyid=_globalN2MReplyIDList[_n2mCount - 1]objtable=_globalN2MObjTableList[_n2mCount - 1]n2mobjid=_globalN2MObjIDList[_n2mCount - 1]valname=$parametersManyToMany.stisdeletedrestriction=_globalN2MIsDeletedRestriction[_n2mCount - 1])
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("many_to_many_multi",
                    	    new STAttrMap().Add("val", list_g).Add("op", ((multivalueinternalop117 != null) ? multivalueinternalop117.ST : null)).Add("maintable", _globalMainTableList[_n2mCount - 1]).Add("primid", _globalPrimaryIDList[_n2mCount - 1]).Add("n2mtable", _globalN2MTableList[_n2mCount - 1]).Add("replyid", _globalN2MReplyIDList[_n2mCount - 1]).Add("objtable", _globalN2MObjTableList[_n2mCount - 1]).Add("n2mobjid", _globalN2MObjIDList[_n2mCount - 1]).Add("valname", ((parametersManyToMany118 != null) ? parametersManyToMany118.ST : null)).Add("isdeletedrestriction", _globalN2MIsDeletedRestriction[_n2mCount - 1]));
                    	  }

                    	}
                    }
                    break;
                case 44 :
                    // Output\\FiltersLanguageGrammar.g:683:6: parametersManyToMany 'wasever' '(' h+= valStr ( ',' h+= valStr )* ')'
                    {
                    	PushFollow(FOLLOW_parametersManyToMany_in_paramexpr3337);
                    	parametersManyToMany119 = parametersManyToMany();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	Match(input,18,FOLLOW_18_in_paramexpr3339); if (state.failed) return retval;
                    	Match(input,10,FOLLOW_10_in_paramexpr3341); if (state.failed) return retval;
                    	PushFollow(FOLLOW_valStr_in_paramexpr3347);
                    	h = valStr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if (list_h == null) list_h = new ArrayList();
                    	list_h.Add(h.Template);

                    	// Output\\FiltersLanguageGrammar.g:683:53: ( ',' h+= valStr )*
                    	do 
                    	{
                    	    int alt20 = 2;
                    	    int LA20_0 = input.LA(1);

                    	    if ( (LA20_0 == 17) )
                    	    {
                    	        alt20 = 1;
                    	    }


                    	    switch (alt20) 
                    		{
                    			case 1 :
                    			    // Output\\FiltersLanguageGrammar.g:683:54: ',' h+= valStr
                    			    {
                    			    	Match(input,17,FOLLOW_17_in_paramexpr3350); if (state.failed) return retval;
                    			    	PushFollow(FOLLOW_valStr_in_paramexpr3356);
                    			    	h = valStr();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if (list_h == null) list_h = new ArrayList();
                    			    	list_h.Add(h.Template);


                    			    }
                    			    break;

                    			default:
                    			    goto loop20;
                    	    }
                    	} while (true);

                    	loop20:
                    		;	// Stops C# compiler whining that label 'loop20' has no statements

                    	Match(input,11,FOLLOW_11_in_paramexpr3360); if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  					_globalMainTableList.Add(ExtractModule(FilterText, _dictMainTable));
                    	  					_globalPrimaryIDList.Add(ExtractModule(FilterText, _dictPrimID));
                    	  					_globalN2MTableList.Add(ExtractManyToManyModuleAndField(_filterText, _paramExpr, _dictN2MTables));
                    	  					_globalN2MReplyIDList.Add(ExtractManyToManyModuleAndField(_filterText, _paramExpr, _dictN2MReplyID));
                    	  					_globalN2MObjTableList.Add(ExtractManyToManyModuleAndField(_filterText, _paramExpr, _dictN2MObjTables));
                    	  					_globalN2MObjIDList.Add(ExtractManyToManyModuleAndField(_filterText, _paramExpr, _dictN2MObjID));
                    	  					_globalN2MIsDeletedRestriction.Add(ExtractManyToManyModuleAndField(_filterText, _paramExpr, _dictN2MIsDeletedRestriction));
                    	  					_n2mCount++;
                    	  				
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 693:7: -> many_to_many_wasever(val=$hmaintable=_globalMainTableList[_n2mCount - 1]primid=_globalPrimaryIDList[_n2mCount - 1]n2mtable=_globalN2MTableList[_n2mCount - 1]replyid=_globalN2MReplyIDList[_n2mCount - 1]objtable=_globalN2MObjTableList[_n2mCount - 1]n2mobjid=_globalN2MObjIDList[_n2mCount - 1]valname=$parametersManyToMany.stisdeletedrestriction=_globalN2MIsDeletedRestriction[_n2mCount - 1])
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("many_to_many_wasever",
                    	    new STAttrMap().Add("val", list_h).Add("maintable", _globalMainTableList[_n2mCount - 1]).Add("primid", _globalPrimaryIDList[_n2mCount - 1]).Add("n2mtable", _globalN2MTableList[_n2mCount - 1]).Add("replyid", _globalN2MReplyIDList[_n2mCount - 1]).Add("objtable", _globalN2MObjTableList[_n2mCount - 1]).Add("n2mobjid", _globalN2MObjIDList[_n2mCount - 1]).Add("valname", ((parametersManyToMany119 != null) ? parametersManyToMany119.ST : null)).Add("isdeletedrestriction", _globalN2MIsDeletedRestriction[_n2mCount - 1]));
                    	  }

                    	}
                    }
                    break;
                case 45 :
                    // Output\\FiltersLanguageGrammar.g:698:6: parametersManyToMany contains containsVal
                    {
                    	PushFollow(FOLLOW_parametersManyToMany_in_paramexpr3488);
                    	parametersManyToMany122 = parametersManyToMany();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	PushFollow(FOLLOW_contains_in_paramexpr3490);
                    	contains121 = contains();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	PushFollow(FOLLOW_containsVal_in_paramexpr3492);
                    	containsVal120 = containsVal();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  					_globalMainTableList.Add(ExtractModule(FilterText, _dictMainTable));
                    	  					_globalPrimaryIDList.Add(ExtractModule(FilterText, _dictPrimID));
                    	  					_globalN2MTableList.Add(ExtractManyToManyModuleAndField(_filterText, _paramExpr, _dictN2MTables));
                    	  					_globalN2MReplyIDList.Add(ExtractManyToManyModuleAndField(_filterText, _paramExpr, _dictN2MReplyID));
                    	  					_globalN2MObjTableList.Add(ExtractManyToManyModuleAndField(_filterText, _paramExpr, _dictN2MObjTables));
                    	  					_globalN2MObjIDList.Add(ExtractManyToManyModuleAndField(_filterText, _paramExpr, _dictN2MObjID));
                    	  					_globalN2MIsDeletedRestriction.Add(ExtractManyToManyModuleAndField(_filterText, _paramExpr, _dictN2MIsDeletedRestriction));
                    	  					_n2mCount++;
                    	  				
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 708:7: -> many_to_many(val=$containsVal.stop=$contains.stmaintable=_globalMainTableList[_n2mCount - 1]primid=_globalPrimaryIDList[_n2mCount - 1]n2mtable=_globalN2MTableList[_n2mCount - 1]replyid=_globalN2MReplyIDList[_n2mCount - 1]objtable=_globalN2MObjTableList[_n2mCount - 1]n2mobjid=_globalN2MObjIDList[_n2mCount - 1]valname=$parametersManyToMany.stisdeletedrestriction=_globalN2MIsDeletedRestriction[_n2mCount - 1])
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("many_to_many",
                    	    new STAttrMap().Add("val", ((containsVal120 != null) ? containsVal120.ST : null)).Add("op", ((contains121 != null) ? contains121.ST : null)).Add("maintable", _globalMainTableList[_n2mCount - 1]).Add("primid", _globalPrimaryIDList[_n2mCount - 1]).Add("n2mtable", _globalN2MTableList[_n2mCount - 1]).Add("replyid", _globalN2MReplyIDList[_n2mCount - 1]).Add("objtable", _globalN2MObjTableList[_n2mCount - 1]).Add("n2mobjid", _globalN2MObjIDList[_n2mCount - 1]).Add("valname", ((parametersManyToMany122 != null) ? parametersManyToMany122.ST : null)).Add("isdeletedrestriction", _globalN2MIsDeletedRestriction[_n2mCount - 1]));
                    	  }

                    	}
                    }
                    break;
                case 46 :
                    // Output\\FiltersLanguageGrammar.g:713:6: parametersManyToMany doesNotContains doesNotContainsVal
                    {
                    	PushFollow(FOLLOW_parametersManyToMany_in_paramexpr3619);
                    	parametersManyToMany124 = parametersManyToMany();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	PushFollow(FOLLOW_doesNotContains_in_paramexpr3621);
                    	doesNotContains();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	PushFollow(FOLLOW_doesNotContainsVal_in_paramexpr3623);
                    	doesNotContainsVal123 = doesNotContainsVal();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  					_globalMainTableList.Add(ExtractModule(FilterText, _dictMainTable));
                    	  					_globalPrimaryIDList.Add(ExtractModule(FilterText, _dictPrimID));
                    	  					_globalN2MTableList.Add(ExtractManyToManyModuleAndField(_filterText, _paramExpr, _dictN2MTables));
                    	  					_globalN2MReplyIDList.Add(ExtractManyToManyModuleAndField(_filterText, _paramExpr, _dictN2MReplyID));
                    	  					_globalN2MObjTableList.Add(ExtractManyToManyModuleAndField(_filterText, _paramExpr, _dictN2MObjTables));
                    	  					_globalN2MObjIDList.Add(ExtractManyToManyModuleAndField(_filterText, _paramExpr, _dictN2MObjID));
                    	  					_globalN2MIsDeletedRestriction.Add(ExtractManyToManyModuleAndField(_filterText, _paramExpr, _dictN2MIsDeletedRestriction));
                    	  					_n2mCount++;
                    	  				
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 723:7: -> many_to_many_not_contains(val=$doesNotContainsVal.stmaintable=_globalMainTableList[_n2mCount - 1]primid=_globalPrimaryIDList[_n2mCount - 1]n2mtable=_globalN2MTableList[_n2mCount - 1]replyid=_globalN2MReplyIDList[_n2mCount - 1]objtable=_globalN2MObjTableList[_n2mCount - 1]n2mobjid=_globalN2MObjIDList[_n2mCount - 1]valname=$parametersManyToMany.stisdeletedrestriction=_globalN2MIsDeletedRestriction[_n2mCount - 1])
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("many_to_many_not_contains",
                    	    new STAttrMap().Add("val", ((doesNotContainsVal123 != null) ? doesNotContainsVal123.ST : null)).Add("maintable", _globalMainTableList[_n2mCount - 1]).Add("primid", _globalPrimaryIDList[_n2mCount - 1]).Add("n2mtable", _globalN2MTableList[_n2mCount - 1]).Add("replyid", _globalN2MReplyIDList[_n2mCount - 1]).Add("objtable", _globalN2MObjTableList[_n2mCount - 1]).Add("n2mobjid", _globalN2MObjIDList[_n2mCount - 1]).Add("valname", ((parametersManyToMany124 != null) ? parametersManyToMany124.ST : null)).Add("isdeletedrestriction", _globalN2MIsDeletedRestriction[_n2mCount - 1]));
                    	  }

                    	}
                    }
                    break;
                case 47 :
                    // Output\\FiltersLanguageGrammar.g:729:6: parametersManyToMany startsWith startsWithVal
                    {
                    	PushFollow(FOLLOW_parametersManyToMany_in_paramexpr3752);
                    	parametersManyToMany127 = parametersManyToMany();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	PushFollow(FOLLOW_startsWith_in_paramexpr3754);
                    	startsWith126 = startsWith();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	PushFollow(FOLLOW_startsWithVal_in_paramexpr3756);
                    	startsWithVal125 = startsWithVal();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  					_globalMainTableList.Add(ExtractModule(FilterText, _dictMainTable));
                    	  					_globalPrimaryIDList.Add(ExtractModule(FilterText, _dictPrimID));
                    	  					_globalN2MTableList.Add(ExtractManyToManyModuleAndField(_filterText, _paramExpr, _dictN2MTables));
                    	  					_globalN2MReplyIDList.Add(ExtractManyToManyModuleAndField(_filterText, _paramExpr, _dictN2MReplyID));
                    	  					_globalN2MObjTableList.Add(ExtractManyToManyModuleAndField(_filterText, _paramExpr, _dictN2MObjTables));
                    	  					_globalN2MObjIDList.Add(ExtractManyToManyModuleAndField(_filterText, _paramExpr, _dictN2MObjID));
                    	  					_globalN2MIsDeletedRestriction.Add(ExtractManyToManyModuleAndField(_filterText, _paramExpr, _dictN2MIsDeletedRestriction));
                    	  					_n2mCount++;
                    	  				
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 739:7: -> many_to_many(val=$startsWithVal.stop=$startsWith.stmaintable=_globalMainTableList[_n2mCount - 1]primid=_globalPrimaryIDList[_n2mCount - 1]n2mtable=_globalN2MTableList[_n2mCount - 1]replyid=_globalN2MReplyIDList[_n2mCount - 1]objtable=_globalN2MObjTableList[_n2mCount - 1]n2mobjid=_globalN2MObjIDList[_n2mCount - 1]valname=$parametersManyToMany.stisdeletedrestriction=_globalN2MIsDeletedRestriction[_n2mCount - 1])
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("many_to_many",
                    	    new STAttrMap().Add("val", ((startsWithVal125 != null) ? startsWithVal125.ST : null)).Add("op", ((startsWith126 != null) ? startsWith126.ST : null)).Add("maintable", _globalMainTableList[_n2mCount - 1]).Add("primid", _globalPrimaryIDList[_n2mCount - 1]).Add("n2mtable", _globalN2MTableList[_n2mCount - 1]).Add("replyid", _globalN2MReplyIDList[_n2mCount - 1]).Add("objtable", _globalN2MObjTableList[_n2mCount - 1]).Add("n2mobjid", _globalN2MObjIDList[_n2mCount - 1]).Add("valname", ((parametersManyToMany127 != null) ? parametersManyToMany127.ST : null)).Add("isdeletedrestriction", _globalN2MIsDeletedRestriction[_n2mCount - 1]));
                    	  }

                    	}
                    }
                    break;
                case 48 :
                    // Output\\FiltersLanguageGrammar.g:744:6: parametersManyToMany endsWith endsWithVal
                    {
                    	PushFollow(FOLLOW_parametersManyToMany_in_paramexpr3883);
                    	parametersManyToMany130 = parametersManyToMany();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	PushFollow(FOLLOW_endsWith_in_paramexpr3885);
                    	endsWith129 = endsWith();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	PushFollow(FOLLOW_endsWithVal_in_paramexpr3887);
                    	endsWithVal128 = endsWithVal();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  					_globalMainTableList.Add(ExtractModule(FilterText, _dictMainTable));
                    	  					_globalPrimaryIDList.Add(ExtractModule(FilterText, _dictPrimID));
                    	  					_globalN2MTableList.Add(ExtractManyToManyModuleAndField(_filterText, _paramExpr, _dictN2MTables));
                    	  					_globalN2MReplyIDList.Add(ExtractManyToManyModuleAndField(_filterText, _paramExpr, _dictN2MReplyID));
                    	  					_globalN2MObjTableList.Add(ExtractManyToManyModuleAndField(_filterText, _paramExpr, _dictN2MObjTables));
                    	  					_globalN2MObjIDList.Add(ExtractManyToManyModuleAndField(_filterText, _paramExpr, _dictN2MObjID));
                    	  					_globalN2MIsDeletedRestriction.Add(ExtractManyToManyModuleAndField(_filterText, _paramExpr, _dictN2MIsDeletedRestriction));
                    	  					_n2mCount++;
                    	  				
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 754:7: -> many_to_many(val=$endsWithVal.stop=$endsWith.stmaintable=_globalMainTableList[_n2mCount - 1]primid=_globalPrimaryIDList[_n2mCount - 1]n2mtable=_globalN2MTableList[_n2mCount - 1]replyid=_globalN2MReplyIDList[_n2mCount - 1]objtable=_globalN2MObjTableList[_n2mCount - 1]n2mobjid=_globalN2MObjIDList[_n2mCount - 1]valname=$parametersManyToMany.stisdeletedrestriction=_globalN2MIsDeletedRestriction[_n2mCount - 1])
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("many_to_many",
                    	    new STAttrMap().Add("val", ((endsWithVal128 != null) ? endsWithVal128.ST : null)).Add("op", ((endsWith129 != null) ? endsWith129.ST : null)).Add("maintable", _globalMainTableList[_n2mCount - 1]).Add("primid", _globalPrimaryIDList[_n2mCount - 1]).Add("n2mtable", _globalN2MTableList[_n2mCount - 1]).Add("replyid", _globalN2MReplyIDList[_n2mCount - 1]).Add("objtable", _globalN2MObjTableList[_n2mCount - 1]).Add("n2mobjid", _globalN2MObjIDList[_n2mCount - 1]).Add("valname", ((parametersManyToMany130 != null) ? parametersManyToMany130.ST : null)).Add("isdeletedrestriction", _globalN2MIsDeletedRestriction[_n2mCount - 1]));
                    	  }

                    	}
                    }
                    break;
                case 49 :
                    // Output\\FiltersLanguageGrammar.g:759:6: parametersTextifyOneToMany internalopN2M valStr
                    {
                    	PushFollow(FOLLOW_parametersTextifyOneToMany_in_paramexpr4014);
                    	parametersTextifyOneToMany();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	PushFollow(FOLLOW_internalopN2M_in_paramexpr4016);
                    	internalopN2M132 = internalopN2M();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	PushFollow(FOLLOW_valStr_in_paramexpr4018);
                    	valStr131 = valStr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  					_one2manyTextifyCount++;
                    	  					_globalTextifyPrimaryIDList.Add(ExtractOneToManyModuleAndField(_filterText, _paramExpr, _dictionaryTextifyOneToManyPrimaryCompareKey));
                    	  					_globalTextifyOneToManyForeignKey.Add(ExtractOneToManyModuleAndField(_filterText, _paramExpr, _dictionaryTextifyOneToManyForeignKeyName));
                    	  					_globalTextifyOneToManyTableName.Add(ExtractOneToManyModuleAndField(_filterText, _paramExpr, _dictionaryTextifyOneToManyTableName));
                    	  					_globalTextifyOneToManyFieldName.Add(ExtractOneToManyModuleAndField(_filterText, _paramExpr, _dictionaryTextifyOneToManyTextFieldName));
                    	  					_globalTextifyOneToManyIsDeletedName.Add(ExtractOneToManyModuleAndField(_filterText, _paramExpr, _dictionaryTextifyOneToManyIsDeletedName));
                    	  				
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 767:7: -> textify_one_to_many(val=$valStr.stop=$internalopN2M.stprimid=_globalTextifyPrimaryIDList[_one2manyTextifyCount - 1]foreignKey=_globalTextifyOneToManyForeignKey[_one2manyTextifyCount - 1]tableName=_globalTextifyOneToManyTableName[_one2manyTextifyCount - 1]filteredFieldName=_globalTextifyOneToManyFieldName[_one2manyTextifyCount - 1]isDeleted=_globalTextifyOneToManyIsDeletedName[_one2manyTextifyCount - 1])
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("textify_one_to_many",
                    	    new STAttrMap().Add("val", ((valStr131 != null) ? valStr131.ST : null)).Add("op", ((internalopN2M132 != null) ? internalopN2M132.ST : null)).Add("primid", _globalTextifyPrimaryIDList[_one2manyTextifyCount - 1]).Add("foreignKey", _globalTextifyOneToManyForeignKey[_one2manyTextifyCount - 1]).Add("tableName", _globalTextifyOneToManyTableName[_one2manyTextifyCount - 1]).Add("filteredFieldName", _globalTextifyOneToManyFieldName[_one2manyTextifyCount - 1]).Add("isDeleted", _globalTextifyOneToManyIsDeletedName[_one2manyTextifyCount - 1]));
                    	  }

                    	}
                    }
                    break;
                case 50 :
                    // Output\\FiltersLanguageGrammar.g:774:6: parametersTextifyOneToMany internalopNotEqN2M valStr
                    {
                    	PushFollow(FOLLOW_parametersTextifyOneToMany_in_paramexpr4151);
                    	parametersTextifyOneToMany();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	PushFollow(FOLLOW_internalopNotEqN2M_in_paramexpr4153);
                    	internalopNotEqN2M();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	PushFollow(FOLLOW_valStr_in_paramexpr4155);
                    	valStr133 = valStr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  					_one2manyTextifyCount++;
                    	  					_globalTextifyPrimaryIDList.Add(ExtractOneToManyModuleAndField(_filterText, _paramExpr, _dictionaryTextifyOneToManyPrimaryCompareKey));
                    	  					_globalTextifyOneToManyForeignKey.Add(ExtractOneToManyModuleAndField(_filterText, _paramExpr, _dictionaryTextifyOneToManyForeignKeyName));
                    	  					_globalTextifyOneToManyTableName.Add(ExtractOneToManyModuleAndField(_filterText, _paramExpr, _dictionaryTextifyOneToManyTableName));
                    	  					_globalTextifyOneToManyFieldName.Add(ExtractOneToManyModuleAndField(_filterText, _paramExpr, _dictionaryTextifyOneToManyTextFieldName));
                    	  					_globalTextifyOneToManyIsDeletedName.Add(ExtractOneToManyModuleAndField(_filterText, _paramExpr, _dictionaryTextifyOneToManyIsDeletedName));
                    	  				
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 782:7: -> textify_one_to_many_not(val=$valStr.stprimid=_globalTextifyPrimaryIDList[_one2manyTextifyCount - 1]foreignKey=_globalTextifyOneToManyForeignKey[_one2manyTextifyCount - 1]tableName=_globalTextifyOneToManyTableName[_one2manyTextifyCount - 1]filteredFieldName=_globalTextifyOneToManyFieldName[_one2manyTextifyCount - 1]isDeleted=_globalTextifyOneToManyIsDeletedName[_one2manyTextifyCount - 1])
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("textify_one_to_many_not",
                    	    new STAttrMap().Add("val", ((valStr133 != null) ? valStr133.ST : null)).Add("primid", _globalTextifyPrimaryIDList[_one2manyTextifyCount - 1]).Add("foreignKey", _globalTextifyOneToManyForeignKey[_one2manyTextifyCount - 1]).Add("tableName", _globalTextifyOneToManyTableName[_one2manyTextifyCount - 1]).Add("filteredFieldName", _globalTextifyOneToManyFieldName[_one2manyTextifyCount - 1]).Add("isDeleted", _globalTextifyOneToManyIsDeletedName[_one2manyTextifyCount - 1]));
                    	  }

                    	}
                    }
                    break;
                case 51 :
                    // Output\\FiltersLanguageGrammar.g:788:6: parametersConstOneToMany internalopN2M valStr
                    {
                    	PushFollow(FOLLOW_parametersConstOneToMany_in_paramexpr4269);
                    	parametersConstOneToMany();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	PushFollow(FOLLOW_internalopN2M_in_paramexpr4271);
                    	internalopN2M135 = internalopN2M();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	PushFollow(FOLLOW_valStr_in_paramexpr4273);
                    	valStr134 = valStr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  					_one2manyConstCount++;
                    	  					_globalConstPrimaryIDList.Add(ExtractOneToManyModuleAndField(_filterText, _paramExpr, _dictionaryConstOneToManyPrimaryCompareKey));
                    	  					_globalConstOneToManyForeignKey.Add(ExtractOneToManyModuleAndField(_filterText, _paramExpr, _dictionaryConstOneToManyForeignKeyName));
                    	  					_globalConstOneToManyTableName.Add(ExtractOneToManyModuleAndField(_filterText, _paramExpr, _dictionaryConstOneToManyTableName));
                    	  					_globalConstOneToManyFieldName.Add(ExtractOneToManyModuleAndField(_filterText, _paramExpr, _dictionaryConstOneToManyTextFieldName));
                    	  					_globalConstOneToManyIsDeletedName.Add(ExtractOneToManyModuleAndField(_filterText, _paramExpr, _dictionaryConstOneToManyIsDeletedName));
                    	  					_globalConstOneToManyConstColumnName.Add(ExtractOneToManyModuleAndField(_filterText, _paramExpr, _dictionaryConstOneToManyConstColumnName));
                    	  					_globalConstOneToManyConstIntValue.Add(ExtractOneToManyModuleAndFieldInt(_filterText, _paramExpr, _dictionaryConstOneToManyConstIntValue));
                    	  				
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 798:7: -> const_one_to_many(val=$valStr.stop=$internalopN2M.stprimid=_globalConstPrimaryIDList[_one2manyConstCount - 1]foreignKey=_globalConstOneToManyForeignKey[_one2manyConstCount - 1]tableName=_globalConstOneToManyTableName[_one2manyConstCount - 1]filteredFieldName=_globalConstOneToManyFieldName[_one2manyConstCount - 1]isDeleted=_globalConstOneToManyIsDeletedName[_one2manyConstCount - 1]constColumnName=_globalConstOneToManyConstColumnName[_one2manyConstCount - 1]constIntValue=_globalConstOneToManyConstIntValue[_one2manyConstCount - 1])
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("const_one_to_many",
                    	    new STAttrMap().Add("val", ((valStr134 != null) ? valStr134.ST : null)).Add("op", ((internalopN2M135 != null) ? internalopN2M135.ST : null)).Add("primid", _globalConstPrimaryIDList[_one2manyConstCount - 1]).Add("foreignKey", _globalConstOneToManyForeignKey[_one2manyConstCount - 1]).Add("tableName", _globalConstOneToManyTableName[_one2manyConstCount - 1]).Add("filteredFieldName", _globalConstOneToManyFieldName[_one2manyConstCount - 1]).Add("isDeleted", _globalConstOneToManyIsDeletedName[_one2manyConstCount - 1]).Add("constColumnName", _globalConstOneToManyConstColumnName[_one2manyConstCount - 1]).Add("constIntValue", _globalConstOneToManyConstIntValue[_one2manyConstCount - 1]));
                    	  }

                    	}
                    }
                    break;
                case 52 :
                    // Output\\FiltersLanguageGrammar.g:806:6: parametersConstOneToMany internalopNotEqN2M valStr
                    {
                    	PushFollow(FOLLOW_parametersConstOneToMany_in_paramexpr4424);
                    	parametersConstOneToMany();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	PushFollow(FOLLOW_internalopNotEqN2M_in_paramexpr4426);
                    	internalopNotEqN2M();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	PushFollow(FOLLOW_valStr_in_paramexpr4428);
                    	valStr136 = valStr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  					_one2manyConstCount++;
                    	  					_globalConstPrimaryIDList.Add(ExtractOneToManyModuleAndField(_filterText, _paramExpr, _dictionaryConstOneToManyPrimaryCompareKey));
                    	  					_globalConstOneToManyForeignKey.Add(ExtractOneToManyModuleAndField(_filterText, _paramExpr, _dictionaryConstOneToManyForeignKeyName));
                    	  					_globalConstOneToManyTableName.Add(ExtractOneToManyModuleAndField(_filterText, _paramExpr, _dictionaryConstOneToManyTableName));
                    	  					_globalConstOneToManyFieldName.Add(ExtractOneToManyModuleAndField(_filterText, _paramExpr, _dictionaryConstOneToManyTextFieldName));
                    	  					_globalConstOneToManyIsDeletedName.Add(ExtractOneToManyModuleAndField(_filterText, _paramExpr, _dictionaryConstOneToManyIsDeletedName));
                    	  					_globalConstOneToManyConstColumnName.Add(ExtractOneToManyModuleAndField(_filterText, _paramExpr, _dictionaryConstOneToManyConstColumnName));
                    	  					_globalConstOneToManyConstIntValue.Add(ExtractOneToManyModuleAndFieldInt(_filterText, _paramExpr, _dictionaryConstOneToManyConstIntValue));
                    	  				
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 816:7: -> const_one_to_many_not(val=$valStr.stprimid=_globalConstPrimaryIDList[_one2manyConstCount - 1]foreignKey=_globalConstOneToManyForeignKey[_one2manyConstCount - 1]tableName=_globalConstOneToManyTableName[_one2manyConstCount - 1]filteredFieldName=_globalConstOneToManyFieldName[_one2manyConstCount - 1]isDeleted=_globalConstOneToManyIsDeletedName[_one2manyConstCount - 1]constColumnName=_globalConstOneToManyConstColumnName[_one2manyConstCount - 1]constIntValue=_globalConstOneToManyConstIntValue[_one2manyConstCount - 1])
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("const_one_to_many_not",
                    	    new STAttrMap().Add("val", ((valStr136 != null) ? valStr136.ST : null)).Add("primid", _globalConstPrimaryIDList[_one2manyConstCount - 1]).Add("foreignKey", _globalConstOneToManyForeignKey[_one2manyConstCount - 1]).Add("tableName", _globalConstOneToManyTableName[_one2manyConstCount - 1]).Add("filteredFieldName", _globalConstOneToManyFieldName[_one2manyConstCount - 1]).Add("isDeleted", _globalConstOneToManyIsDeletedName[_one2manyConstCount - 1]).Add("constColumnName", _globalConstOneToManyConstColumnName[_one2manyConstCount - 1]).Add("constIntValue", _globalConstOneToManyConstIntValue[_one2manyConstCount - 1]));
                    	  }

                    	}
                    }
                    break;
                case 53 :
                    // Output\\FiltersLanguageGrammar.g:824:6: parametersTableMappedOneToMany internalopN2M valStr
                    {
                    	PushFollow(FOLLOW_parametersTableMappedOneToMany_in_paramexpr4579);
                    	parametersTableMappedOneToMany();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	PushFollow(FOLLOW_internalopN2M_in_paramexpr4581);
                    	internalopN2M138 = internalopN2M();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	PushFollow(FOLLOW_valStr_in_paramexpr4583);
                    	valStr137 = valStr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  					_one2manyTableMappedCount++;
                    	  					_globalTableMappedPrimaryIDList.Add(ExtractOneToManyModuleAndField(_filterText, _paramExpr, _dictionaryTableMappedOneToManyPrimaryCompareKey));
                    	  					_globalTableMappedOneToManyForeignKey.Add(ExtractOneToManyModuleAndField(_filterText, _paramExpr, _dictionaryTableMappedOneToManyForeignKeyName));
                    	  					_globalTableMappedOneToManyTableName.Add(ExtractOneToManyModuleAndField(_filterText, _paramExpr, _dictionaryTableMappedOneToManyTableName));
                    	  					_globalTableMappedOneToManyFieldName.Add(ExtractOneToManyModuleAndField(_filterText, _paramExpr, _dictionaryTableMappedOneToManyTextFieldName));
                    	  					_globalTableMappedOneToManySecondTableName.Add(ExtractOneToManyModuleAndField(_filterText, _paramExpr, _dictionaryTableMappedOneToManySecondTableName));
                    	  					_globalTableMappedOneToManySecondTablePrimaryKey.Add(ExtractOneToManyModuleAndField(_filterText, _paramExpr, _dictionaryTableMappedOneToManySecondTablePrimaryKey));
                    	  					_globalTableMappedOneToManySecondTableForeignKey.Add(ExtractOneToManyModuleAndField(_filterText, _paramExpr, _dictionaryTableMappedOneToManyFirstTableForeignKey));
                    	  				
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 834:7: -> table_mapped_one_to_many(val=$valStr.stop=$internalopN2M.stprimid=_globalTableMappedPrimaryIDList[_one2manyTableMappedCount - 1]foreignKey=_globalTableMappedOneToManyForeignKey[_one2manyTableMappedCount - 1]tableName=_globalTableMappedOneToManyTableName[_one2manyTableMappedCount - 1]filteredFieldName=_globalTableMappedOneToManyFieldName[_one2manyTableMappedCount - 1]secondTableName=_globalTableMappedOneToManySecondTableName[_one2manyTableMappedCount - 1]secondTablePK=_globalTableMappedOneToManySecondTablePrimaryKey[_one2manyTableMappedCount - 1]secondTableFK=_globalTableMappedOneToManySecondTableForeignKey[_one2manyTableMappedCount - 1])
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("table_mapped_one_to_many",
                    	    new STAttrMap().Add("val", ((valStr137 != null) ? valStr137.ST : null)).Add("op", ((internalopN2M138 != null) ? internalopN2M138.ST : null)).Add("primid", _globalTableMappedPrimaryIDList[_one2manyTableMappedCount - 1]).Add("foreignKey", _globalTableMappedOneToManyForeignKey[_one2manyTableMappedCount - 1]).Add("tableName", _globalTableMappedOneToManyTableName[_one2manyTableMappedCount - 1]).Add("filteredFieldName", _globalTableMappedOneToManyFieldName[_one2manyTableMappedCount - 1]).Add("secondTableName", _globalTableMappedOneToManySecondTableName[_one2manyTableMappedCount - 1]).Add("secondTablePK", _globalTableMappedOneToManySecondTablePrimaryKey[_one2manyTableMappedCount - 1]).Add("secondTableFK", _globalTableMappedOneToManySecondTableForeignKey[_one2manyTableMappedCount - 1]));
                    	  }

                    	}
                    }
                    break;
                case 54 :
                    // Output\\FiltersLanguageGrammar.g:842:6: parametersTableMappedOneToMany internalopNotEqN2M valStr
                    {
                    	PushFollow(FOLLOW_parametersTableMappedOneToMany_in_paramexpr4748);
                    	parametersTableMappedOneToMany();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	PushFollow(FOLLOW_internalopNotEqN2M_in_paramexpr4750);
                    	internalopNotEqN2M();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	PushFollow(FOLLOW_valStr_in_paramexpr4752);
                    	valStr139 = valStr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  					_one2manyTableMappedCount++;
                    	  					_globalTableMappedPrimaryIDList.Add(ExtractOneToManyModuleAndField(_filterText, _paramExpr, _dictionaryTableMappedOneToManyPrimaryCompareKey));
                    	  					_globalTableMappedOneToManyForeignKey.Add(ExtractOneToManyModuleAndField(_filterText, _paramExpr, _dictionaryTableMappedOneToManyForeignKeyName));
                    	  					_globalTableMappedOneToManyTableName.Add(ExtractOneToManyModuleAndField(_filterText, _paramExpr, _dictionaryTableMappedOneToManyTableName));
                    	  					_globalTableMappedOneToManyFieldName.Add(ExtractOneToManyModuleAndField(_filterText, _paramExpr, _dictionaryTableMappedOneToManyTextFieldName));
                    	  					_globalTableMappedOneToManySecondTableName.Add(ExtractOneToManyModuleAndField(_filterText, _paramExpr, _dictionaryTableMappedOneToManySecondTableName));
                    	  					_globalTableMappedOneToManySecondTablePrimaryKey.Add(ExtractOneToManyModuleAndField(_filterText, _paramExpr, _dictionaryTableMappedOneToManySecondTablePrimaryKey));
                    	  					_globalTableMappedOneToManySecondTableForeignKey.Add(ExtractOneToManyModuleAndField(_filterText, _paramExpr, _dictionaryTableMappedOneToManyFirstTableForeignKey));
                    	  				
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 852:7: -> table_mapped_one_to_many_not(val=$valStr.stprimid=_globalTableMappedPrimaryIDList[_one2manyTableMappedCount - 1]foreignKey=_globalTableMappedOneToManyForeignKey[_one2manyTableMappedCount - 1]tableName=_globalTableMappedOneToManyTableName[_one2manyTableMappedCount - 1]filteredFieldName=_globalTableMappedOneToManyFieldName[_one2manyTableMappedCount - 1]secondTableName=_globalTableMappedOneToManySecondTableName[_one2manyTableMappedCount - 1]secondTablePK=_globalTableMappedOneToManySecondTablePrimaryKey[_one2manyTableMappedCount - 1]secondTableFK=_globalTableMappedOneToManySecondTableForeignKey[_one2manyTableMappedCount - 1])
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("table_mapped_one_to_many_not",
                    	    new STAttrMap().Add("val", ((valStr139 != null) ? valStr139.ST : null)).Add("primid", _globalTableMappedPrimaryIDList[_one2manyTableMappedCount - 1]).Add("foreignKey", _globalTableMappedOneToManyForeignKey[_one2manyTableMappedCount - 1]).Add("tableName", _globalTableMappedOneToManyTableName[_one2manyTableMappedCount - 1]).Add("filteredFieldName", _globalTableMappedOneToManyFieldName[_one2manyTableMappedCount - 1]).Add("secondTableName", _globalTableMappedOneToManySecondTableName[_one2manyTableMappedCount - 1]).Add("secondTablePK", _globalTableMappedOneToManySecondTablePrimaryKey[_one2manyTableMappedCount - 1]).Add("secondTableFK", _globalTableMappedOneToManySecondTableForeignKey[_one2manyTableMappedCount - 1]));
                    	  }

                    	}
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "paramexpr"

    public class valInt_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "valInt"
    // Output\\FiltersLanguageGrammar.g:865:1: valInt : (a= STRING -> intvalue(value=_tempInt) | INT -> intvalue(value=$INT.text));
    public FiltersLanguageGrammarParser.valInt_return valInt() // throws RecognitionException [1]
    {   
        FiltersLanguageGrammarParser.valInt_return retval = new FiltersLanguageGrammarParser.valInt_return();
        retval.Start = input.LT(1);

        IToken a = null;
        IToken INT140 = null;

        try 
    	{
            // Output\\FiltersLanguageGrammar.g:865:9: (a= STRING -> intvalue(value=_tempInt) | INT -> intvalue(value=$INT.text))
            int alt22 = 2;
            int LA22_0 = input.LA(1);

            if ( (LA22_0 == STRING) )
            {
                alt22 = 1;
            }
            else if ( (LA22_0 == INT) )
            {
                alt22 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d22s0 =
                    new NoViableAltException("", 22, 0, input);

                throw nvae_d22s0;
            }
            switch (alt22) 
            {
                case 1 :
                    // Output\\FiltersLanguageGrammar.g:865:11: a= STRING
                    {
                    	a=(IToken)Match(input,STRING,FOLLOW_STRING_in_valInt4933); if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  					a.Text = a.Text.Replace("'", "''");
                    	  					a.Text = a.Text.Replace("\"", "");

                    	  					bool result = int.TryParse(a.Text, out _tempInt);

                    	  					if (!result)
                    	  					{
                    	  						throw new ArgumentException("Invalid integer value.");
                    	  					}
                    	  				
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 876:21: -> intvalue(value=_tempInt)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("intvalue",
                    	    new STAttrMap().Add("value", _tempInt));
                    	  }

                    	}
                    }
                    break;
                case 2 :
                    // Output\\FiltersLanguageGrammar.g:877:6: INT
                    {
                    	INT140=(IToken)Match(input,INT,FOLLOW_INT_in_valInt4971); if (state.failed) return retval;


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 877:24: -> intvalue(value=$INT.text)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("intvalue",
                    	    new STAttrMap().Add("value", ((INT140 != null) ? INT140.Text : null)));
                    	  }

                    	}
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "valInt"

    public class valBool_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "valBool"
    // Output\\FiltersLanguageGrammar.g:880:1: valBool : boolToken -> othervalue(value=$boolToken.st);
    public FiltersLanguageGrammarParser.valBool_return valBool() // throws RecognitionException [1]
    {   
        FiltersLanguageGrammarParser.valBool_return retval = new FiltersLanguageGrammarParser.valBool_return();
        retval.Start = input.LT(1);

        FiltersLanguageGrammarParser.boolToken_return boolToken141 = default(FiltersLanguageGrammarParser.boolToken_return);


        try 
    	{
            // Output\\FiltersLanguageGrammar.g:880:10: ( boolToken -> othervalue(value=$boolToken.st))
            // Output\\FiltersLanguageGrammar.g:880:12: boolToken
            {
            	PushFollow(FOLLOW_boolToken_in_valBool5009);
            	boolToken141 = boolToken();
            	state.followingStackPointer--;
            	if (state.failed) return retval;


            	// TEMPLATE REWRITE
            	if ( (state.backtracking==0) )
            	{
            	  // 880:34: -> othervalue(value=$boolToken.st)
            	  {
            	      retval.ST = templateLib.GetInstanceOf("othervalue",
            	    new STAttrMap().Add("value", ((boolToken141 != null) ? boolToken141.ST : null)));
            	  }

            	}
            }

            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "valBool"

    public class query_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "query"
    // Output\\FiltersLanguageGrammar.g:883:1: query : a= STRING -> strvalue(value=$STRING.text);
    public FiltersLanguageGrammarParser.query_return query() // throws RecognitionException [1]
    {   
        FiltersLanguageGrammarParser.query_return retval = new FiltersLanguageGrammarParser.query_return();
        retval.Start = input.LT(1);

        IToken a = null;

        try 
    	{
            // Output\\FiltersLanguageGrammar.g:883:8: (a= STRING -> strvalue(value=$STRING.text))
            // Output\\FiltersLanguageGrammar.g:883:10: a= STRING
            {
            	a=(IToken)Match(input,STRING,FOLLOW_STRING_in_query5049); if (state.failed) return retval;
            	if ( (state.backtracking==0) )
            	{

            	  					// Always insert ROW_NUMBER() after select phrase...
            	  					a.Text = a.Text.Insert(8, "ROW_NUMBER() OVER(ORDER BY NoteID DESC) AS RowNum,");
            	  					a.Text = a.Text.Replace("\"", "");
            	  				
            	}


            	// TEMPLATE REWRITE
            	if ( (state.backtracking==0) )
            	{
            	  // 888:21: -> strvalue(value=$STRING.text)
            	  {
            	      retval.ST = templateLib.GetInstanceOf("strvalue",
            	    new STAttrMap().Add("value", ((a != null) ? a.Text : null)));
            	  }

            	}
            }

            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "query"

    public class valStr_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "valStr"
    // Output\\FiltersLanguageGrammar.g:891:1: valStr : a= STRING -> strvalue(value=$STRING.text);
    public FiltersLanguageGrammarParser.valStr_return valStr() // throws RecognitionException [1]
    {   
        FiltersLanguageGrammarParser.valStr_return retval = new FiltersLanguageGrammarParser.valStr_return();
        retval.Start = input.LT(1);

        IToken a = null;

        try 
    	{
            // Output\\FiltersLanguageGrammar.g:891:9: (a= STRING -> strvalue(value=$STRING.text))
            // Output\\FiltersLanguageGrammar.g:891:11: a= STRING
            {
            	a=(IToken)Match(input,STRING,FOLLOW_STRING_in_valStr5097); if (state.failed) return retval;
            	if ( (state.backtracking==0) )
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
            	  				
            	}


            	// TEMPLATE REWRITE
            	if ( (state.backtracking==0) )
            	{
            	  // 903:21: -> strvalue(value=$STRING.text)
            	  {
            	      retval.ST = templateLib.GetInstanceOf("strvalue",
            	    new STAttrMap().Add("value", ((a != null) ? a.Text : null)));
            	  }

            	}
            }

            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "valStr"

    public class valLongStr_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "valLongStr"
    // Output\\FiltersLanguageGrammar.g:906:1: valLongStr : a= STRING -> longstrvalue(value=$STRING.text);
    public FiltersLanguageGrammarParser.valLongStr_return valLongStr() // throws RecognitionException [1]
    {   
        FiltersLanguageGrammarParser.valLongStr_return retval = new FiltersLanguageGrammarParser.valLongStr_return();
        retval.Start = input.LT(1);

        IToken a = null;

        try 
    	{
            // Output\\FiltersLanguageGrammar.g:906:12: (a= STRING -> longstrvalue(value=$STRING.text))
            // Output\\FiltersLanguageGrammar.g:906:14: a= STRING
            {
            	a=(IToken)Match(input,STRING,FOLLOW_STRING_in_valLongStr5144); if (state.failed) return retval;
            	if ( (state.backtracking==0) )
            	{

            	  					a.Text = a.Text.Replace("'", "''");
            	  					a.Text = a.Text.Replace("\"", "");										
            	  				
            	}


            	// TEMPLATE REWRITE
            	if ( (state.backtracking==0) )
            	{
            	  // 910:21: -> longstrvalue(value=$STRING.text)
            	  {
            	      retval.ST = templateLib.GetInstanceOf("longstrvalue",
            	    new STAttrMap().Add("value", ((a != null) ? a.Text : null)));
            	  }

            	}
            }

            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "valLongStr"

    public class valDate_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "valDate"
    // Output\\FiltersLanguageGrammar.g:913:1: valDate : (a= '\"now\"' -> datevalue(value=$a.text) | a= 'now' -> datevalue(value=$a.text) | a= 'today' -> datevalue(value=$a.text) | a= '\"today\"' -> datevalue(value=$a.text) | a= 'yesterday' -> datevalue(value=$a.text) | a= '\"yesterday\"' -> datevalue(value=$a.text) | a= 'tomorrow' -> datevalue(value=$a.text) | a= '\"tomorrow\"' -> datevalue(value=$a.text) | a= STRING -> datevalue(value=_tempDateTime) | a= DATE -> datevalue(value=$a.text));
    public FiltersLanguageGrammarParser.valDate_return valDate() // throws RecognitionException [1]
    {   
        FiltersLanguageGrammarParser.valDate_return retval = new FiltersLanguageGrammarParser.valDate_return();
        retval.Start = input.LT(1);

        IToken a = null;

        try 
    	{
            // Output\\FiltersLanguageGrammar.g:913:10: (a= '\"now\"' -> datevalue(value=$a.text) | a= 'now' -> datevalue(value=$a.text) | a= 'today' -> datevalue(value=$a.text) | a= '\"today\"' -> datevalue(value=$a.text) | a= 'yesterday' -> datevalue(value=$a.text) | a= '\"yesterday\"' -> datevalue(value=$a.text) | a= 'tomorrow' -> datevalue(value=$a.text) | a= '\"tomorrow\"' -> datevalue(value=$a.text) | a= STRING -> datevalue(value=_tempDateTime) | a= DATE -> datevalue(value=$a.text))
            int alt23 = 10;
            switch ( input.LA(1) ) 
            {
            case 19:
            	{
                alt23 = 1;
                }
                break;
            case 20:
            	{
                alt23 = 2;
                }
                break;
            case 21:
            	{
                alt23 = 3;
                }
                break;
            case 22:
            	{
                alt23 = 4;
                }
                break;
            case 23:
            	{
                alt23 = 5;
                }
                break;
            case 24:
            	{
                alt23 = 6;
                }
                break;
            case 25:
            	{
                alt23 = 7;
                }
                break;
            case 26:
            	{
                alt23 = 8;
                }
                break;
            case STRING:
            	{
                alt23 = 9;
                }
                break;
            case DATE:
            	{
                alt23 = 10;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d23s0 =
            	        new NoViableAltException("", 23, 0, input);

            	    throw nvae_d23s0;
            }

            switch (alt23) 
            {
                case 1 :
                    // Output\\FiltersLanguageGrammar.g:913:12: a= '\"now\"'
                    {
                    	a=(IToken)Match(input,19,FOLLOW_19_in_valDate5192); if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  					a.Text = DateTime.Now.ToString("yyyy-MM-dd");	
                    	  				
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 916:21: -> datevalue(value=$a.text)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("datevalue",
                    	    new STAttrMap().Add("value", ((a != null) ? a.Text : null)));
                    	  }

                    	}
                    }
                    break;
                case 2 :
                    // Output\\FiltersLanguageGrammar.g:917:6: a= 'now'
                    {
                    	a=(IToken)Match(input,20,FOLLOW_20_in_valDate5234); if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  					a.Text = DateTime.Now.ToString("yyyy-MM-dd");	
                    	  				
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 920:21: -> datevalue(value=$a.text)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("datevalue",
                    	    new STAttrMap().Add("value", ((a != null) ? a.Text : null)));
                    	  }

                    	}
                    }
                    break;
                case 3 :
                    // Output\\FiltersLanguageGrammar.g:921:6: a= 'today'
                    {
                    	a=(IToken)Match(input,21,FOLLOW_21_in_valDate5276); if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  					a.Text = DateTime.Now.ToString("yyyy-MM-dd");	
                    	  				
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 924:21: -> datevalue(value=$a.text)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("datevalue",
                    	    new STAttrMap().Add("value", ((a != null) ? a.Text : null)));
                    	  }

                    	}
                    }
                    break;
                case 4 :
                    // Output\\FiltersLanguageGrammar.g:925:6: a= '\"today\"'
                    {
                    	a=(IToken)Match(input,22,FOLLOW_22_in_valDate5318); if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  					a.Text = DateTime.Now.ToString("yyyy-MM-dd");	
                    	  				
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 928:21: -> datevalue(value=$a.text)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("datevalue",
                    	    new STAttrMap().Add("value", ((a != null) ? a.Text : null)));
                    	  }

                    	}
                    }
                    break;
                case 5 :
                    // Output\\FiltersLanguageGrammar.g:929:6: a= 'yesterday'
                    {
                    	a=(IToken)Match(input,23,FOLLOW_23_in_valDate5360); if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  					a.Text = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd");
                    	  				
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 932:21: -> datevalue(value=$a.text)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("datevalue",
                    	    new STAttrMap().Add("value", ((a != null) ? a.Text : null)));
                    	  }

                    	}
                    }
                    break;
                case 6 :
                    // Output\\FiltersLanguageGrammar.g:933:6: a= '\"yesterday\"'
                    {
                    	a=(IToken)Match(input,24,FOLLOW_24_in_valDate5402); if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  					a.Text = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd");
                    	  				
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 936:21: -> datevalue(value=$a.text)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("datevalue",
                    	    new STAttrMap().Add("value", ((a != null) ? a.Text : null)));
                    	  }

                    	}
                    }
                    break;
                case 7 :
                    // Output\\FiltersLanguageGrammar.g:937:6: a= 'tomorrow'
                    {
                    	a=(IToken)Match(input,25,FOLLOW_25_in_valDate5444); if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  					a.Text = DateTime.Now.AddDays(1).ToString("yyyy-MM-dd");
                    	  				
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 940:21: -> datevalue(value=$a.text)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("datevalue",
                    	    new STAttrMap().Add("value", ((a != null) ? a.Text : null)));
                    	  }

                    	}
                    }
                    break;
                case 8 :
                    // Output\\FiltersLanguageGrammar.g:941:6: a= '\"tomorrow\"'
                    {
                    	a=(IToken)Match(input,26,FOLLOW_26_in_valDate5486); if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  					a.Text = DateTime.Now.AddDays(1).ToString("yyyy-MM-dd");
                    	  				
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 944:21: -> datevalue(value=$a.text)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("datevalue",
                    	    new STAttrMap().Add("value", ((a != null) ? a.Text : null)));
                    	  }

                    	}
                    }
                    break;
                case 9 :
                    // Output\\FiltersLanguageGrammar.g:945:6: a= STRING
                    {
                    	a=(IToken)Match(input,STRING,FOLLOW_STRING_in_valDate5528); if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
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
                    	  				
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 976:21: -> datevalue(value=_tempDateTime)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("datevalue",
                    	    new STAttrMap().Add("value", _tempDateTime));
                    	  }

                    	}
                    }
                    break;
                case 10 :
                    // Output\\FiltersLanguageGrammar.g:977:6: a= DATE
                    {
                    	a=(IToken)Match(input,DATE,FOLLOW_DATE_in_valDate5570); if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  					a.Text = Convert.ToDateTime(a.Text, new System.Globalization.CultureInfo("pl-PL")).ToString("yyyy-MM-dd");
                    	  				
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 980:21: -> datevalue(value=$a.text)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("datevalue",
                    	    new STAttrMap().Add("value", ((a != null) ? a.Text : null)));
                    	  }

                    	}
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "valDate"

    public class valDateSpanLs_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "valDateSpanLs"
    // Output\\FiltersLanguageGrammar.g:983:1: valDateSpanLs : (a= 'lastweek' -> datevalue(value=$a.text) | a= '\"lastweek\"' -> datevalue(value=$a.text) | a= 'lastmonth' -> datevalue(value=$a.text) | a= '\"lastmonth\"' -> datevalue(value=$a.text) | a= 'thisweek' -> datevalue(value=$a.text) | a= '\"thisweek\"' -> datevalue(value=$a.text) | a= 'thismonth' -> datevalue(value=$a.text) | a= '\"thismonth\"' -> datevalue(value=$a.text));
    public FiltersLanguageGrammarParser.valDateSpanLs_return valDateSpanLs() // throws RecognitionException [1]
    {   
        FiltersLanguageGrammarParser.valDateSpanLs_return retval = new FiltersLanguageGrammarParser.valDateSpanLs_return();
        retval.Start = input.LT(1);

        IToken a = null;

        try 
    	{
            // Output\\FiltersLanguageGrammar.g:983:15: (a= 'lastweek' -> datevalue(value=$a.text) | a= '\"lastweek\"' -> datevalue(value=$a.text) | a= 'lastmonth' -> datevalue(value=$a.text) | a= '\"lastmonth\"' -> datevalue(value=$a.text) | a= 'thisweek' -> datevalue(value=$a.text) | a= '\"thisweek\"' -> datevalue(value=$a.text) | a= 'thismonth' -> datevalue(value=$a.text) | a= '\"thismonth\"' -> datevalue(value=$a.text))
            int alt24 = 8;
            switch ( input.LA(1) ) 
            {
            case 27:
            	{
                alt24 = 1;
                }
                break;
            case 28:
            	{
                alt24 = 2;
                }
                break;
            case 29:
            	{
                alt24 = 3;
                }
                break;
            case 30:
            	{
                alt24 = 4;
                }
                break;
            case 31:
            	{
                alt24 = 5;
                }
                break;
            case 32:
            	{
                alt24 = 6;
                }
                break;
            case 33:
            	{
                alt24 = 7;
                }
                break;
            case 34:
            	{
                alt24 = 8;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d24s0 =
            	        new NoViableAltException("", 24, 0, input);

            	    throw nvae_d24s0;
            }

            switch (alt24) 
            {
                case 1 :
                    // Output\\FiltersLanguageGrammar.g:983:17: a= 'lastweek'
                    {
                    	a=(IToken)Match(input,27,FOLLOW_27_in_valDateSpanLs5617); if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  						DateTime start = DateTime.Now;
                    	  						DateTime _startDate = DateTime.MinValue;
                    	  						DateTime _endDate = DateTime.MaxValue;

                    	  						GetDates(ref _startDate, ref _endDate, start);

                    	  						a.Text = _startDate.ToString("yyyy-MM-dd");
                    	  					
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 992:22: -> datevalue(value=$a.text)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("datevalue",
                    	    new STAttrMap().Add("value", ((a != null) ? a.Text : null)));
                    	  }

                    	}
                    }
                    break;
                case 2 :
                    // Output\\FiltersLanguageGrammar.g:993:7: a= '\"lastweek\"'
                    {
                    	a=(IToken)Match(input,28,FOLLOW_28_in_valDateSpanLs5661); if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  						DateTime start = DateTime.Now;
                    	  						DateTime _startDate = DateTime.MinValue;
                    	  						DateTime _endDate = DateTime.MaxValue;

                    	  						GetDates(ref _startDate, ref _endDate, start);

                    	  						a.Text = _startDate.ToString("yyyy-MM-dd");
                    	  					
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1002:22: -> datevalue(value=$a.text)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("datevalue",
                    	    new STAttrMap().Add("value", ((a != null) ? a.Text : null)));
                    	  }

                    	}
                    }
                    break;
                case 3 :
                    // Output\\FiltersLanguageGrammar.g:1003:7: a= 'lastmonth'
                    {
                    	a=(IToken)Match(input,29,FOLLOW_29_in_valDateSpanLs5705); if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  						DateTime start = DateTime.Now;
                    	  	
                    	  						a.Text = new DateTime(start.Year, start.Month - 1, 1, 1, 0, 0).ToString("yyyy-MM-dd");

                    	  					
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1009:22: -> datevalue(value=$a.text)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("datevalue",
                    	    new STAttrMap().Add("value", ((a != null) ? a.Text : null)));
                    	  }

                    	}
                    }
                    break;
                case 4 :
                    // Output\\FiltersLanguageGrammar.g:1010:7: a= '\"lastmonth\"'
                    {
                    	a=(IToken)Match(input,30,FOLLOW_30_in_valDateSpanLs5749); if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  						DateTime start = DateTime.Now;

                    	  						a.Text = new DateTime(start.Year, start.Month - 1, 1, 1, 0, 0).ToString("yyyy-MM-dd");

                    	  					
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1016:22: -> datevalue(value=$a.text)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("datevalue",
                    	    new STAttrMap().Add("value", ((a != null) ? a.Text : null)));
                    	  }

                    	}
                    }
                    break;
                case 5 :
                    // Output\\FiltersLanguageGrammar.g:1017:7: a= 'thisweek'
                    {
                    	a=(IToken)Match(input,31,FOLLOW_31_in_valDateSpanLs5793); if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  						DateTime start = DateTime.Now.AddDays(7);
                    	  						DateTime _startDate = DateTime.MinValue;
                    	  						DateTime _endDate = DateTime.MaxValue;

                    	  						GetDates(ref _startDate, ref _endDate, start);

                    	  						a.Text = _startDate.ToString("yyyy-MM-dd");
                    	  					
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1026:22: -> datevalue(value=$a.text)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("datevalue",
                    	    new STAttrMap().Add("value", ((a != null) ? a.Text : null)));
                    	  }

                    	}
                    }
                    break;
                case 6 :
                    // Output\\FiltersLanguageGrammar.g:1027:7: a= '\"thisweek\"'
                    {
                    	a=(IToken)Match(input,32,FOLLOW_32_in_valDateSpanLs5837); if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  						DateTime start = DateTime.Now.AddDays(7);
                    	  						DateTime _startDate = DateTime.MinValue;
                    	  						DateTime _endDate = DateTime.MaxValue;

                    	  						GetDates(ref _startDate, ref _endDate, start);

                    	  						a.Text = _startDate.ToString("yyyy-MM-dd");
                    	  					
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1036:22: -> datevalue(value=$a.text)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("datevalue",
                    	    new STAttrMap().Add("value", ((a != null) ? a.Text : null)));
                    	  }

                    	}
                    }
                    break;
                case 7 :
                    // Output\\FiltersLanguageGrammar.g:1037:7: a= 'thismonth'
                    {
                    	a=(IToken)Match(input,33,FOLLOW_33_in_valDateSpanLs5881); if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  						DateTime start = DateTime.Now;							
                    	  						a.Text = new DateTime(start.Year, start.Month, 1, 1, 0, 0).ToString("yyyy-MM-dd");
                    	  					
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1041:22: -> datevalue(value=$a.text)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("datevalue",
                    	    new STAttrMap().Add("value", ((a != null) ? a.Text : null)));
                    	  }

                    	}
                    }
                    break;
                case 8 :
                    // Output\\FiltersLanguageGrammar.g:1042:7: a= '\"thismonth\"'
                    {
                    	a=(IToken)Match(input,34,FOLLOW_34_in_valDateSpanLs5925); if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  						DateTime start = DateTime.Now;							
                    	  						a.Text = new DateTime(start.Year, start.Month, 1, 1, 0, 0).ToString("yyyy-MM-dd");
                    	  					
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1046:22: -> datevalue(value=$a.text)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("datevalue",
                    	    new STAttrMap().Add("value", ((a != null) ? a.Text : null)));
                    	  }

                    	}
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "valDateSpanLs"

    public class valDateSpanLsOrEq_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "valDateSpanLsOrEq"
    // Output\\FiltersLanguageGrammar.g:1049:1: valDateSpanLsOrEq : (a= 'lastweek' -> datevalue(value=$a.text) | a= '\"lastweek\"' -> datevalue(value=$a.text) | a= 'lastmonth' -> datevalue(value=$a.text) | a= '\"lastmonth\"' -> datevalue(value=$a.text) | a= 'thisweek' -> datevalue(value=$a.text) | a= '\"thisweek\"' -> datevalue(value=$a.text) | a= 'thismonth' -> datevalue(value=$a.text) | a= '\"thismonth\"' -> datevalue(value=$a.text));
    public FiltersLanguageGrammarParser.valDateSpanLsOrEq_return valDateSpanLsOrEq() // throws RecognitionException [1]
    {   
        FiltersLanguageGrammarParser.valDateSpanLsOrEq_return retval = new FiltersLanguageGrammarParser.valDateSpanLsOrEq_return();
        retval.Start = input.LT(1);

        IToken a = null;

        try 
    	{
            // Output\\FiltersLanguageGrammar.g:1049:19: (a= 'lastweek' -> datevalue(value=$a.text) | a= '\"lastweek\"' -> datevalue(value=$a.text) | a= 'lastmonth' -> datevalue(value=$a.text) | a= '\"lastmonth\"' -> datevalue(value=$a.text) | a= 'thisweek' -> datevalue(value=$a.text) | a= '\"thisweek\"' -> datevalue(value=$a.text) | a= 'thismonth' -> datevalue(value=$a.text) | a= '\"thismonth\"' -> datevalue(value=$a.text))
            int alt25 = 8;
            switch ( input.LA(1) ) 
            {
            case 27:
            	{
                alt25 = 1;
                }
                break;
            case 28:
            	{
                alt25 = 2;
                }
                break;
            case 29:
            	{
                alt25 = 3;
                }
                break;
            case 30:
            	{
                alt25 = 4;
                }
                break;
            case 31:
            	{
                alt25 = 5;
                }
                break;
            case 32:
            	{
                alt25 = 6;
                }
                break;
            case 33:
            	{
                alt25 = 7;
                }
                break;
            case 34:
            	{
                alt25 = 8;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d25s0 =
            	        new NoViableAltException("", 25, 0, input);

            	    throw nvae_d25s0;
            }

            switch (alt25) 
            {
                case 1 :
                    // Output\\FiltersLanguageGrammar.g:1049:21: a= 'lastweek'
                    {
                    	a=(IToken)Match(input,27,FOLLOW_27_in_valDateSpanLsOrEq5974); if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  							DateTime start = DateTime.Now;
                    	  							DateTime _startDate = DateTime.MinValue;
                    	  							DateTime _endDate = DateTime.MaxValue;

                    	  							GetDates(ref _startDate, ref _endDate, start);

                    	  							a.Text = _endDate.ToString("yyyy-MM-dd");
                    	  						
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1058:23: -> datevalue(value=$a.text)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("datevalue",
                    	    new STAttrMap().Add("value", ((a != null) ? a.Text : null)));
                    	  }

                    	}
                    }
                    break;
                case 2 :
                    // Output\\FiltersLanguageGrammar.g:1059:8: a= '\"lastweek\"'
                    {
                    	a=(IToken)Match(input,28,FOLLOW_28_in_valDateSpanLsOrEq6020); if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  							DateTime start = DateTime.Now;
                    	  							DateTime _startDate = DateTime.MinValue;
                    	  							DateTime _endDate = DateTime.MaxValue;

                    	  							GetDates(ref _startDate, ref _endDate, start);

                    	  							a.Text = _endDate.ToString("yyyy-MM-dd");
                    	  						
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1068:23: -> datevalue(value=$a.text)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("datevalue",
                    	    new STAttrMap().Add("value", ((a != null) ? a.Text : null)));
                    	  }

                    	}
                    }
                    break;
                case 3 :
                    // Output\\FiltersLanguageGrammar.g:1069:8: a= 'lastmonth'
                    {
                    	a=(IToken)Match(input,29,FOLLOW_29_in_valDateSpanLsOrEq6066); if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  							DateTime start = DateTime.Now;

                    	  							a.Text = new DateTime(start.Year, start.Month - 1, 1, 1, 0, 0).ToString("yyyy-MM-dd");

                    	  						
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1075:23: -> datevalue(value=$a.text)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("datevalue",
                    	    new STAttrMap().Add("value", ((a != null) ? a.Text : null)));
                    	  }

                    	}
                    }
                    break;
                case 4 :
                    // Output\\FiltersLanguageGrammar.g:1076:8: a= '\"lastmonth\"'
                    {
                    	a=(IToken)Match(input,30,FOLLOW_30_in_valDateSpanLsOrEq6112); if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  							DateTime start = DateTime.Now;

                    	  							a.Text = new DateTime(start.Year, start.Month - 1, 1, 1, 0, 0).ToString("yyyy-MM-dd");

                    	  						
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1082:23: -> datevalue(value=$a.text)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("datevalue",
                    	    new STAttrMap().Add("value", ((a != null) ? a.Text : null)));
                    	  }

                    	}
                    }
                    break;
                case 5 :
                    // Output\\FiltersLanguageGrammar.g:1083:8: a= 'thisweek'
                    {
                    	a=(IToken)Match(input,31,FOLLOW_31_in_valDateSpanLsOrEq6158); if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  							DateTime start = DateTime.Now.AddDays(7);
                    	  							DateTime _startDate = DateTime.MinValue;
                    	  							DateTime _endDate = DateTime.MaxValue;

                    	  							GetDates(ref _startDate, ref _endDate, start);

                    	  							a.Text = _endDate.ToString("yyyy-MM-dd");
                    	  						
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1092:23: -> datevalue(value=$a.text)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("datevalue",
                    	    new STAttrMap().Add("value", ((a != null) ? a.Text : null)));
                    	  }

                    	}
                    }
                    break;
                case 6 :
                    // Output\\FiltersLanguageGrammar.g:1093:8: a= '\"thisweek\"'
                    {
                    	a=(IToken)Match(input,32,FOLLOW_32_in_valDateSpanLsOrEq6204); if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  							DateTime start = DateTime.Now.AddDays(7);
                    	  							DateTime _startDate = DateTime.MinValue;
                    	  							DateTime _endDate = DateTime.MaxValue;

                    	  							GetDates(ref _startDate, ref _endDate, start);

                    	  							a.Text = _endDate.ToString("yyyy-MM-dd");
                    	  						
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1102:23: -> datevalue(value=$a.text)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("datevalue",
                    	    new STAttrMap().Add("value", ((a != null) ? a.Text : null)));
                    	  }

                    	}
                    }
                    break;
                case 7 :
                    // Output\\FiltersLanguageGrammar.g:1103:8: a= 'thismonth'
                    {
                    	a=(IToken)Match(input,33,FOLLOW_33_in_valDateSpanLsOrEq6250); if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  							DateTime start = DateTime.Now;							
                    	  							a.Text = new DateTime(start.Year, start.Month, 1, 1, 0, 0).ToString("yyyy-MM-dd");
                    	  						
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1107:23: -> datevalue(value=$a.text)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("datevalue",
                    	    new STAttrMap().Add("value", ((a != null) ? a.Text : null)));
                    	  }

                    	}
                    }
                    break;
                case 8 :
                    // Output\\FiltersLanguageGrammar.g:1108:8: a= '\"thismonth\"'
                    {
                    	a=(IToken)Match(input,34,FOLLOW_34_in_valDateSpanLsOrEq6296); if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  							DateTime start = DateTime.Now;							
                    	  							a.Text = new DateTime(start.Year, start.Month, 1, 1, 0, 0).ToString("yyyy-MM-dd");
                    	  						
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1112:23: -> datevalue(value=$a.text)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("datevalue",
                    	    new STAttrMap().Add("value", ((a != null) ? a.Text : null)));
                    	  }

                    	}
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "valDateSpanLsOrEq"

    public class valDateSpanGr_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "valDateSpanGr"
    // Output\\FiltersLanguageGrammar.g:1115:1: valDateSpanGr : (a= 'lastweek' -> datevalue(value=$a.text) | a= '\"lastweek\"' -> datevalue(value=$a.text) | a= 'lastmonth' -> datevalue(value=$a.text) | a= '\"lastmonth\"' -> datevalue(value=$a.text) | a= 'thisweek' -> datevalue(value=$a.text) | a= '\"thisweek\"' -> datevalue(value=$a.text) | a= 'thismonth' -> datevalue(value=$a.text) | a= '\"thismonth\"' -> datevalue(value=$a.text));
    public FiltersLanguageGrammarParser.valDateSpanGr_return valDateSpanGr() // throws RecognitionException [1]
    {   
        FiltersLanguageGrammarParser.valDateSpanGr_return retval = new FiltersLanguageGrammarParser.valDateSpanGr_return();
        retval.Start = input.LT(1);

        IToken a = null;

        try 
    	{
            // Output\\FiltersLanguageGrammar.g:1115:15: (a= 'lastweek' -> datevalue(value=$a.text) | a= '\"lastweek\"' -> datevalue(value=$a.text) | a= 'lastmonth' -> datevalue(value=$a.text) | a= '\"lastmonth\"' -> datevalue(value=$a.text) | a= 'thisweek' -> datevalue(value=$a.text) | a= '\"thisweek\"' -> datevalue(value=$a.text) | a= 'thismonth' -> datevalue(value=$a.text) | a= '\"thismonth\"' -> datevalue(value=$a.text))
            int alt26 = 8;
            switch ( input.LA(1) ) 
            {
            case 27:
            	{
                alt26 = 1;
                }
                break;
            case 28:
            	{
                alt26 = 2;
                }
                break;
            case 29:
            	{
                alt26 = 3;
                }
                break;
            case 30:
            	{
                alt26 = 4;
                }
                break;
            case 31:
            	{
                alt26 = 5;
                }
                break;
            case 32:
            	{
                alt26 = 6;
                }
                break;
            case 33:
            	{
                alt26 = 7;
                }
                break;
            case 34:
            	{
                alt26 = 8;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d26s0 =
            	        new NoViableAltException("", 26, 0, input);

            	    throw nvae_d26s0;
            }

            switch (alt26) 
            {
                case 1 :
                    // Output\\FiltersLanguageGrammar.g:1115:17: a= 'lastweek'
                    {
                    	a=(IToken)Match(input,27,FOLLOW_27_in_valDateSpanGr6347); if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  						DateTime start = DateTime.Now;
                    	  						DateTime _startDate = DateTime.MinValue;
                    	  						DateTime _endDate = DateTime.MaxValue;

                    	  						GetDates(ref _startDate, ref _endDate, start);

                    	  						a.Text = _startDate.ToString("yyyy-MM-dd");
                    	  					
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1124:22: -> datevalue(value=$a.text)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("datevalue",
                    	    new STAttrMap().Add("value", ((a != null) ? a.Text : null)));
                    	  }

                    	}
                    }
                    break;
                case 2 :
                    // Output\\FiltersLanguageGrammar.g:1125:7: a= '\"lastweek\"'
                    {
                    	a=(IToken)Match(input,28,FOLLOW_28_in_valDateSpanGr6391); if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  						DateTime start = DateTime.Now;
                    	  						DateTime _startDate = DateTime.MinValue;
                    	  						DateTime _endDate = DateTime.MaxValue;

                    	  						GetDates(ref _startDate, ref _endDate, start);

                    	  						a.Text = _startDate.ToString("yyyy-MM-dd");
                    	  					
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1134:22: -> datevalue(value=$a.text)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("datevalue",
                    	    new STAttrMap().Add("value", ((a != null) ? a.Text : null)));
                    	  }

                    	}
                    }
                    break;
                case 3 :
                    // Output\\FiltersLanguageGrammar.g:1135:7: a= 'lastmonth'
                    {
                    	a=(IToken)Match(input,29,FOLLOW_29_in_valDateSpanGr6435); if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  						DateTime start = DateTime.Now;

                    	  						a.Text = new DateTime(start.Year, start.Month - 1, DateTime.DaysInMonth(start.Year, start.Month - 1), 1, 0, 0).ToString("yyyy-MM-dd");

                    	  					
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1141:22: -> datevalue(value=$a.text)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("datevalue",
                    	    new STAttrMap().Add("value", ((a != null) ? a.Text : null)));
                    	  }

                    	}
                    }
                    break;
                case 4 :
                    // Output\\FiltersLanguageGrammar.g:1142:7: a= '\"lastmonth\"'
                    {
                    	a=(IToken)Match(input,30,FOLLOW_30_in_valDateSpanGr6479); if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  						DateTime start = DateTime.Now;

                    	  						a.Text = new DateTime(start.Year, start.Month - 1, DateTime.DaysInMonth(start.Year, start.Month - 1), 1, 0, 0).ToString("yyyy-MM-dd");

                    	  					
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1148:22: -> datevalue(value=$a.text)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("datevalue",
                    	    new STAttrMap().Add("value", ((a != null) ? a.Text : null)));
                    	  }

                    	}
                    }
                    break;
                case 5 :
                    // Output\\FiltersLanguageGrammar.g:1149:7: a= 'thisweek'
                    {
                    	a=(IToken)Match(input,31,FOLLOW_31_in_valDateSpanGr6523); if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  						DateTime start = DateTime.Now.AddDays(7);
                    	  						DateTime _startDate = DateTime.MinValue;
                    	  						DateTime _endDate = DateTime.MaxValue;

                    	  						GetDates(ref _startDate, ref _endDate, start);

                    	  						a.Text = _startDate.ToString("yyyy-MM-dd");
                    	  					
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1158:22: -> datevalue(value=$a.text)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("datevalue",
                    	    new STAttrMap().Add("value", ((a != null) ? a.Text : null)));
                    	  }

                    	}
                    }
                    break;
                case 6 :
                    // Output\\FiltersLanguageGrammar.g:1159:7: a= '\"thisweek\"'
                    {
                    	a=(IToken)Match(input,32,FOLLOW_32_in_valDateSpanGr6567); if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  						DateTime start = DateTime.Now.AddDays(7);
                    	  						DateTime _startDate = DateTime.MinValue;
                    	  						DateTime _endDate = DateTime.MaxValue;

                    	  						GetDates(ref _startDate, ref _endDate, start);

                    	  						a.Text = _startDate.ToString("yyyy-MM-dd");
                    	  					
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1168:22: -> datevalue(value=$a.text)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("datevalue",
                    	    new STAttrMap().Add("value", ((a != null) ? a.Text : null)));
                    	  }

                    	}
                    }
                    break;
                case 7 :
                    // Output\\FiltersLanguageGrammar.g:1169:7: a= 'thismonth'
                    {
                    	a=(IToken)Match(input,33,FOLLOW_33_in_valDateSpanGr6611); if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  						DateTime start = DateTime.Now;
                    	  						a.Text = new DateTime(start.Year, start.Month, DateTime.DaysInMonth(start.Year, start.Month), 1, 0, 0).ToString("yyyy-MM-dd");
                    	  					
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1173:22: -> datevalue(value=$a.text)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("datevalue",
                    	    new STAttrMap().Add("value", ((a != null) ? a.Text : null)));
                    	  }

                    	}
                    }
                    break;
                case 8 :
                    // Output\\FiltersLanguageGrammar.g:1174:7: a= '\"thismonth\"'
                    {
                    	a=(IToken)Match(input,34,FOLLOW_34_in_valDateSpanGr6655); if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  						DateTime start = DateTime.Now;
                    	  						a.Text = new DateTime(start.Year, start.Month, DateTime.DaysInMonth(start.Year, start.Month), 1, 0, 0).ToString("yyyy-MM-dd");
                    	  					
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1178:22: -> datevalue(value=$a.text)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("datevalue",
                    	    new STAttrMap().Add("value", ((a != null) ? a.Text : null)));
                    	  }

                    	}
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "valDateSpanGr"

    public class valDateSpanGrOrEq_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "valDateSpanGrOrEq"
    // Output\\FiltersLanguageGrammar.g:1181:1: valDateSpanGrOrEq : (a= 'lastweek' -> datevalue(value=$a.text) | a= '\"lastweek\"' -> datevalue(value=$a.text) | a= 'lastmonth' -> datevalue(value=$a.text) | a= '\"lastmonth\"' -> datevalue(value=$a.text) | a= 'thisweek' -> datevalue(value=$a.text) | a= '\"thisweek\"' -> datevalue(value=$a.text) | a= 'thismonth' -> datevalue(value=$a.text) | a= '\"thismonth\"' -> datevalue(value=$a.text));
    public FiltersLanguageGrammarParser.valDateSpanGrOrEq_return valDateSpanGrOrEq() // throws RecognitionException [1]
    {   
        FiltersLanguageGrammarParser.valDateSpanGrOrEq_return retval = new FiltersLanguageGrammarParser.valDateSpanGrOrEq_return();
        retval.Start = input.LT(1);

        IToken a = null;

        try 
    	{
            // Output\\FiltersLanguageGrammar.g:1181:19: (a= 'lastweek' -> datevalue(value=$a.text) | a= '\"lastweek\"' -> datevalue(value=$a.text) | a= 'lastmonth' -> datevalue(value=$a.text) | a= '\"lastmonth\"' -> datevalue(value=$a.text) | a= 'thisweek' -> datevalue(value=$a.text) | a= '\"thisweek\"' -> datevalue(value=$a.text) | a= 'thismonth' -> datevalue(value=$a.text) | a= '\"thismonth\"' -> datevalue(value=$a.text))
            int alt27 = 8;
            switch ( input.LA(1) ) 
            {
            case 27:
            	{
                alt27 = 1;
                }
                break;
            case 28:
            	{
                alt27 = 2;
                }
                break;
            case 29:
            	{
                alt27 = 3;
                }
                break;
            case 30:
            	{
                alt27 = 4;
                }
                break;
            case 31:
            	{
                alt27 = 5;
                }
                break;
            case 32:
            	{
                alt27 = 6;
                }
                break;
            case 33:
            	{
                alt27 = 7;
                }
                break;
            case 34:
            	{
                alt27 = 8;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d27s0 =
            	        new NoViableAltException("", 27, 0, input);

            	    throw nvae_d27s0;
            }

            switch (alt27) 
            {
                case 1 :
                    // Output\\FiltersLanguageGrammar.g:1181:21: a= 'lastweek'
                    {
                    	a=(IToken)Match(input,27,FOLLOW_27_in_valDateSpanGrOrEq6704); if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  							DateTime start = DateTime.Now;
                    	  							DateTime _startDate = DateTime.MinValue;
                    	  							DateTime _endDate = DateTime.MaxValue;

                    	  							GetDates(ref _startDate, ref _endDate, start);

                    	  							a.Text = _endDate.ToString("yyyy-MM-dd");
                    	  						
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1190:23: -> datevalue(value=$a.text)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("datevalue",
                    	    new STAttrMap().Add("value", ((a != null) ? a.Text : null)));
                    	  }

                    	}
                    }
                    break;
                case 2 :
                    // Output\\FiltersLanguageGrammar.g:1191:8: a= '\"lastweek\"'
                    {
                    	a=(IToken)Match(input,28,FOLLOW_28_in_valDateSpanGrOrEq6750); if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  							DateTime start = DateTime.Now;
                    	  							DateTime _startDate = DateTime.MinValue;
                    	  							DateTime _endDate = DateTime.MaxValue;

                    	  							GetDates(ref _startDate, ref _endDate, start);

                    	  							a.Text = _endDate.ToString("yyyy-MM-dd");
                    	  						
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1200:23: -> datevalue(value=$a.text)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("datevalue",
                    	    new STAttrMap().Add("value", ((a != null) ? a.Text : null)));
                    	  }

                    	}
                    }
                    break;
                case 3 :
                    // Output\\FiltersLanguageGrammar.g:1201:8: a= 'lastmonth'
                    {
                    	a=(IToken)Match(input,29,FOLLOW_29_in_valDateSpanGrOrEq6796); if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  							DateTime start = DateTime.Now;

                    	  							a.Text = new DateTime(start.Year, start.Month - 1, DateTime.DaysInMonth(start.Year, start.Month - 1), 1, 0, 0).ToString("yyyy-MM-dd");

                    	  						
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1207:23: -> datevalue(value=$a.text)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("datevalue",
                    	    new STAttrMap().Add("value", ((a != null) ? a.Text : null)));
                    	  }

                    	}
                    }
                    break;
                case 4 :
                    // Output\\FiltersLanguageGrammar.g:1208:8: a= '\"lastmonth\"'
                    {
                    	a=(IToken)Match(input,30,FOLLOW_30_in_valDateSpanGrOrEq6842); if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  							DateTime start = DateTime.Now;

                    	  							a.Text = new DateTime(start.Year, start.Month - 1, DateTime.DaysInMonth(start.Year, start.Month - 1), 1, 0, 0).ToString("yyyy-MM-dd");

                    	  						
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1214:23: -> datevalue(value=$a.text)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("datevalue",
                    	    new STAttrMap().Add("value", ((a != null) ? a.Text : null)));
                    	  }

                    	}
                    }
                    break;
                case 5 :
                    // Output\\FiltersLanguageGrammar.g:1215:8: a= 'thisweek'
                    {
                    	a=(IToken)Match(input,31,FOLLOW_31_in_valDateSpanGrOrEq6888); if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  							DateTime start = DateTime.Now.AddDays(7);
                    	  							DateTime _startDate = DateTime.MinValue;
                    	  							DateTime _endDate = DateTime.MaxValue;

                    	  							GetDates(ref _startDate, ref _endDate, start);

                    	  							a.Text = _endDate.ToString("yyyy-MM-dd");
                    	  						
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1224:23: -> datevalue(value=$a.text)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("datevalue",
                    	    new STAttrMap().Add("value", ((a != null) ? a.Text : null)));
                    	  }

                    	}
                    }
                    break;
                case 6 :
                    // Output\\FiltersLanguageGrammar.g:1225:8: a= '\"thisweek\"'
                    {
                    	a=(IToken)Match(input,32,FOLLOW_32_in_valDateSpanGrOrEq6934); if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  							DateTime start = DateTime.Now.AddDays(7);
                    	  							DateTime _startDate = DateTime.MinValue;
                    	  							DateTime _endDate = DateTime.MaxValue;

                    	  							GetDates(ref _startDate, ref _endDate, start);

                    	  							a.Text = _endDate.ToString("yyyy-MM-dd");
                    	  						
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1234:23: -> datevalue(value=$a.text)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("datevalue",
                    	    new STAttrMap().Add("value", ((a != null) ? a.Text : null)));
                    	  }

                    	}
                    }
                    break;
                case 7 :
                    // Output\\FiltersLanguageGrammar.g:1235:8: a= 'thismonth'
                    {
                    	a=(IToken)Match(input,33,FOLLOW_33_in_valDateSpanGrOrEq6980); if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  							DateTime start = DateTime.Now;
                    	  							a.Text = new DateTime(start.Year, start.Month, DateTime.DaysInMonth(start.Year, start.Month), 1, 0, 0).ToString("yyyy-MM-dd");
                    	  						
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1239:23: -> datevalue(value=$a.text)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("datevalue",
                    	    new STAttrMap().Add("value", ((a != null) ? a.Text : null)));
                    	  }

                    	}
                    }
                    break;
                case 8 :
                    // Output\\FiltersLanguageGrammar.g:1240:8: a= '\"thismonth\"'
                    {
                    	a=(IToken)Match(input,34,FOLLOW_34_in_valDateSpanGrOrEq7026); if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  							DateTime start = DateTime.Now;
                    	  							a.Text = new DateTime(start.Year, start.Month, DateTime.DaysInMonth(start.Year, start.Month), 1, 0, 0).ToString("yyyy-MM-dd");
                    	  						
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1244:23: -> datevalue(value=$a.text)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("datevalue",
                    	    new STAttrMap().Add("value", ((a != null) ? a.Text : null)));
                    	  }

                    	}
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "valDateSpanGrOrEq"

    public class valDateSpan_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "valDateSpan"
    // Output\\FiltersLanguageGrammar.g:1247:1: valDateSpan : (a= 'lastweek' -> datespanvalue(start=_startValend=$a.text) | a= '\"lastweek\"' -> datespanvalue(start=_startValend=$a.text) | a= 'lastmonth' -> datespanvalue(start=_startValend=$a.text) | a= '\"lastmonth\"' -> datespanvalue(start=_startValend=$a.text) | a= 'thisweek' -> datespanvalue(start=_startValend=$a.text) | a= '\"thisweek\"' -> datespanvalue(start=_startValend=$a.text) | a= 'thismonth' -> datespanvalue(start=_startValend=$a.text) | a= '\"thismonth\"' -> datespanvalue(start=_startValend=$a.text));
    public FiltersLanguageGrammarParser.valDateSpan_return valDateSpan() // throws RecognitionException [1]
    {   
        FiltersLanguageGrammarParser.valDateSpan_return retval = new FiltersLanguageGrammarParser.valDateSpan_return();
        retval.Start = input.LT(1);

        IToken a = null;

        try 
    	{
            // Output\\FiltersLanguageGrammar.g:1247:13: (a= 'lastweek' -> datespanvalue(start=_startValend=$a.text) | a= '\"lastweek\"' -> datespanvalue(start=_startValend=$a.text) | a= 'lastmonth' -> datespanvalue(start=_startValend=$a.text) | a= '\"lastmonth\"' -> datespanvalue(start=_startValend=$a.text) | a= 'thisweek' -> datespanvalue(start=_startValend=$a.text) | a= '\"thisweek\"' -> datespanvalue(start=_startValend=$a.text) | a= 'thismonth' -> datespanvalue(start=_startValend=$a.text) | a= '\"thismonth\"' -> datespanvalue(start=_startValend=$a.text))
            int alt28 = 8;
            switch ( input.LA(1) ) 
            {
            case 27:
            	{
                alt28 = 1;
                }
                break;
            case 28:
            	{
                alt28 = 2;
                }
                break;
            case 29:
            	{
                alt28 = 3;
                }
                break;
            case 30:
            	{
                alt28 = 4;
                }
                break;
            case 31:
            	{
                alt28 = 5;
                }
                break;
            case 32:
            	{
                alt28 = 6;
                }
                break;
            case 33:
            	{
                alt28 = 7;
                }
                break;
            case 34:
            	{
                alt28 = 8;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d28s0 =
            	        new NoViableAltException("", 28, 0, input);

            	    throw nvae_d28s0;
            }

            switch (alt28) 
            {
                case 1 :
                    // Output\\FiltersLanguageGrammar.g:1247:15: a= 'lastweek'
                    {
                    	a=(IToken)Match(input,27,FOLLOW_27_in_valDateSpan7077); if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{
                    	   
                    	  					DateTime start = DateTime.Now.AddDays(-1);
                    	  					DateTime _startDate = DateTime.MinValue;
                    	  					DateTime _endDate = DateTime.MaxValue;

                    	  					GetDates(ref _startDate, ref _endDate, start);

                    	  					_startVal = _startDate.ToString("yyyy-MM-dd");
                    	  					a.Text = _endDate.ToString("yyyy-MM-dd");
                    	  				
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1257:21: -> datespanvalue(start=_startValend=$a.text)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("datespanvalue",
                    	    new STAttrMap().Add("start", _startVal).Add("end", ((a != null) ? a.Text : null)));
                    	  }

                    	}
                    }
                    break;
                case 2 :
                    // Output\\FiltersLanguageGrammar.g:1258:6: a= '\"lastweek\"'
                    {
                    	a=(IToken)Match(input,28,FOLLOW_28_in_valDateSpan7126); if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{
                    	   
                    	  					DateTime start = DateTime.Now.AddDays(-1);
                    	  					DateTime _startDate = DateTime.MinValue;
                    	  					DateTime _endDate = DateTime.MaxValue;

                    	  					GetDates(ref _startDate, ref _endDate, start);

                    	  					_startVal = _startDate.ToString("yyyy-MM-dd");
                    	  					a.Text = _endDate.ToString("yyyy-MM-dd");
                    	  				
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1268:21: -> datespanvalue(start=_startValend=$a.text)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("datespanvalue",
                    	    new STAttrMap().Add("start", _startVal).Add("end", ((a != null) ? a.Text : null)));
                    	  }

                    	}
                    }
                    break;
                case 3 :
                    // Output\\FiltersLanguageGrammar.g:1269:6: a= 'lastmonth'
                    {
                    	a=(IToken)Match(input,29,FOLLOW_29_in_valDateSpan7175); if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  					DateTime start = DateTime.Now;	
                    	  					_startVal = new DateTime(start.Year, start.Month - 1, 1, 1, 0, 0).ToString("yyyy-MM-dd");
                    	  					a.Text = new DateTime(start.Year, start.Month - 1, DateTime.DaysInMonth(start.Year, start.Month - 1), 1, 0, 0).ToString("yyyy-MM-dd");

                    	  				
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1275:21: -> datespanvalue(start=_startValend=$a.text)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("datespanvalue",
                    	    new STAttrMap().Add("start", _startVal).Add("end", ((a != null) ? a.Text : null)));
                    	  }

                    	}
                    }
                    break;
                case 4 :
                    // Output\\FiltersLanguageGrammar.g:1276:6: a= '\"lastmonth\"'
                    {
                    	a=(IToken)Match(input,30,FOLLOW_30_in_valDateSpan7224); if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  					DateTime start = DateTime.Now;	
                    	  					_startVal = new DateTime(start.Year, start.Month - 1, 1, 1, 0, 0).ToString("yyyy-MM-dd");
                    	  					a.Text = new DateTime(start.Year, start.Month - 1, DateTime.DaysInMonth(start.Year, start.Month - 1), 1, 0, 0).ToString("yyyy-MM-dd");

                    	  				
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1282:21: -> datespanvalue(start=_startValend=$a.text)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("datespanvalue",
                    	    new STAttrMap().Add("start", _startVal).Add("end", ((a != null) ? a.Text : null)));
                    	  }

                    	}
                    }
                    break;
                case 5 :
                    // Output\\FiltersLanguageGrammar.g:1283:6: a= 'thisweek'
                    {
                    	a=(IToken)Match(input,31,FOLLOW_31_in_valDateSpan7273); if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  					DateTime start = DateTime.Now.AddDays(7);
                    	  					DateTime _startDate = DateTime.MinValue;
                    	  					DateTime _endDate = DateTime.MaxValue;

                    	  					GetDates(ref _startDate, ref _endDate, start);

                    	  					_startVal = _startDate.ToString("yyyy-MM-dd");
                    	  					a.Text = _endDate.ToString("yyyy-MM-dd");
                    	  				
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1293:21: -> datespanvalue(start=_startValend=$a.text)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("datespanvalue",
                    	    new STAttrMap().Add("start", _startVal).Add("end", ((a != null) ? a.Text : null)));
                    	  }

                    	}
                    }
                    break;
                case 6 :
                    // Output\\FiltersLanguageGrammar.g:1294:6: a= '\"thisweek\"'
                    {
                    	a=(IToken)Match(input,32,FOLLOW_32_in_valDateSpan7322); if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  					DateTime start = DateTime.Now.AddDays(7);
                    	  					DateTime _startDate = DateTime.MinValue;
                    	  					DateTime _endDate = DateTime.MaxValue;

                    	  					GetDates(ref _startDate, ref _endDate, start);

                    	  					_startVal = _startDate.ToString("yyyy-MM-dd");
                    	  					a.Text = _endDate.ToString("yyyy-MM-dd");
                    	  				
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1304:21: -> datespanvalue(start=_startValend=$a.text)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("datespanvalue",
                    	    new STAttrMap().Add("start", _startVal).Add("end", ((a != null) ? a.Text : null)));
                    	  }

                    	}
                    }
                    break;
                case 7 :
                    // Output\\FiltersLanguageGrammar.g:1305:6: a= 'thismonth'
                    {
                    	a=(IToken)Match(input,33,FOLLOW_33_in_valDateSpan7371); if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  					DateTime start = DateTime.Now;	
                    	  					_startVal = new DateTime(start.Year, start.Month, 1, 1, 0, 0).ToString("yyyy-MM-dd");
                    	  					a.Text = new DateTime(start.Year, start.Month, DateTime.DaysInMonth(start.Year, start.Month), 1, 0, 0).ToString("yyyy-MM-dd");
                    	  				
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1310:21: -> datespanvalue(start=_startValend=$a.text)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("datespanvalue",
                    	    new STAttrMap().Add("start", _startVal).Add("end", ((a != null) ? a.Text : null)));
                    	  }

                    	}
                    }
                    break;
                case 8 :
                    // Output\\FiltersLanguageGrammar.g:1311:6: a= '\"thismonth\"'
                    {
                    	a=(IToken)Match(input,34,FOLLOW_34_in_valDateSpan7420); if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  					DateTime start = DateTime.Now;	
                    	  					_startVal = new DateTime(start.Year, start.Month, 1, 1, 0, 0).ToString("yyyy-MM-dd");
                    	  					a.Text = new DateTime(start.Year, start.Month, DateTime.DaysInMonth(start.Year, start.Month), 1, 0, 0).ToString("yyyy-MM-dd");
                    	  				
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1316:21: -> datespanvalue(start=_startValend=$a.text)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("datespanvalue",
                    	    new STAttrMap().Add("start", _startVal).Add("end", ((a != null) ? a.Text : null)));
                    	  }

                    	}
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "valDateSpan"

    public class valUser_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "valUser"
    // Output\\FiltersLanguageGrammar.g:1319:1: valUser : (a= STRING -> strvalue(value=$STRING.text) | a= '\"me\"' -> othervalue(value=$a.text) | a= 'me' -> othervalue(value=$a.text));
    public FiltersLanguageGrammarParser.valUser_return valUser() // throws RecognitionException [1]
    {   
        FiltersLanguageGrammarParser.valUser_return retval = new FiltersLanguageGrammarParser.valUser_return();
        retval.Start = input.LT(1);

        IToken a = null;

        try 
    	{
            // Output\\FiltersLanguageGrammar.g:1319:10: (a= STRING -> strvalue(value=$STRING.text) | a= '\"me\"' -> othervalue(value=$a.text) | a= 'me' -> othervalue(value=$a.text))
            int alt29 = 3;
            switch ( input.LA(1) ) 
            {
            case STRING:
            	{
                alt29 = 1;
                }
                break;
            case 35:
            	{
                alt29 = 2;
                }
                break;
            case 36:
            	{
                alt29 = 3;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d29s0 =
            	        new NoViableAltException("", 29, 0, input);

            	    throw nvae_d29s0;
            }

            switch (alt29) 
            {
                case 1 :
                    // Output\\FiltersLanguageGrammar.g:1319:12: a= STRING
                    {
                    	a=(IToken)Match(input,STRING,FOLLOW_STRING_in_valUser7475); if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  					a.Text = a.Text.Replace("'", "''");
                    	  					a.Text = a.Text.Replace("\"", "\'");
                    	  				
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1323:21: -> strvalue(value=$STRING.text)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("strvalue",
                    	    new STAttrMap().Add("value", ((a != null) ? a.Text : null)));
                    	  }

                    	}
                    }
                    break;
                case 2 :
                    // Output\\FiltersLanguageGrammar.g:1324:6: a= '\"me\"'
                    {
                    	a=(IToken)Match(input,35,FOLLOW_35_in_valUser7517); if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  					a.Text = "\'" + ActualUserName + "\'";
                    	  				
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1327:21: -> othervalue(value=$a.text)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("othervalue",
                    	    new STAttrMap().Add("value", ((a != null) ? a.Text : null)));
                    	  }

                    	}
                    }
                    break;
                case 3 :
                    // Output\\FiltersLanguageGrammar.g:1328:6: a= 'me'
                    {
                    	a=(IToken)Match(input,36,FOLLOW_36_in_valUser7559); if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  					a.Text = "\'" + ActualUserName + "\'";
                    	  				
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1331:21: -> othervalue(value=$a.text)
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("othervalue",
                    	    new STAttrMap().Add("value", ((a != null) ? a.Text : null)));
                    	  }

                    	}
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "valUser"

    public class parametersStr_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "parametersStr"
    // Output\\FiltersLanguageGrammar.g:1338:1: parametersStr : ( 'user.' user_stringparameters -> {$user_stringparameters.st} | 'u.' user_stringparameters -> {$user_stringparameters.st});
    public FiltersLanguageGrammarParser.parametersStr_return parametersStr() // throws RecognitionException [1]
    {   
        FiltersLanguageGrammarParser.parametersStr_return retval = new FiltersLanguageGrammarParser.parametersStr_return();
        retval.Start = input.LT(1);

        FiltersLanguageGrammarParser.user_stringparameters_return user_stringparameters142 = default(FiltersLanguageGrammarParser.user_stringparameters_return);

        FiltersLanguageGrammarParser.user_stringparameters_return user_stringparameters143 = default(FiltersLanguageGrammarParser.user_stringparameters_return);


        try 
    	{
            // Output\\FiltersLanguageGrammar.g:1338:17: ( 'user.' user_stringparameters -> {$user_stringparameters.st} | 'u.' user_stringparameters -> {$user_stringparameters.st})
            int alt30 = 2;
            int LA30_0 = input.LA(1);

            if ( (LA30_0 == 37) )
            {
                alt30 = 1;
            }
            else if ( (LA30_0 == 38) )
            {
                alt30 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d30s0 =
                    new NoViableAltException("", 30, 0, input);

                throw nvae_d30s0;
            }
            switch (alt30) 
            {
                case 1 :
                    // Output\\FiltersLanguageGrammar.g:1339:5: 'user.' user_stringparameters
                    {
                    	Match(input,37,FOLLOW_37_in_parametersStr7615); if (state.failed) return retval;
                    	PushFollow(FOLLOW_user_stringparameters_in_parametersStr7618);
                    	user_stringparameters142 = user_stringparameters();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  					_paramExpr = _paramExpr.Insert(0, "user.");
                    	  				
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1342:7: -> {$user_stringparameters.st}
                    	  {
                    	      retval.ST = ((user_stringparameters142 != null) ? user_stringparameters142.ST : null);
                    	  }

                    	}
                    }
                    break;
                case 2 :
                    // Output\\FiltersLanguageGrammar.g:1344:5: 'u.' user_stringparameters
                    {
                    	Match(input,38,FOLLOW_38_in_parametersStr7638); if (state.failed) return retval;
                    	PushFollow(FOLLOW_user_stringparameters_in_parametersStr7641);
                    	user_stringparameters143 = user_stringparameters();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  					_paramExpr = _paramExpr.Insert(0, "u.");
                    	  				
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1347:7: -> {$user_stringparameters.st}
                    	  {
                    	      retval.ST = ((user_stringparameters143 != null) ? user_stringparameters143.ST : null);
                    	  }

                    	}
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "parametersStr"

    public class paramLongStr_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "paramLongStr"
    // Output\\FiltersLanguageGrammar.g:1350:1: paramLongStr : ( 'user.' user_longstringparameters -> {$user_longstringparameters.st} | 'u.' user_longstringparameters -> {$user_longstringparameters.st});
    public FiltersLanguageGrammarParser.paramLongStr_return paramLongStr() // throws RecognitionException [1]
    {   
        FiltersLanguageGrammarParser.paramLongStr_return retval = new FiltersLanguageGrammarParser.paramLongStr_return();
        retval.Start = input.LT(1);

        FiltersLanguageGrammarParser.user_longstringparameters_return user_longstringparameters144 = default(FiltersLanguageGrammarParser.user_longstringparameters_return);

        FiltersLanguageGrammarParser.user_longstringparameters_return user_longstringparameters145 = default(FiltersLanguageGrammarParser.user_longstringparameters_return);


        try 
    	{
            // Output\\FiltersLanguageGrammar.g:1350:16: ( 'user.' user_longstringparameters -> {$user_longstringparameters.st} | 'u.' user_longstringparameters -> {$user_longstringparameters.st})
            int alt31 = 2;
            int LA31_0 = input.LA(1);

            if ( (LA31_0 == 37) )
            {
                alt31 = 1;
            }
            else if ( (LA31_0 == 38) )
            {
                alt31 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d31s0 =
                    new NoViableAltException("", 31, 0, input);

                throw nvae_d31s0;
            }
            switch (alt31) 
            {
                case 1 :
                    // Output\\FiltersLanguageGrammar.g:1351:5: 'user.' user_longstringparameters
                    {
                    	Match(input,37,FOLLOW_37_in_paramLongStr7674); if (state.failed) return retval;
                    	PushFollow(FOLLOW_user_longstringparameters_in_paramLongStr7677);
                    	user_longstringparameters144 = user_longstringparameters();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  					_paramExpr = _paramExpr.Insert(0, "user.");
                    	  				
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1354:7: -> {$user_longstringparameters.st}
                    	  {
                    	      retval.ST = ((user_longstringparameters144 != null) ? user_longstringparameters144.ST : null);
                    	  }

                    	}
                    }
                    break;
                case 2 :
                    // Output\\FiltersLanguageGrammar.g:1356:5: 'u.' user_longstringparameters
                    {
                    	Match(input,38,FOLLOW_38_in_paramLongStr7697); if (state.failed) return retval;
                    	PushFollow(FOLLOW_user_longstringparameters_in_paramLongStr7700);
                    	user_longstringparameters145 = user_longstringparameters();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  					_paramExpr = _paramExpr.Insert(0, "u.");
                    	  				
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1359:7: -> {$user_longstringparameters.st}
                    	  {
                    	      retval.ST = ((user_longstringparameters145 != null) ? user_longstringparameters145.ST : null);
                    	  }

                    	}
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "paramLongStr"

    public class parametersInt_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "parametersInt"
    // Output\\FiltersLanguageGrammar.g:1362:1: parametersInt : ( 'user.' user_intparameters -> {$user_intparameters.st} | 'u.' user_intparameters -> {$user_intparameters.st});
    public FiltersLanguageGrammarParser.parametersInt_return parametersInt() // throws RecognitionException [1]
    {   
        FiltersLanguageGrammarParser.parametersInt_return retval = new FiltersLanguageGrammarParser.parametersInt_return();
        retval.Start = input.LT(1);

        FiltersLanguageGrammarParser.user_intparameters_return user_intparameters146 = default(FiltersLanguageGrammarParser.user_intparameters_return);

        FiltersLanguageGrammarParser.user_intparameters_return user_intparameters147 = default(FiltersLanguageGrammarParser.user_intparameters_return);


        try 
    	{
            // Output\\FiltersLanguageGrammar.g:1362:17: ( 'user.' user_intparameters -> {$user_intparameters.st} | 'u.' user_intparameters -> {$user_intparameters.st})
            int alt32 = 2;
            int LA32_0 = input.LA(1);

            if ( (LA32_0 == 37) )
            {
                alt32 = 1;
            }
            else if ( (LA32_0 == 38) )
            {
                alt32 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d32s0 =
                    new NoViableAltException("", 32, 0, input);

                throw nvae_d32s0;
            }
            switch (alt32) 
            {
                case 1 :
                    // Output\\FiltersLanguageGrammar.g:1363:5: 'user.' user_intparameters
                    {
                    	Match(input,37,FOLLOW_37_in_parametersInt7733); if (state.failed) return retval;
                    	PushFollow(FOLLOW_user_intparameters_in_parametersInt7736);
                    	user_intparameters146 = user_intparameters();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  					_paramExpr = _paramExpr.Insert(0, "user.");
                    	  				
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1366:7: -> {$user_intparameters.st}
                    	  {
                    	      retval.ST = ((user_intparameters146 != null) ? user_intparameters146.ST : null);
                    	  }

                    	}
                    }
                    break;
                case 2 :
                    // Output\\FiltersLanguageGrammar.g:1368:5: 'u.' user_intparameters
                    {
                    	Match(input,38,FOLLOW_38_in_parametersInt7756); if (state.failed) return retval;
                    	PushFollow(FOLLOW_user_intparameters_in_parametersInt7759);
                    	user_intparameters147 = user_intparameters();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  					_paramExpr = _paramExpr.Insert(0, "u.");
                    	  				
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1371:7: -> {$user_intparameters.st}
                    	  {
                    	      retval.ST = ((user_intparameters147 != null) ? user_intparameters147.ST : null);
                    	  }

                    	}
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "parametersInt"

    public class parametersDate_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "parametersDate"
    // Output\\FiltersLanguageGrammar.g:1374:1: parametersDate : ( 'user.' user_normaldateparameters -> {$user_normaldateparameters.st} | 'u.' user_normaldateparameters -> {$user_normaldateparameters.st} | 'user.' user_pastdateparameters -> {$user_pastdateparameters.st} | 'u.' user_pastdateparameters -> {$user_pastdateparameters.st});
    public FiltersLanguageGrammarParser.parametersDate_return parametersDate() // throws RecognitionException [1]
    {   
        FiltersLanguageGrammarParser.parametersDate_return retval = new FiltersLanguageGrammarParser.parametersDate_return();
        retval.Start = input.LT(1);

        FiltersLanguageGrammarParser.user_normaldateparameters_return user_normaldateparameters148 = default(FiltersLanguageGrammarParser.user_normaldateparameters_return);

        FiltersLanguageGrammarParser.user_normaldateparameters_return user_normaldateparameters149 = default(FiltersLanguageGrammarParser.user_normaldateparameters_return);

        FiltersLanguageGrammarParser.user_pastdateparameters_return user_pastdateparameters150 = default(FiltersLanguageGrammarParser.user_pastdateparameters_return);

        FiltersLanguageGrammarParser.user_pastdateparameters_return user_pastdateparameters151 = default(FiltersLanguageGrammarParser.user_pastdateparameters_return);


        try 
    	{
            // Output\\FiltersLanguageGrammar.g:1374:18: ( 'user.' user_normaldateparameters -> {$user_normaldateparameters.st} | 'u.' user_normaldateparameters -> {$user_normaldateparameters.st} | 'user.' user_pastdateparameters -> {$user_pastdateparameters.st} | 'u.' user_pastdateparameters -> {$user_pastdateparameters.st})
            int alt33 = 4;
            int LA33_0 = input.LA(1);

            if ( (LA33_0 == 37) )
            {
                int LA33_1 = input.LA(2);

                if ( (LA33_1 == 43) )
                {
                    alt33 = 3;
                }
                else if ( (LA33_1 == 18 || (LA33_1 >= 52 && LA33_1 <= 57) || LA33_1 == 62) )
                {
                    alt33 = 1;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d33s1 =
                        new NoViableAltException("", 33, 1, input);

                    throw nvae_d33s1;
                }
            }
            else if ( (LA33_0 == 38) )
            {
                int LA33_2 = input.LA(2);

                if ( (LA33_2 == 18 || (LA33_2 >= 52 && LA33_2 <= 57) || LA33_2 == 62) )
                {
                    alt33 = 2;
                }
                else if ( (LA33_2 == 43) )
                {
                    alt33 = 4;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d33s2 =
                        new NoViableAltException("", 33, 2, input);

                    throw nvae_d33s2;
                }
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d33s0 =
                    new NoViableAltException("", 33, 0, input);

                throw nvae_d33s0;
            }
            switch (alt33) 
            {
                case 1 :
                    // Output\\FiltersLanguageGrammar.g:1375:5: 'user.' user_normaldateparameters
                    {
                    	Match(input,37,FOLLOW_37_in_parametersDate7792); if (state.failed) return retval;
                    	PushFollow(FOLLOW_user_normaldateparameters_in_parametersDate7795);
                    	user_normaldateparameters148 = user_normaldateparameters();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  					_paramExpr = _paramExpr.Insert(0, "user.");
                    	  				
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1378:7: -> {$user_normaldateparameters.st}
                    	  {
                    	      retval.ST = ((user_normaldateparameters148 != null) ? user_normaldateparameters148.ST : null);
                    	  }

                    	}
                    }
                    break;
                case 2 :
                    // Output\\FiltersLanguageGrammar.g:1380:5: 'u.' user_normaldateparameters
                    {
                    	Match(input,38,FOLLOW_38_in_parametersDate7815); if (state.failed) return retval;
                    	PushFollow(FOLLOW_user_normaldateparameters_in_parametersDate7818);
                    	user_normaldateparameters149 = user_normaldateparameters();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  					_paramExpr = _paramExpr.Insert(0, "u.");
                    	  				
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1383:7: -> {$user_normaldateparameters.st}
                    	  {
                    	      retval.ST = ((user_normaldateparameters149 != null) ? user_normaldateparameters149.ST : null);
                    	  }

                    	}
                    }
                    break;
                case 3 :
                    // Output\\FiltersLanguageGrammar.g:1385:5: 'user.' user_pastdateparameters
                    {
                    	Match(input,37,FOLLOW_37_in_parametersDate7838); if (state.failed) return retval;
                    	PushFollow(FOLLOW_user_pastdateparameters_in_parametersDate7841);
                    	user_pastdateparameters150 = user_pastdateparameters();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  					_paramExpr = _paramExpr.Insert(0, "user.");
                    	  				
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1388:7: -> {$user_pastdateparameters.st}
                    	  {
                    	      retval.ST = ((user_pastdateparameters150 != null) ? user_pastdateparameters150.ST : null);
                    	  }

                    	}
                    }
                    break;
                case 4 :
                    // Output\\FiltersLanguageGrammar.g:1390:5: 'u.' user_pastdateparameters
                    {
                    	Match(input,38,FOLLOW_38_in_parametersDate7861); if (state.failed) return retval;
                    	PushFollow(FOLLOW_user_pastdateparameters_in_parametersDate7864);
                    	user_pastdateparameters151 = user_pastdateparameters();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  					_paramExpr = _paramExpr.Insert(0, "u.");
                    	  				
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1393:7: -> {$user_pastdateparameters.st}
                    	  {
                    	      retval.ST = ((user_pastdateparameters151 != null) ? user_pastdateparameters151.ST : null);
                    	  }

                    	}
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "parametersDate"

    public class parametersUser_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "parametersUser"
    // Output\\FiltersLanguageGrammar.g:1396:1: parametersUser : ( 'user.' user_userparameters -> {$user_userparameters.st} | 'u.' user_userparameters -> {$user_userparameters.st});
    public FiltersLanguageGrammarParser.parametersUser_return parametersUser() // throws RecognitionException [1]
    {   
        FiltersLanguageGrammarParser.parametersUser_return retval = new FiltersLanguageGrammarParser.parametersUser_return();
        retval.Start = input.LT(1);

        FiltersLanguageGrammarParser.user_userparameters_return user_userparameters152 = default(FiltersLanguageGrammarParser.user_userparameters_return);

        FiltersLanguageGrammarParser.user_userparameters_return user_userparameters153 = default(FiltersLanguageGrammarParser.user_userparameters_return);


        try 
    	{
            // Output\\FiltersLanguageGrammar.g:1396:18: ( 'user.' user_userparameters -> {$user_userparameters.st} | 'u.' user_userparameters -> {$user_userparameters.st})
            int alt34 = 2;
            int LA34_0 = input.LA(1);

            if ( (LA34_0 == 37) )
            {
                alt34 = 1;
            }
            else if ( (LA34_0 == 38) )
            {
                alt34 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d34s0 =
                    new NoViableAltException("", 34, 0, input);

                throw nvae_d34s0;
            }
            switch (alt34) 
            {
                case 1 :
                    // Output\\FiltersLanguageGrammar.g:1397:5: 'user.' user_userparameters
                    {
                    	Match(input,37,FOLLOW_37_in_parametersUser7897); if (state.failed) return retval;
                    	PushFollow(FOLLOW_user_userparameters_in_parametersUser7900);
                    	user_userparameters152 = user_userparameters();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  					_paramExpr = _paramExpr.Insert(0, "user.");
                    	  				
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1400:7: -> {$user_userparameters.st}
                    	  {
                    	      retval.ST = ((user_userparameters152 != null) ? user_userparameters152.ST : null);
                    	  }

                    	}
                    }
                    break;
                case 2 :
                    // Output\\FiltersLanguageGrammar.g:1402:5: 'u.' user_userparameters
                    {
                    	Match(input,38,FOLLOW_38_in_parametersUser7920); if (state.failed) return retval;
                    	PushFollow(FOLLOW_user_userparameters_in_parametersUser7923);
                    	user_userparameters153 = user_userparameters();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  					_paramExpr = _paramExpr.Insert(0, "u.");
                    	  				
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1405:7: -> {$user_userparameters.st}
                    	  {
                    	      retval.ST = ((user_userparameters153 != null) ? user_userparameters153.ST : null);
                    	  }

                    	}
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "parametersUser"

    public class parametersBool_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "parametersBool"
    // Output\\FiltersLanguageGrammar.g:1408:1: parametersBool : ( 'user.' user_boolparameters -> {$user_boolparameters.st} | 'u.' user_boolparameters -> {$user_boolparameters.st});
    public FiltersLanguageGrammarParser.parametersBool_return parametersBool() // throws RecognitionException [1]
    {   
        FiltersLanguageGrammarParser.parametersBool_return retval = new FiltersLanguageGrammarParser.parametersBool_return();
        retval.Start = input.LT(1);

        FiltersLanguageGrammarParser.user_boolparameters_return user_boolparameters154 = default(FiltersLanguageGrammarParser.user_boolparameters_return);

        FiltersLanguageGrammarParser.user_boolparameters_return user_boolparameters155 = default(FiltersLanguageGrammarParser.user_boolparameters_return);


        try 
    	{
            // Output\\FiltersLanguageGrammar.g:1408:18: ( 'user.' user_boolparameters -> {$user_boolparameters.st} | 'u.' user_boolparameters -> {$user_boolparameters.st})
            int alt35 = 2;
            int LA35_0 = input.LA(1);

            if ( (LA35_0 == 37) )
            {
                alt35 = 1;
            }
            else if ( (LA35_0 == 38) )
            {
                alt35 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d35s0 =
                    new NoViableAltException("", 35, 0, input);

                throw nvae_d35s0;
            }
            switch (alt35) 
            {
                case 1 :
                    // Output\\FiltersLanguageGrammar.g:1409:5: 'user.' user_boolparameters
                    {
                    	Match(input,37,FOLLOW_37_in_parametersBool7956); if (state.failed) return retval;
                    	PushFollow(FOLLOW_user_boolparameters_in_parametersBool7959);
                    	user_boolparameters154 = user_boolparameters();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  					_paramExpr = _paramExpr.Insert(0, "user.");
                    	  				
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1412:7: -> {$user_boolparameters.st}
                    	  {
                    	      retval.ST = ((user_boolparameters154 != null) ? user_boolparameters154.ST : null);
                    	  }

                    	}
                    }
                    break;
                case 2 :
                    // Output\\FiltersLanguageGrammar.g:1414:5: 'u.' user_boolparameters
                    {
                    	Match(input,38,FOLLOW_38_in_parametersBool7979); if (state.failed) return retval;
                    	PushFollow(FOLLOW_user_boolparameters_in_parametersBool7982);
                    	user_boolparameters155 = user_boolparameters();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  					_paramExpr = _paramExpr.Insert(0, "u.");
                    	  				
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1417:7: -> {$user_boolparameters.st}
                    	  {
                    	      retval.ST = ((user_boolparameters155 != null) ? user_boolparameters155.ST : null);
                    	  }

                    	}
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "parametersBool"

    public class parametersMapped_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "parametersMapped"
    // Output\\FiltersLanguageGrammar.g:1420:1: parametersMapped : ( 'user.' user_mappedparameters -> {$user_mappedparameters.st} | 'u.' user_mappedparameters -> {$user_mappedparameters.st});
    public FiltersLanguageGrammarParser.parametersMapped_return parametersMapped() // throws RecognitionException [1]
    {   
        FiltersLanguageGrammarParser.parametersMapped_return retval = new FiltersLanguageGrammarParser.parametersMapped_return();
        retval.Start = input.LT(1);

        FiltersLanguageGrammarParser.user_mappedparameters_return user_mappedparameters156 = default(FiltersLanguageGrammarParser.user_mappedparameters_return);

        FiltersLanguageGrammarParser.user_mappedparameters_return user_mappedparameters157 = default(FiltersLanguageGrammarParser.user_mappedparameters_return);


        try 
    	{
            // Output\\FiltersLanguageGrammar.g:1420:19: ( 'user.' user_mappedparameters -> {$user_mappedparameters.st} | 'u.' user_mappedparameters -> {$user_mappedparameters.st})
            int alt36 = 2;
            int LA36_0 = input.LA(1);

            if ( (LA36_0 == 37) )
            {
                alt36 = 1;
            }
            else if ( (LA36_0 == 38) )
            {
                alt36 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d36s0 =
                    new NoViableAltException("", 36, 0, input);

                throw nvae_d36s0;
            }
            switch (alt36) 
            {
                case 1 :
                    // Output\\FiltersLanguageGrammar.g:1421:5: 'user.' user_mappedparameters
                    {
                    	Match(input,37,FOLLOW_37_in_parametersMapped8014); if (state.failed) return retval;
                    	PushFollow(FOLLOW_user_mappedparameters_in_parametersMapped8017);
                    	user_mappedparameters156 = user_mappedparameters();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  					_paramExpr = _paramExpr.Insert(0, "user.");
                    	  				
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1424:7: -> {$user_mappedparameters.st}
                    	  {
                    	      retval.ST = ((user_mappedparameters156 != null) ? user_mappedparameters156.ST : null);
                    	  }

                    	}
                    }
                    break;
                case 2 :
                    // Output\\FiltersLanguageGrammar.g:1426:5: 'u.' user_mappedparameters
                    {
                    	Match(input,38,FOLLOW_38_in_parametersMapped8037); if (state.failed) return retval;
                    	PushFollow(FOLLOW_user_mappedparameters_in_parametersMapped8040);
                    	user_mappedparameters157 = user_mappedparameters();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  					_paramExpr = _paramExpr.Insert(0, "u.");
                    	  				
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1429:7: -> {$user_mappedparameters.st}
                    	  {
                    	      retval.ST = ((user_mappedparameters157 != null) ? user_mappedparameters157.ST : null);
                    	  }

                    	}
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "parametersMapped"

    public class parametersManyToMany_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "parametersManyToMany"
    // Output\\FiltersLanguageGrammar.g:1432:1: parametersManyToMany : ( 'user.' user_manytomanyparameters -> {$user_manytomanyparameters.st} | 'u.' user_manytomanyparameters -> {$user_manytomanyparameters.st});
    public FiltersLanguageGrammarParser.parametersManyToMany_return parametersManyToMany() // throws RecognitionException [1]
    {   
        FiltersLanguageGrammarParser.parametersManyToMany_return retval = new FiltersLanguageGrammarParser.parametersManyToMany_return();
        retval.Start = input.LT(1);

        FiltersLanguageGrammarParser.user_manytomanyparameters_return user_manytomanyparameters158 = default(FiltersLanguageGrammarParser.user_manytomanyparameters_return);

        FiltersLanguageGrammarParser.user_manytomanyparameters_return user_manytomanyparameters159 = default(FiltersLanguageGrammarParser.user_manytomanyparameters_return);


        try 
    	{
            // Output\\FiltersLanguageGrammar.g:1432:22: ( 'user.' user_manytomanyparameters -> {$user_manytomanyparameters.st} | 'u.' user_manytomanyparameters -> {$user_manytomanyparameters.st})
            int alt37 = 2;
            int LA37_0 = input.LA(1);

            if ( (LA37_0 == 37) )
            {
                alt37 = 1;
            }
            else if ( (LA37_0 == 38) )
            {
                alt37 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d37s0 =
                    new NoViableAltException("", 37, 0, input);

                throw nvae_d37s0;
            }
            switch (alt37) 
            {
                case 1 :
                    // Output\\FiltersLanguageGrammar.g:1433:5: 'user.' user_manytomanyparameters
                    {
                    	Match(input,37,FOLLOW_37_in_parametersManyToMany8071); if (state.failed) return retval;
                    	PushFollow(FOLLOW_user_manytomanyparameters_in_parametersManyToMany8074);
                    	user_manytomanyparameters158 = user_manytomanyparameters();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  					_paramExpr = _paramExpr.Insert(0, "user.");
                    	  				
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1436:7: -> {$user_manytomanyparameters.st}
                    	  {
                    	      retval.ST = ((user_manytomanyparameters158 != null) ? user_manytomanyparameters158.ST : null);
                    	  }

                    	}
                    }
                    break;
                case 2 :
                    // Output\\FiltersLanguageGrammar.g:1438:5: 'u.' user_manytomanyparameters
                    {
                    	Match(input,38,FOLLOW_38_in_parametersManyToMany8094); if (state.failed) return retval;
                    	PushFollow(FOLLOW_user_manytomanyparameters_in_parametersManyToMany8097);
                    	user_manytomanyparameters159 = user_manytomanyparameters();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  					_paramExpr = _paramExpr.Insert(0, "u.");
                    	  				
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1441:7: -> {$user_manytomanyparameters.st}
                    	  {
                    	      retval.ST = ((user_manytomanyparameters159 != null) ? user_manytomanyparameters159.ST : null);
                    	  }

                    	}
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "parametersManyToMany"

    public class parametersConstOneToMany_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "parametersConstOneToMany"
    // Output\\FiltersLanguageGrammar.g:1444:1: parametersConstOneToMany : ( 'user.' user_constonetomanyparameters -> {$user_constonetomanyparameters.st} | 'u.' user_constonetomanyparameters -> {$user_constonetomanyparameters.st});
    public FiltersLanguageGrammarParser.parametersConstOneToMany_return parametersConstOneToMany() // throws RecognitionException [1]
    {   
        FiltersLanguageGrammarParser.parametersConstOneToMany_return retval = new FiltersLanguageGrammarParser.parametersConstOneToMany_return();
        retval.Start = input.LT(1);

        FiltersLanguageGrammarParser.user_constonetomanyparameters_return user_constonetomanyparameters160 = default(FiltersLanguageGrammarParser.user_constonetomanyparameters_return);

        FiltersLanguageGrammarParser.user_constonetomanyparameters_return user_constonetomanyparameters161 = default(FiltersLanguageGrammarParser.user_constonetomanyparameters_return);


        try 
    	{
            // Output\\FiltersLanguageGrammar.g:1444:27: ( 'user.' user_constonetomanyparameters -> {$user_constonetomanyparameters.st} | 'u.' user_constonetomanyparameters -> {$user_constonetomanyparameters.st})
            int alt38 = 2;
            int LA38_0 = input.LA(1);

            if ( (LA38_0 == 37) )
            {
                alt38 = 1;
            }
            else if ( (LA38_0 == 38) )
            {
                alt38 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d38s0 =
                    new NoViableAltException("", 38, 0, input);

                throw nvae_d38s0;
            }
            switch (alt38) 
            {
                case 1 :
                    // Output\\FiltersLanguageGrammar.g:1445:5: 'user.' user_constonetomanyparameters
                    {
                    	Match(input,37,FOLLOW_37_in_parametersConstOneToMany8129); if (state.failed) return retval;
                    	PushFollow(FOLLOW_user_constonetomanyparameters_in_parametersConstOneToMany8132);
                    	user_constonetomanyparameters160 = user_constonetomanyparameters();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  					_paramExpr = _paramExpr.Insert(0, "user.");
                    	  				
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1448:7: -> {$user_constonetomanyparameters.st}
                    	  {
                    	      retval.ST = ((user_constonetomanyparameters160 != null) ? user_constonetomanyparameters160.ST : null);
                    	  }

                    	}
                    }
                    break;
                case 2 :
                    // Output\\FiltersLanguageGrammar.g:1450:5: 'u.' user_constonetomanyparameters
                    {
                    	Match(input,38,FOLLOW_38_in_parametersConstOneToMany8152); if (state.failed) return retval;
                    	PushFollow(FOLLOW_user_constonetomanyparameters_in_parametersConstOneToMany8155);
                    	user_constonetomanyparameters161 = user_constonetomanyparameters();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  					_paramExpr = _paramExpr.Insert(0, "u.");
                    	  				
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1453:7: -> {$user_constonetomanyparameters.st}
                    	  {
                    	      retval.ST = ((user_constonetomanyparameters161 != null) ? user_constonetomanyparameters161.ST : null);
                    	  }

                    	}
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "parametersConstOneToMany"

    public class parametersTextifyOneToMany_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "parametersTextifyOneToMany"
    // Output\\FiltersLanguageGrammar.g:1456:1: parametersTextifyOneToMany : ( 'user.' user_textifyonetomanyparameters -> {$user_textifyonetomanyparameters.st} | 'u.' user_textifyonetomanyparameters -> {$user_textifyonetomanyparameters.st});
    public FiltersLanguageGrammarParser.parametersTextifyOneToMany_return parametersTextifyOneToMany() // throws RecognitionException [1]
    {   
        FiltersLanguageGrammarParser.parametersTextifyOneToMany_return retval = new FiltersLanguageGrammarParser.parametersTextifyOneToMany_return();
        retval.Start = input.LT(1);

        FiltersLanguageGrammarParser.user_textifyonetomanyparameters_return user_textifyonetomanyparameters162 = default(FiltersLanguageGrammarParser.user_textifyonetomanyparameters_return);

        FiltersLanguageGrammarParser.user_textifyonetomanyparameters_return user_textifyonetomanyparameters163 = default(FiltersLanguageGrammarParser.user_textifyonetomanyparameters_return);


        try 
    	{
            // Output\\FiltersLanguageGrammar.g:1456:29: ( 'user.' user_textifyonetomanyparameters -> {$user_textifyonetomanyparameters.st} | 'u.' user_textifyonetomanyparameters -> {$user_textifyonetomanyparameters.st})
            int alt39 = 2;
            int LA39_0 = input.LA(1);

            if ( (LA39_0 == 37) )
            {
                alt39 = 1;
            }
            else if ( (LA39_0 == 38) )
            {
                alt39 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d39s0 =
                    new NoViableAltException("", 39, 0, input);

                throw nvae_d39s0;
            }
            switch (alt39) 
            {
                case 1 :
                    // Output\\FiltersLanguageGrammar.g:1457:5: 'user.' user_textifyonetomanyparameters
                    {
                    	Match(input,37,FOLLOW_37_in_parametersTextifyOneToMany8189); if (state.failed) return retval;
                    	PushFollow(FOLLOW_user_textifyonetomanyparameters_in_parametersTextifyOneToMany8192);
                    	user_textifyonetomanyparameters162 = user_textifyonetomanyparameters();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  					_paramExpr = _paramExpr.Insert(0, "user.");
                    	  				
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1460:7: -> {$user_textifyonetomanyparameters.st}
                    	  {
                    	      retval.ST = ((user_textifyonetomanyparameters162 != null) ? user_textifyonetomanyparameters162.ST : null);
                    	  }

                    	}
                    }
                    break;
                case 2 :
                    // Output\\FiltersLanguageGrammar.g:1462:5: 'u.' user_textifyonetomanyparameters
                    {
                    	Match(input,38,FOLLOW_38_in_parametersTextifyOneToMany8212); if (state.failed) return retval;
                    	PushFollow(FOLLOW_user_textifyonetomanyparameters_in_parametersTextifyOneToMany8215);
                    	user_textifyonetomanyparameters163 = user_textifyonetomanyparameters();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  					_paramExpr = _paramExpr.Insert(0, "u.");
                    	  				
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1465:7: -> {$user_textifyonetomanyparameters.st}
                    	  {
                    	      retval.ST = ((user_textifyonetomanyparameters163 != null) ? user_textifyonetomanyparameters163.ST : null);
                    	  }

                    	}
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "parametersTextifyOneToMany"

    public class parametersTableMappedOneToMany_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "parametersTableMappedOneToMany"
    // Output\\FiltersLanguageGrammar.g:1468:1: parametersTableMappedOneToMany : ( 'user.' user_tablemappedonetomanyparameters -> {$user_tablemappedonetomanyparameters.st} | 'u.' user_tablemappedonetomanyparameters -> {$user_tablemappedonetomanyparameters.st});
    public FiltersLanguageGrammarParser.parametersTableMappedOneToMany_return parametersTableMappedOneToMany() // throws RecognitionException [1]
    {   
        FiltersLanguageGrammarParser.parametersTableMappedOneToMany_return retval = new FiltersLanguageGrammarParser.parametersTableMappedOneToMany_return();
        retval.Start = input.LT(1);

        FiltersLanguageGrammarParser.user_tablemappedonetomanyparameters_return user_tablemappedonetomanyparameters164 = default(FiltersLanguageGrammarParser.user_tablemappedonetomanyparameters_return);

        FiltersLanguageGrammarParser.user_tablemappedonetomanyparameters_return user_tablemappedonetomanyparameters165 = default(FiltersLanguageGrammarParser.user_tablemappedonetomanyparameters_return);


        try 
    	{
            // Output\\FiltersLanguageGrammar.g:1468:32: ( 'user.' user_tablemappedonetomanyparameters -> {$user_tablemappedonetomanyparameters.st} | 'u.' user_tablemappedonetomanyparameters -> {$user_tablemappedonetomanyparameters.st})
            int alt40 = 2;
            int LA40_0 = input.LA(1);

            if ( (LA40_0 == 37) )
            {
                alt40 = 1;
            }
            else if ( (LA40_0 == 38) )
            {
                alt40 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d40s0 =
                    new NoViableAltException("", 40, 0, input);

                throw nvae_d40s0;
            }
            switch (alt40) 
            {
                case 1 :
                    // Output\\FiltersLanguageGrammar.g:1469:5: 'user.' user_tablemappedonetomanyparameters
                    {
                    	Match(input,37,FOLLOW_37_in_parametersTableMappedOneToMany8248); if (state.failed) return retval;
                    	PushFollow(FOLLOW_user_tablemappedonetomanyparameters_in_parametersTableMappedOneToMany8251);
                    	user_tablemappedonetomanyparameters164 = user_tablemappedonetomanyparameters();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  					_paramExpr = _paramExpr.Insert(0, "user.");
                    	  				
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1472:7: -> {$user_tablemappedonetomanyparameters.st}
                    	  {
                    	      retval.ST = ((user_tablemappedonetomanyparameters164 != null) ? user_tablemappedonetomanyparameters164.ST : null);
                    	  }

                    	}
                    }
                    break;
                case 2 :
                    // Output\\FiltersLanguageGrammar.g:1474:5: 'u.' user_tablemappedonetomanyparameters
                    {
                    	Match(input,38,FOLLOW_38_in_parametersTableMappedOneToMany8271); if (state.failed) return retval;
                    	PushFollow(FOLLOW_user_tablemappedonetomanyparameters_in_parametersTableMappedOneToMany8274);
                    	user_tablemappedonetomanyparameters165 = user_tablemappedonetomanyparameters();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  					_paramExpr = _paramExpr.Insert(0, "u.");
                    	  				
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1477:7: -> {$user_tablemappedonetomanyparameters.st}
                    	  {
                    	      retval.ST = ((user_tablemappedonetomanyparameters165 != null) ? user_tablemappedonetomanyparameters165.ST : null);
                    	  }

                    	}
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "parametersTableMappedOneToMany"

    public class token_for_fts_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "token_for_fts"
    // Output\\FiltersLanguageGrammar.g:1483:1: token_for_fts : a= STRING -> fts_val(val=$a.Text);
    public FiltersLanguageGrammarParser.token_for_fts_return token_for_fts() // throws RecognitionException [1]
    {   
        FiltersLanguageGrammarParser.token_for_fts_return retval = new FiltersLanguageGrammarParser.token_for_fts_return();
        retval.Start = input.LT(1);

        IToken a = null;

        try 
    	{
            // Output\\FiltersLanguageGrammar.g:1483:16: (a= STRING -> fts_val(val=$a.Text))
            // Output\\FiltersLanguageGrammar.g:1483:18: a= STRING
            {
            	a=(IToken)Match(input,STRING,FOLLOW_STRING_in_token_for_fts8314); if (state.failed) return retval;
            	if ( (state.backtracking==0) )
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
            	  						
            	}


            	// TEMPLATE REWRITE
            	if ( (state.backtracking==0) )
            	{
            	  // 1497:21: -> fts_val(val=$a.Text)
            	  {
            	      retval.ST = templateLib.GetInstanceOf("fts_val",
            	    new STAttrMap().Add("val", a.Text));
            	  }

            	}
            }

            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "token_for_fts"

    public class user_tablemappedonetomanyparameters_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "user_tablemappedonetomanyparameters"
    // Output\\FiltersLanguageGrammar.g:1502:1: user_tablemappedonetomanyparameters : 'gg' -> user_type_gg();
    public FiltersLanguageGrammarParser.user_tablemappedonetomanyparameters_return user_tablemappedonetomanyparameters() // throws RecognitionException [1]
    {   
        FiltersLanguageGrammarParser.user_tablemappedonetomanyparameters_return retval = new FiltersLanguageGrammarParser.user_tablemappedonetomanyparameters_return();
        retval.Start = input.LT(1);

        try 
    	{
            // Output\\FiltersLanguageGrammar.g:1502:36: ( 'gg' -> user_type_gg())
            // Output\\FiltersLanguageGrammar.g:1503:5: 'gg'
            {
            	Match(input,39,FOLLOW_39_in_user_tablemappedonetomanyparameters8362); if (state.failed) return retval;
            	if ( (state.backtracking==0) )
            	{

            	  					_paramExpr = "";
            	  					_paramExpr += "gg";
            	  				
            	}


            	// TEMPLATE REWRITE
            	if ( (state.backtracking==0) )
            	{
            	  // 1507:7: -> user_type_gg()
            	  {
            	      retval.ST = templateLib.GetInstanceOf("user_type_gg");
            	  }

            	}
            }

            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "user_tablemappedonetomanyparameters"

    public class user_userparameters_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "user_userparameters"
    // Output\\FiltersLanguageGrammar.g:1509:1: user_userparameters : ;
    public FiltersLanguageGrammarParser.user_userparameters_return user_userparameters() // throws RecognitionException [1]
    {   
        FiltersLanguageGrammarParser.user_userparameters_return retval = new FiltersLanguageGrammarParser.user_userparameters_return();
        retval.Start = input.LT(1);

        try 
    	{
            // Output\\FiltersLanguageGrammar.g:1509:20: ()
            // Output\\FiltersLanguageGrammar.g:1511:1: 
            {
            }

            retval.Stop = input.LT(-1);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "user_userparameters"

    public class user_longstringparameters_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "user_longstringparameters"
    // Output\\FiltersLanguageGrammar.g:1512:1: user_longstringparameters : 'super_power' -> user_type_super_power();
    public FiltersLanguageGrammarParser.user_longstringparameters_return user_longstringparameters() // throws RecognitionException [1]
    {   
        FiltersLanguageGrammarParser.user_longstringparameters_return retval = new FiltersLanguageGrammarParser.user_longstringparameters_return();
        retval.Start = input.LT(1);

        try 
    	{
            // Output\\FiltersLanguageGrammar.g:1512:26: ( 'super_power' -> user_type_super_power())
            // Output\\FiltersLanguageGrammar.g:1513:5: 'super_power'
            {
            	Match(input,40,FOLLOW_40_in_user_longstringparameters8392); if (state.failed) return retval;
            	if ( (state.backtracking==0) )
            	{

            	  					_paramExpr = "";
            	  					_paramExpr += "super_power";
            	  				
            	}


            	// TEMPLATE REWRITE
            	if ( (state.backtracking==0) )
            	{
            	  // 1517:7: -> user_type_super_power()
            	  {
            	      retval.ST = templateLib.GetInstanceOf("user_type_super_power");
            	  }

            	}
            }

            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "user_longstringparameters"

    public class user_constonetomanyparameters_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "user_constonetomanyparameters"
    // Output\\FiltersLanguageGrammar.g:1519:1: user_constonetomanyparameters : ;
    public FiltersLanguageGrammarParser.user_constonetomanyparameters_return user_constonetomanyparameters() // throws RecognitionException [1]
    {   
        FiltersLanguageGrammarParser.user_constonetomanyparameters_return retval = new FiltersLanguageGrammarParser.user_constonetomanyparameters_return();
        retval.Start = input.LT(1);

        try 
    	{
            // Output\\FiltersLanguageGrammar.g:1519:30: ()
            // Output\\FiltersLanguageGrammar.g:1521:1: 
            {
            }

            retval.Stop = input.LT(-1);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "user_constonetomanyparameters"

    public class user_textifyonetomanyparameters_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "user_textifyonetomanyparameters"
    // Output\\FiltersLanguageGrammar.g:1522:1: user_textifyonetomanyparameters : ;
    public FiltersLanguageGrammarParser.user_textifyonetomanyparameters_return user_textifyonetomanyparameters() // throws RecognitionException [1]
    {   
        FiltersLanguageGrammarParser.user_textifyonetomanyparameters_return retval = new FiltersLanguageGrammarParser.user_textifyonetomanyparameters_return();
        retval.Start = input.LT(1);

        try 
    	{
            // Output\\FiltersLanguageGrammar.g:1522:32: ()
            // Output\\FiltersLanguageGrammar.g:1524:1: 
            {
            }

            retval.Stop = input.LT(-1);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "user_textifyonetomanyparameters"

    public class user_stringparameters_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "user_stringparameters"
    // Output\\FiltersLanguageGrammar.g:1525:1: user_stringparameters : ( 'name' -> user_type_name() | 'surname' -> user_type_surname());
    public FiltersLanguageGrammarParser.user_stringparameters_return user_stringparameters() // throws RecognitionException [1]
    {   
        FiltersLanguageGrammarParser.user_stringparameters_return retval = new FiltersLanguageGrammarParser.user_stringparameters_return();
        retval.Start = input.LT(1);

        try 
    	{
            // Output\\FiltersLanguageGrammar.g:1525:22: ( 'name' -> user_type_name() | 'surname' -> user_type_surname())
            int alt41 = 2;
            int LA41_0 = input.LA(1);

            if ( (LA41_0 == 41) )
            {
                alt41 = 1;
            }
            else if ( (LA41_0 == 42) )
            {
                alt41 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d41s0 =
                    new NoViableAltException("", 41, 0, input);

                throw nvae_d41s0;
            }
            switch (alt41) 
            {
                case 1 :
                    // Output\\FiltersLanguageGrammar.g:1526:5: 'name'
                    {
                    	Match(input,41,FOLLOW_41_in_user_stringparameters8428); if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  					_paramExpr = "";
                    	  					_paramExpr += "name";
                    	  				
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1530:7: -> user_type_name()
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("user_type_name");
                    	  }

                    	}
                    }
                    break;
                case 2 :
                    // Output\\FiltersLanguageGrammar.g:1532:5: 'surname'
                    {
                    	Match(input,42,FOLLOW_42_in_user_stringparameters8449); if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  					_paramExpr = "";
                    	  					_paramExpr += "surname";
                    	  				
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1536:7: -> user_type_surname()
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("user_type_surname");
                    	  }

                    	}
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "user_stringparameters"

    public class user_normaldateparameters_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "user_normaldateparameters"
    // Output\\FiltersLanguageGrammar.g:1538:1: user_normaldateparameters : ;
    public FiltersLanguageGrammarParser.user_normaldateparameters_return user_normaldateparameters() // throws RecognitionException [1]
    {   
        FiltersLanguageGrammarParser.user_normaldateparameters_return retval = new FiltersLanguageGrammarParser.user_normaldateparameters_return();
        retval.Start = input.LT(1);

        try 
    	{
            // Output\\FiltersLanguageGrammar.g:1538:26: ()
            // Output\\FiltersLanguageGrammar.g:1540:1: 
            {
            }

            retval.Stop = input.LT(-1);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "user_normaldateparameters"

    public class user_boolparameters_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "user_boolparameters"
    // Output\\FiltersLanguageGrammar.g:1541:1: user_boolparameters : ;
    public FiltersLanguageGrammarParser.user_boolparameters_return user_boolparameters() // throws RecognitionException [1]
    {   
        FiltersLanguageGrammarParser.user_boolparameters_return retval = new FiltersLanguageGrammarParser.user_boolparameters_return();
        retval.Start = input.LT(1);

        try 
    	{
            // Output\\FiltersLanguageGrammar.g:1541:20: ()
            // Output\\FiltersLanguageGrammar.g:1543:1: 
            {
            }

            retval.Stop = input.LT(-1);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "user_boolparameters"

    public class user_pastdateparameters_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "user_pastdateparameters"
    // Output\\FiltersLanguageGrammar.g:1544:1: user_pastdateparameters : 'birthdate' -> user_type_birthdate();
    public FiltersLanguageGrammarParser.user_pastdateparameters_return user_pastdateparameters() // throws RecognitionException [1]
    {   
        FiltersLanguageGrammarParser.user_pastdateparameters_return retval = new FiltersLanguageGrammarParser.user_pastdateparameters_return();
        retval.Start = input.LT(1);

        try 
    	{
            // Output\\FiltersLanguageGrammar.g:1544:24: ( 'birthdate' -> user_type_birthdate())
            // Output\\FiltersLanguageGrammar.g:1545:5: 'birthdate'
            {
            	Match(input,43,FOLLOW_43_in_user_pastdateparameters8485); if (state.failed) return retval;
            	if ( (state.backtracking==0) )
            	{

            	  					_paramExpr = "";
            	  					_paramExpr += "birthdate";
            	  				
            	}


            	// TEMPLATE REWRITE
            	if ( (state.backtracking==0) )
            	{
            	  // 1549:7: -> user_type_birthdate()
            	  {
            	      retval.ST = templateLib.GetInstanceOf("user_type_birthdate");
            	  }

            	}
            }

            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "user_pastdateparameters"

    public class user_mappedparameters_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "user_mappedparameters"
    // Output\\FiltersLanguageGrammar.g:1551:1: user_mappedparameters : 'country' -> user_type_country();
    public FiltersLanguageGrammarParser.user_mappedparameters_return user_mappedparameters() // throws RecognitionException [1]
    {   
        FiltersLanguageGrammarParser.user_mappedparameters_return retval = new FiltersLanguageGrammarParser.user_mappedparameters_return();
        retval.Start = input.LT(1);

        try 
    	{
            // Output\\FiltersLanguageGrammar.g:1551:22: ( 'country' -> user_type_country())
            // Output\\FiltersLanguageGrammar.g:1552:5: 'country'
            {
            	Match(input,44,FOLLOW_44_in_user_mappedparameters8509); if (state.failed) return retval;
            	if ( (state.backtracking==0) )
            	{

            	  					_paramExpr = "";
            	  					_paramExpr += "country";
            	  				
            	}


            	// TEMPLATE REWRITE
            	if ( (state.backtracking==0) )
            	{
            	  // 1556:7: -> user_type_country()
            	  {
            	      retval.ST = templateLib.GetInstanceOf("user_type_country");
            	  }

            	}
            }

            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "user_mappedparameters"

    public class user_intparameters_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "user_intparameters"
    // Output\\FiltersLanguageGrammar.g:1558:1: user_intparameters : 'id' -> user_type_id();
    public FiltersLanguageGrammarParser.user_intparameters_return user_intparameters() // throws RecognitionException [1]
    {   
        FiltersLanguageGrammarParser.user_intparameters_return retval = new FiltersLanguageGrammarParser.user_intparameters_return();
        retval.Start = input.LT(1);

        try 
    	{
            // Output\\FiltersLanguageGrammar.g:1558:19: ( 'id' -> user_type_id())
            // Output\\FiltersLanguageGrammar.g:1559:5: 'id'
            {
            	Match(input,45,FOLLOW_45_in_user_intparameters8533); if (state.failed) return retval;
            	if ( (state.backtracking==0) )
            	{

            	  					_paramExpr = "";
            	  					_paramExpr += "id";
            	  				
            	}


            	// TEMPLATE REWRITE
            	if ( (state.backtracking==0) )
            	{
            	  // 1563:7: -> user_type_id()
            	  {
            	      retval.ST = templateLib.GetInstanceOf("user_type_id");
            	  }

            	}
            }

            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "user_intparameters"

    public class user_manytomanyparameters_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "user_manytomanyparameters"
    // Output\\FiltersLanguageGrammar.g:1565:1: user_manytomanyparameters : 'email' -> user_type_email();
    public FiltersLanguageGrammarParser.user_manytomanyparameters_return user_manytomanyparameters() // throws RecognitionException [1]
    {   
        FiltersLanguageGrammarParser.user_manytomanyparameters_return retval = new FiltersLanguageGrammarParser.user_manytomanyparameters_return();
        retval.Start = input.LT(1);

        try 
    	{
            // Output\\FiltersLanguageGrammar.g:1565:26: ( 'email' -> user_type_email())
            // Output\\FiltersLanguageGrammar.g:1566:5: 'email'
            {
            	Match(input,46,FOLLOW_46_in_user_manytomanyparameters8557); if (state.failed) return retval;
            	if ( (state.backtracking==0) )
            	{

            	  					_paramExpr = "";
            	  					_paramExpr += "email";
            	  				
            	}


            	// TEMPLATE REWRITE
            	if ( (state.backtracking==0) )
            	{
            	  // 1570:7: -> user_type_email()
            	  {
            	      retval.ST = templateLib.GetInstanceOf("user_type_email");
            	  }

            	}
            }

            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "user_manytomanyparameters"

    public class user_columnsvisible_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "user_columnsvisible"
    // Output\\FiltersLanguageGrammar.g:1577:1: user_columnsvisible : ( 'gg' -> user_column_gg() | 'super_power' -> user_column_super_power() | 'name' -> user_column_name() | 'surname' -> user_column_surname() | 'birthdate' -> user_column_birthdate() | 'country' -> user_column_country() | 'id' -> user_column_id() | 'email' -> user_column_email());
    public FiltersLanguageGrammarParser.user_columnsvisible_return user_columnsvisible() // throws RecognitionException [1]
    {   
        FiltersLanguageGrammarParser.user_columnsvisible_return retval = new FiltersLanguageGrammarParser.user_columnsvisible_return();
        retval.Start = input.LT(1);

        try 
    	{
            // Output\\FiltersLanguageGrammar.g:1577:20: ( 'gg' -> user_column_gg() | 'super_power' -> user_column_super_power() | 'name' -> user_column_name() | 'surname' -> user_column_surname() | 'birthdate' -> user_column_birthdate() | 'country' -> user_column_country() | 'id' -> user_column_id() | 'email' -> user_column_email())
            int alt42 = 8;
            switch ( input.LA(1) ) 
            {
            case 39:
            	{
                alt42 = 1;
                }
                break;
            case 40:
            	{
                alt42 = 2;
                }
                break;
            case 41:
            	{
                alt42 = 3;
                }
                break;
            case 42:
            	{
                alt42 = 4;
                }
                break;
            case 43:
            	{
                alt42 = 5;
                }
                break;
            case 44:
            	{
                alt42 = 6;
                }
                break;
            case 45:
            	{
                alt42 = 7;
                }
                break;
            case 46:
            	{
                alt42 = 8;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d42s0 =
            	        new NoViableAltException("", 42, 0, input);

            	    throw nvae_d42s0;
            }

            switch (alt42) 
            {
                case 1 :
                    // Output\\FiltersLanguageGrammar.g:1578:5: 'gg'
                    {
                    	Match(input,39,FOLLOW_39_in_user_columnsvisible8589); if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{
                    	   
                    	  					throw new ArgumentException("Column 'gg' is not implemented!");
                    	  				
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1581:24: -> user_column_gg()
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("user_column_gg");
                    	  }

                    	}
                    }
                    break;
                case 2 :
                    // Output\\FiltersLanguageGrammar.g:1583:5: 'super_power'
                    {
                    	Match(input,40,FOLLOW_40_in_user_columnsvisible8626); if (state.failed) return retval;


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1583:23: -> user_column_super_power()
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("user_column_super_power");
                    	  }

                    	}
                    }
                    break;
                case 3 :
                    // Output\\FiltersLanguageGrammar.g:1585:5: 'name'
                    {
                    	Match(input,41,FOLLOW_41_in_user_columnsvisible8644); if (state.failed) return retval;


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1585:16: -> user_column_name()
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("user_column_name");
                    	  }

                    	}
                    }
                    break;
                case 4 :
                    // Output\\FiltersLanguageGrammar.g:1587:5: 'surname'
                    {
                    	Match(input,42,FOLLOW_42_in_user_columnsvisible8662); if (state.failed) return retval;


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1587:19: -> user_column_surname()
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("user_column_surname");
                    	  }

                    	}
                    }
                    break;
                case 5 :
                    // Output\\FiltersLanguageGrammar.g:1589:5: 'birthdate'
                    {
                    	Match(input,43,FOLLOW_43_in_user_columnsvisible8680); if (state.failed) return retval;


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1589:21: -> user_column_birthdate()
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("user_column_birthdate");
                    	  }

                    	}
                    }
                    break;
                case 6 :
                    // Output\\FiltersLanguageGrammar.g:1591:5: 'country'
                    {
                    	Match(input,44,FOLLOW_44_in_user_columnsvisible8698); if (state.failed) return retval;


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1591:19: -> user_column_country()
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("user_column_country");
                    	  }

                    	}
                    }
                    break;
                case 7 :
                    // Output\\FiltersLanguageGrammar.g:1593:5: 'id'
                    {
                    	Match(input,45,FOLLOW_45_in_user_columnsvisible8716); if (state.failed) return retval;


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1593:14: -> user_column_id()
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("user_column_id");
                    	  }

                    	}
                    }
                    break;
                case 8 :
                    // Output\\FiltersLanguageGrammar.g:1595:5: 'email'
                    {
                    	Match(input,46,FOLLOW_46_in_user_columnsvisible8734); if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{
                    	   
                    	  					throw new ArgumentException("Column 'email' is not implemented!");
                    	  				
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1598:24: -> user_column_email()
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("user_column_email");
                    	  }

                    	}
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "user_columnsvisible"

    public class columnsspec_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "columnsspec"
    // Output\\FiltersLanguageGrammar.g:1602:1: columnsspec : 'user_columns' '(' u+= user_columnsvisible ( ':' b+= valInt )? ( ',' u+= user_columnsvisible ( ':' b+= valInt )? )* ')' -> columnsST(val=$u);
    public FiltersLanguageGrammarParser.columnsspec_return columnsspec() // throws RecognitionException [1]
    {   
        FiltersLanguageGrammarParser.columnsspec_return retval = new FiltersLanguageGrammarParser.columnsspec_return();
        retval.Start = input.LT(1);

        IList list_u = null;
        IList list_b = null;
        FiltersLanguageGrammarParser.user_columnsvisible_return u = default(FiltersLanguageGrammarParser.user_columnsvisible_return);
         u = null;
        FiltersLanguageGrammarParser.valInt_return b = default(FiltersLanguageGrammarParser.valInt_return);
         b = null;
        try 
    	{
            // Output\\FiltersLanguageGrammar.g:1602:13: ( 'user_columns' '(' u+= user_columnsvisible ( ':' b+= valInt )? ( ',' u+= user_columnsvisible ( ':' b+= valInt )? )* ')' -> columnsST(val=$u))
            // Output\\FiltersLanguageGrammar.g:1603:5: 'user_columns' '(' u+= user_columnsvisible ( ':' b+= valInt )? ( ',' u+= user_columnsvisible ( ':' b+= valInt )? )* ')'
            {
            	Match(input,47,FOLLOW_47_in_columnsspec8777); if (state.failed) return retval;
            	Match(input,10,FOLLOW_10_in_columnsspec8779); if (state.failed) return retval;
            	PushFollow(FOLLOW_user_columnsvisible_in_columnsspec8785);
            	u = user_columnsvisible();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if (list_u == null) list_u = new ArrayList();
            	list_u.Add(u.Template);

            	// Output\\FiltersLanguageGrammar.g:1603:49: ( ':' b+= valInt )?
            	int alt43 = 2;
            	int LA43_0 = input.LA(1);

            	if ( (LA43_0 == 48) )
            	{
            	    alt43 = 1;
            	}
            	switch (alt43) 
            	{
            	    case 1 :
            	        // Output\\FiltersLanguageGrammar.g:1603:50: ':' b+= valInt
            	        {
            	        	Match(input,48,FOLLOW_48_in_columnsspec8788); if (state.failed) return retval;
            	        	PushFollow(FOLLOW_valInt_in_columnsspec8794);
            	        	b = valInt();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if (list_b == null) list_b = new ArrayList();
            	        	list_b.Add(b.Template);


            	        }
            	        break;

            	}

            	// Output\\FiltersLanguageGrammar.g:1603:68: ( ',' u+= user_columnsvisible ( ':' b+= valInt )? )*
            	do 
            	{
            	    int alt45 = 2;
            	    int LA45_0 = input.LA(1);

            	    if ( (LA45_0 == 17) )
            	    {
            	        alt45 = 1;
            	    }


            	    switch (alt45) 
            		{
            			case 1 :
            			    // Output\\FiltersLanguageGrammar.g:1603:69: ',' u+= user_columnsvisible ( ':' b+= valInt )?
            			    {
            			    	Match(input,17,FOLLOW_17_in_columnsspec8799); if (state.failed) return retval;
            			    	PushFollow(FOLLOW_user_columnsvisible_in_columnsspec8805);
            			    	u = user_columnsvisible();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if (list_u == null) list_u = new ArrayList();
            			    	list_u.Add(u.Template);

            			    	// Output\\FiltersLanguageGrammar.g:1603:98: ( ':' b+= valInt )?
            			    	int alt44 = 2;
            			    	int LA44_0 = input.LA(1);

            			    	if ( (LA44_0 == 48) )
            			    	{
            			    	    alt44 = 1;
            			    	}
            			    	switch (alt44) 
            			    	{
            			    	    case 1 :
            			    	        // Output\\FiltersLanguageGrammar.g:1603:99: ':' b+= valInt
            			    	        {
            			    	        	Match(input,48,FOLLOW_48_in_columnsspec8808); if (state.failed) return retval;
            			    	        	PushFollow(FOLLOW_valInt_in_columnsspec8814);
            			    	        	b = valInt();
            			    	        	state.followingStackPointer--;
            			    	        	if (state.failed) return retval;
            			    	        	if (list_b == null) list_b = new ArrayList();
            			    	        	list_b.Add(b.Template);


            			    	        }
            			    	        break;

            			    	}


            			    }
            			    break;

            			default:
            			    goto loop45;
            	    }
            	} while (true);

            	loop45:
            		;	// Stops C# compiler whining that label 'loop45' has no statements

            	Match(input,11,FOLLOW_11_in_columnsspec8821); if (state.failed) return retval;
            	if ( (state.backtracking==0) )
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
            	  				
            	}


            	// TEMPLATE REWRITE
            	if ( (state.backtracking==0) )
            	{
            	  // 1618:11: -> columnsST(val=$u)
            	  {
            	      retval.ST = templateLib.GetInstanceOf("columnsST",
            	    new STAttrMap().Add("val", list_u));
            	  }

            	}
            }

            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "columnsspec"

    public class user_sortingcolumns_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "user_sortingcolumns"
    // Output\\FiltersLanguageGrammar.g:1624:1: user_sortingcolumns : ( 'gg' -> user_sorting_column_gg() | 'super_power' -> user_sorting_column_super_power() | 'name' -> user_sorting_column_name() | 'surname' -> user_sorting_column_surname() | 'birthdate' -> user_sorting_column_birthdate() | 'country' -> user_sorting_column_country() | 'id' -> user_sorting_column_id() | 'email' -> user_sorting_column_email());
    public FiltersLanguageGrammarParser.user_sortingcolumns_return user_sortingcolumns() // throws RecognitionException [1]
    {   
        FiltersLanguageGrammarParser.user_sortingcolumns_return retval = new FiltersLanguageGrammarParser.user_sortingcolumns_return();
        retval.Start = input.LT(1);

        try 
    	{
            // Output\\FiltersLanguageGrammar.g:1624:20: ( 'gg' -> user_sorting_column_gg() | 'super_power' -> user_sorting_column_super_power() | 'name' -> user_sorting_column_name() | 'surname' -> user_sorting_column_surname() | 'birthdate' -> user_sorting_column_birthdate() | 'country' -> user_sorting_column_country() | 'id' -> user_sorting_column_id() | 'email' -> user_sorting_column_email())
            int alt46 = 8;
            switch ( input.LA(1) ) 
            {
            case 39:
            	{
                alt46 = 1;
                }
                break;
            case 40:
            	{
                alt46 = 2;
                }
                break;
            case 41:
            	{
                alt46 = 3;
                }
                break;
            case 42:
            	{
                alt46 = 4;
                }
                break;
            case 43:
            	{
                alt46 = 5;
                }
                break;
            case 44:
            	{
                alt46 = 6;
                }
                break;
            case 45:
            	{
                alt46 = 7;
                }
                break;
            case 46:
            	{
                alt46 = 8;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d46s0 =
            	        new NoViableAltException("", 46, 0, input);

            	    throw nvae_d46s0;
            }

            switch (alt46) 
            {
                case 1 :
                    // Output\\FiltersLanguageGrammar.g:1625:5: 'gg'
                    {
                    	Match(input,39,FOLLOW_39_in_user_sortingcolumns8863); if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{
                    	   
                    	  					throw new ArgumentException("Order by 'gg' is not implemented!");
                    	  				
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1628:24: -> user_sorting_column_gg()
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("user_sorting_column_gg");
                    	  }

                    	}
                    }
                    break;
                case 2 :
                    // Output\\FiltersLanguageGrammar.g:1630:5: 'super_power'
                    {
                    	Match(input,40,FOLLOW_40_in_user_sortingcolumns8904); if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  					SortingColumn = "super_power";
                    	  				
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1633:15: -> user_sorting_column_super_power()
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("user_sorting_column_super_power");
                    	  }

                    	}
                    }
                    break;
                case 3 :
                    // Output\\FiltersLanguageGrammar.g:1635:5: 'name'
                    {
                    	Match(input,41,FOLLOW_41_in_user_sortingcolumns8936); if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  					SortingColumn = "name";
                    	  				
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1638:15: -> user_sorting_column_name()
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("user_sorting_column_name");
                    	  }

                    	}
                    }
                    break;
                case 4 :
                    // Output\\FiltersLanguageGrammar.g:1640:5: 'surname'
                    {
                    	Match(input,42,FOLLOW_42_in_user_sortingcolumns8968); if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  					SortingColumn = "surname";
                    	  				
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1643:15: -> user_sorting_column_surname()
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("user_sorting_column_surname");
                    	  }

                    	}
                    }
                    break;
                case 5 :
                    // Output\\FiltersLanguageGrammar.g:1645:5: 'birthdate'
                    {
                    	Match(input,43,FOLLOW_43_in_user_sortingcolumns9000); if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  					SortingColumn = "birthdate";
                    	  				
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1648:15: -> user_sorting_column_birthdate()
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("user_sorting_column_birthdate");
                    	  }

                    	}
                    }
                    break;
                case 6 :
                    // Output\\FiltersLanguageGrammar.g:1650:5: 'country'
                    {
                    	Match(input,44,FOLLOW_44_in_user_sortingcolumns9032); if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  					SortingColumn = "country";
                    	  				
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1653:15: -> user_sorting_column_country()
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("user_sorting_column_country");
                    	  }

                    	}
                    }
                    break;
                case 7 :
                    // Output\\FiltersLanguageGrammar.g:1655:5: 'id'
                    {
                    	Match(input,45,FOLLOW_45_in_user_sortingcolumns9064); if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  					SortingColumn = "id";
                    	  				
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1658:15: -> user_sorting_column_id()
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("user_sorting_column_id");
                    	  }

                    	}
                    }
                    break;
                case 8 :
                    // Output\\FiltersLanguageGrammar.g:1660:5: 'email'
                    {
                    	Match(input,46,FOLLOW_46_in_user_sortingcolumns9096); if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{
                    	   
                    	  					throw new ArgumentException("Order by 'email' is not implemented!");
                    	  				
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1663:24: -> user_sorting_column_email()
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("user_sorting_column_email");
                    	  }

                    	}
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "user_sortingcolumns"

    public class sortingdir_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "sortingdir"
    // Output\\FiltersLanguageGrammar.g:1667:1: sortingdir : ( '+' -> ascending() | '-' -> descending());
    public FiltersLanguageGrammarParser.sortingdir_return sortingdir() // throws RecognitionException [1]
    {   
        FiltersLanguageGrammarParser.sortingdir_return retval = new FiltersLanguageGrammarParser.sortingdir_return();
        retval.Start = input.LT(1);

        try 
    	{
            // Output\\FiltersLanguageGrammar.g:1667:15: ( '+' -> ascending() | '-' -> descending())
            int alt47 = 2;
            int LA47_0 = input.LA(1);

            if ( (LA47_0 == 49) )
            {
                alt47 = 1;
            }
            else if ( (LA47_0 == 50) )
            {
                alt47 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d47s0 =
                    new NoViableAltException("", 47, 0, input);

                throw nvae_d47s0;
            }
            switch (alt47) 
            {
                case 1 :
                    // Output\\FiltersLanguageGrammar.g:1667:17: '+'
                    {
                    	Match(input,49,FOLLOW_49_in_sortingdir9142); if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  								SortingDirection =	"ascending";
                    	  							
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1670:15: -> ascending()
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("ascending");
                    	  }

                    	}
                    }
                    break;
                case 2 :
                    // Output\\FiltersLanguageGrammar.g:1671:9: '-'
                    {
                    	Match(input,50,FOLLOW_50_in_sortingdir9172); if (state.failed) return retval;
                    	if ( (state.backtracking==0) )
                    	{

                    	  								SortingDirection = "descending";
                    	  							
                    	}


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1674:15: -> descending()
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("descending");
                    	  }

                    	}
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "sortingdir"

    public class sortingspec_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "sortingspec"
    // Output\\FiltersLanguageGrammar.g:1677:1: sortingspec : 'user_sorted_by' ':' user_sortingcolumns sortingdir -> sortingST(col=$user_sortingcolumns.stdir=$sortingdir.st);
    public FiltersLanguageGrammarParser.sortingspec_return sortingspec() // throws RecognitionException [1]
    {   
        FiltersLanguageGrammarParser.sortingspec_return retval = new FiltersLanguageGrammarParser.sortingspec_return();
        retval.Start = input.LT(1);

        FiltersLanguageGrammarParser.user_sortingcolumns_return user_sortingcolumns166 = default(FiltersLanguageGrammarParser.user_sortingcolumns_return);

        FiltersLanguageGrammarParser.sortingdir_return sortingdir167 = default(FiltersLanguageGrammarParser.sortingdir_return);


        try 
    	{
            // Output\\FiltersLanguageGrammar.g:1677:13: ( 'user_sorted_by' ':' user_sortingcolumns sortingdir -> sortingST(col=$user_sortingcolumns.stdir=$sortingdir.st))
            // Output\\FiltersLanguageGrammar.g:1678:5: 'user_sorted_by' ':' user_sortingcolumns sortingdir
            {
            	Match(input,51,FOLLOW_51_in_sortingspec9211); if (state.failed) return retval;
            	Match(input,48,FOLLOW_48_in_sortingspec9213); if (state.failed) return retval;
            	PushFollow(FOLLOW_user_sortingcolumns_in_sortingspec9215);
            	user_sortingcolumns166 = user_sortingcolumns();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	PushFollow(FOLLOW_sortingdir_in_sortingspec9217);
            	sortingdir167 = sortingdir();
            	state.followingStackPointer--;
            	if (state.failed) return retval;


            	// TEMPLATE REWRITE
            	if ( (state.backtracking==0) )
            	{
            	  // 1678:57: -> sortingST(col=$user_sortingcolumns.stdir=$sortingdir.st)
            	  {
            	      retval.ST = templateLib.GetInstanceOf("sortingST",
            	    new STAttrMap().Add("col", ((user_sortingcolumns166 != null) ? user_sortingcolumns166.ST : null)).Add("dir", ((sortingdir167 != null) ? sortingdir167.ST : null)));
            	  }

            	}
            }

            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "sortingspec"

    public class internalLongStrOp_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "internalLongStrOp"
    // Output\\FiltersLanguageGrammar.g:1684:1: internalLongStrOp : ( '=' -> like() | '!=' -> notlike());
    public FiltersLanguageGrammarParser.internalLongStrOp_return internalLongStrOp() // throws RecognitionException [1]
    {   
        FiltersLanguageGrammarParser.internalLongStrOp_return retval = new FiltersLanguageGrammarParser.internalLongStrOp_return();
        retval.Start = input.LT(1);

        try 
    	{
            // Output\\FiltersLanguageGrammar.g:1684:20: ( '=' -> like() | '!=' -> notlike())
            int alt48 = 2;
            int LA48_0 = input.LA(1);

            if ( (LA48_0 == 52) )
            {
                alt48 = 1;
            }
            else if ( (LA48_0 == 53) )
            {
                alt48 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d48s0 =
                    new NoViableAltException("", 48, 0, input);

                throw nvae_d48s0;
            }
            switch (alt48) 
            {
                case 1 :
                    // Output\\FiltersLanguageGrammar.g:1684:22: '='
                    {
                    	Match(input,52,FOLLOW_52_in_internalLongStrOp9254); if (state.failed) return retval;


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1684:30: -> like()
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("like");
                    	  }

                    	}
                    }
                    break;
                case 2 :
                    // Output\\FiltersLanguageGrammar.g:1685:9: '!='
                    {
                    	Match(input,53,FOLLOW_53_in_internalLongStrOp9274); if (state.failed) return retval;


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1685:17: -> notlike()
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("notlike");
                    	  }

                    	}
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "internalLongStrOp"

    public class internalopSpan_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "internalopSpan"
    // Output\\FiltersLanguageGrammar.g:1688:1: internalopSpan : ( '=' -> between() | '!=' -> notbetween());
    public FiltersLanguageGrammarParser.internalopSpan_return internalopSpan() // throws RecognitionException [1]
    {   
        FiltersLanguageGrammarParser.internalopSpan_return retval = new FiltersLanguageGrammarParser.internalopSpan_return();
        retval.Start = input.LT(1);

        try 
    	{
            // Output\\FiltersLanguageGrammar.g:1688:18: ( '=' -> between() | '!=' -> notbetween())
            int alt49 = 2;
            int LA49_0 = input.LA(1);

            if ( (LA49_0 == 52) )
            {
                alt49 = 1;
            }
            else if ( (LA49_0 == 53) )
            {
                alt49 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d49s0 =
                    new NoViableAltException("", 49, 0, input);

                throw nvae_d49s0;
            }
            switch (alt49) 
            {
                case 1 :
                    // Output\\FiltersLanguageGrammar.g:1688:20: '='
                    {
                    	Match(input,52,FOLLOW_52_in_internalopSpan9300); if (state.failed) return retval;


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1688:28: -> between()
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("between");
                    	  }

                    	}
                    }
                    break;
                case 2 :
                    // Output\\FiltersLanguageGrammar.g:1689:9: '!='
                    {
                    	Match(input,53,FOLLOW_53_in_internalopSpan9320); if (state.failed) return retval;


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1689:17: -> notbetween()
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("notbetween");
                    	  }

                    	}
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "internalopSpan"

    public class grOpSpan_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "grOpSpan"
    // Output\\FiltersLanguageGrammar.g:1692:1: grOpSpan : '>' -> greater();
    public FiltersLanguageGrammarParser.grOpSpan_return grOpSpan() // throws RecognitionException [1]
    {   
        FiltersLanguageGrammarParser.grOpSpan_return retval = new FiltersLanguageGrammarParser.grOpSpan_return();
        retval.Start = input.LT(1);

        try 
    	{
            // Output\\FiltersLanguageGrammar.g:1692:13: ( '>' -> greater())
            // Output\\FiltersLanguageGrammar.g:1692:15: '>'
            {
            	Match(input,54,FOLLOW_54_in_grOpSpan9347); if (state.failed) return retval;


            	// TEMPLATE REWRITE
            	if ( (state.backtracking==0) )
            	{
            	  // 1692:23: -> greater()
            	  {
            	      retval.ST = templateLib.GetInstanceOf("greater");
            	  }

            	}
            }

            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "grOpSpan"

    public class grOrEqOpSpan_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "grOrEqOpSpan"
    // Output\\FiltersLanguageGrammar.g:1695:1: grOrEqOpSpan : '>=' -> greaterequal();
    public FiltersLanguageGrammarParser.grOrEqOpSpan_return grOrEqOpSpan() // throws RecognitionException [1]
    {   
        FiltersLanguageGrammarParser.grOrEqOpSpan_return retval = new FiltersLanguageGrammarParser.grOrEqOpSpan_return();
        retval.Start = input.LT(1);

        try 
    	{
            // Output\\FiltersLanguageGrammar.g:1695:16: ( '>=' -> greaterequal())
            // Output\\FiltersLanguageGrammar.g:1695:18: '>='
            {
            	Match(input,55,FOLLOW_55_in_grOrEqOpSpan9374); if (state.failed) return retval;


            	// TEMPLATE REWRITE
            	if ( (state.backtracking==0) )
            	{
            	  // 1695:26: -> greaterequal()
            	  {
            	      retval.ST = templateLib.GetInstanceOf("greaterequal");
            	  }

            	}
            }

            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "grOrEqOpSpan"

    public class lsOpSpan_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "lsOpSpan"
    // Output\\FiltersLanguageGrammar.g:1698:1: lsOpSpan : '<' -> less();
    public FiltersLanguageGrammarParser.lsOpSpan_return lsOpSpan() // throws RecognitionException [1]
    {   
        FiltersLanguageGrammarParser.lsOpSpan_return retval = new FiltersLanguageGrammarParser.lsOpSpan_return();
        retval.Start = input.LT(1);

        try 
    	{
            // Output\\FiltersLanguageGrammar.g:1698:13: ( '<' -> less())
            // Output\\FiltersLanguageGrammar.g:1698:15: '<'
            {
            	Match(input,56,FOLLOW_56_in_lsOpSpan9401); if (state.failed) return retval;


            	// TEMPLATE REWRITE
            	if ( (state.backtracking==0) )
            	{
            	  // 1698:23: -> less()
            	  {
            	      retval.ST = templateLib.GetInstanceOf("less");
            	  }

            	}
            }

            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "lsOpSpan"

    public class lsOrEqOpSpan_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "lsOrEqOpSpan"
    // Output\\FiltersLanguageGrammar.g:1701:1: lsOrEqOpSpan : '<=' -> lessequal();
    public FiltersLanguageGrammarParser.lsOrEqOpSpan_return lsOrEqOpSpan() // throws RecognitionException [1]
    {   
        FiltersLanguageGrammarParser.lsOrEqOpSpan_return retval = new FiltersLanguageGrammarParser.lsOrEqOpSpan_return();
        retval.Start = input.LT(1);

        try 
    	{
            // Output\\FiltersLanguageGrammar.g:1701:16: ( '<=' -> lessequal())
            // Output\\FiltersLanguageGrammar.g:1701:18: '<='
            {
            	Match(input,57,FOLLOW_57_in_lsOrEqOpSpan9428); if (state.failed) return retval;


            	// TEMPLATE REWRITE
            	if ( (state.backtracking==0) )
            	{
            	  // 1701:26: -> lessequal()
            	  {
            	      retval.ST = templateLib.GetInstanceOf("lessequal");
            	  }

            	}
            }

            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "lsOrEqOpSpan"

    public class internalop_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "internalop"
    // Output\\FiltersLanguageGrammar.g:1704:1: internalop : ( '=' -> equals() | '>' -> greater() | '<' -> less() | '>=' -> greaterequal() | '<=' -> lessequal() | '!=' -> notequal());
    public FiltersLanguageGrammarParser.internalop_return internalop() // throws RecognitionException [1]
    {   
        FiltersLanguageGrammarParser.internalop_return retval = new FiltersLanguageGrammarParser.internalop_return();
        retval.Start = input.LT(1);

        try 
    	{
            // Output\\FiltersLanguageGrammar.g:1704:15: ( '=' -> equals() | '>' -> greater() | '<' -> less() | '>=' -> greaterequal() | '<=' -> lessequal() | '!=' -> notequal())
            int alt50 = 6;
            switch ( input.LA(1) ) 
            {
            case 52:
            	{
                alt50 = 1;
                }
                break;
            case 54:
            	{
                alt50 = 2;
                }
                break;
            case 56:
            	{
                alt50 = 3;
                }
                break;
            case 55:
            	{
                alt50 = 4;
                }
                break;
            case 57:
            	{
                alt50 = 5;
                }
                break;
            case 53:
            	{
                alt50 = 6;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d50s0 =
            	        new NoViableAltException("", 50, 0, input);

            	    throw nvae_d50s0;
            }

            switch (alt50) 
            {
                case 1 :
                    // Output\\FiltersLanguageGrammar.g:1704:17: '='
                    {
                    	Match(input,52,FOLLOW_52_in_internalop9455); if (state.failed) return retval;


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1704:25: -> equals()
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("equals");
                    	  }

                    	}
                    }
                    break;
                case 2 :
                    // Output\\FiltersLanguageGrammar.g:1705:9: '>'
                    {
                    	Match(input,54,FOLLOW_54_in_internalop9475); if (state.failed) return retval;


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1705:17: -> greater()
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("greater");
                    	  }

                    	}
                    }
                    break;
                case 3 :
                    // Output\\FiltersLanguageGrammar.g:1706:9: '<'
                    {
                    	Match(input,56,FOLLOW_56_in_internalop9495); if (state.failed) return retval;


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1706:17: -> less()
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("less");
                    	  }

                    	}
                    }
                    break;
                case 4 :
                    // Output\\FiltersLanguageGrammar.g:1707:9: '>='
                    {
                    	Match(input,55,FOLLOW_55_in_internalop9515); if (state.failed) return retval;


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1707:17: -> greaterequal()
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("greaterequal");
                    	  }

                    	}
                    }
                    break;
                case 5 :
                    // Output\\FiltersLanguageGrammar.g:1708:9: '<='
                    {
                    	Match(input,57,FOLLOW_57_in_internalop9534); if (state.failed) return retval;


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1708:17: -> lessequal()
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("lessequal");
                    	  }

                    	}
                    }
                    break;
                case 6 :
                    // Output\\FiltersLanguageGrammar.g:1709:9: '!='
                    {
                    	Match(input,53,FOLLOW_53_in_internalop9553); if (state.failed) return retval;


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1709:17: -> notequal()
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("notequal");
                    	  }

                    	}
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "internalop"

    public class internalopN2M_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "internalopN2M"
    // Output\\FiltersLanguageGrammar.g:1712:1: internalopN2M : ( '=' -> equals() | '>' -> greater() | '<' -> less() | '>=' -> greaterequal() | '<=' -> lessequal());
    public FiltersLanguageGrammarParser.internalopN2M_return internalopN2M() // throws RecognitionException [1]
    {   
        FiltersLanguageGrammarParser.internalopN2M_return retval = new FiltersLanguageGrammarParser.internalopN2M_return();
        retval.Start = input.LT(1);

        try 
    	{
            // Output\\FiltersLanguageGrammar.g:1712:17: ( '=' -> equals() | '>' -> greater() | '<' -> less() | '>=' -> greaterequal() | '<=' -> lessequal())
            int alt51 = 5;
            switch ( input.LA(1) ) 
            {
            case 52:
            	{
                alt51 = 1;
                }
                break;
            case 54:
            	{
                alt51 = 2;
                }
                break;
            case 56:
            	{
                alt51 = 3;
                }
                break;
            case 55:
            	{
                alt51 = 4;
                }
                break;
            case 57:
            	{
                alt51 = 5;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d51s0 =
            	        new NoViableAltException("", 51, 0, input);

            	    throw nvae_d51s0;
            }

            switch (alt51) 
            {
                case 1 :
                    // Output\\FiltersLanguageGrammar.g:1712:19: '='
                    {
                    	Match(input,52,FOLLOW_52_in_internalopN2M9579); if (state.failed) return retval;


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1712:27: -> equals()
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("equals");
                    	  }

                    	}
                    }
                    break;
                case 2 :
                    // Output\\FiltersLanguageGrammar.g:1713:9: '>'
                    {
                    	Match(input,54,FOLLOW_54_in_internalopN2M9599); if (state.failed) return retval;


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1713:17: -> greater()
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("greater");
                    	  }

                    	}
                    }
                    break;
                case 3 :
                    // Output\\FiltersLanguageGrammar.g:1714:9: '<'
                    {
                    	Match(input,56,FOLLOW_56_in_internalopN2M9619); if (state.failed) return retval;


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1714:17: -> less()
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("less");
                    	  }

                    	}
                    }
                    break;
                case 4 :
                    // Output\\FiltersLanguageGrammar.g:1715:9: '>='
                    {
                    	Match(input,55,FOLLOW_55_in_internalopN2M9639); if (state.failed) return retval;


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1715:17: -> greaterequal()
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("greaterequal");
                    	  }

                    	}
                    }
                    break;
                case 5 :
                    // Output\\FiltersLanguageGrammar.g:1716:9: '<='
                    {
                    	Match(input,57,FOLLOW_57_in_internalopN2M9658); if (state.failed) return retval;


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1716:17: -> lessequal()
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("lessequal");
                    	  }

                    	}
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "internalopN2M"

    public class internalopNotEqN2M_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "internalopNotEqN2M"
    // Output\\FiltersLanguageGrammar.g:1719:1: internalopNotEqN2M : '!=' -> notequal();
    public FiltersLanguageGrammarParser.internalopNotEqN2M_return internalopNotEqN2M() // throws RecognitionException [1]
    {   
        FiltersLanguageGrammarParser.internalopNotEqN2M_return retval = new FiltersLanguageGrammarParser.internalopNotEqN2M_return();
        retval.Start = input.LT(1);

        try 
    	{
            // Output\\FiltersLanguageGrammar.g:1719:21: ( '!=' -> notequal())
            // Output\\FiltersLanguageGrammar.g:1719:23: '!='
            {
            	Match(input,53,FOLLOW_53_in_internalopNotEqN2M9683); if (state.failed) return retval;


            	// TEMPLATE REWRITE
            	if ( (state.backtracking==0) )
            	{
            	  // 1719:31: -> notequal()
            	  {
            	      retval.ST = templateLib.GetInstanceOf("notequal");
            	  }

            	}
            }

            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "internalopNotEqN2M"

    public class contains_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "contains"
    // Output\\FiltersLanguageGrammar.g:1722:1: contains : 'contains' -> like();
    public FiltersLanguageGrammarParser.contains_return contains() // throws RecognitionException [1]
    {   
        FiltersLanguageGrammarParser.contains_return retval = new FiltersLanguageGrammarParser.contains_return();
        retval.Start = input.LT(1);

        try 
    	{
            // Output\\FiltersLanguageGrammar.g:1722:13: ( 'contains' -> like())
            // Output\\FiltersLanguageGrammar.g:1722:15: 'contains'
            {
            	Match(input,58,FOLLOW_58_in_contains9710); if (state.failed) return retval;


            	// TEMPLATE REWRITE
            	if ( (state.backtracking==0) )
            	{
            	  // 1722:28: -> like()
            	  {
            	      retval.ST = templateLib.GetInstanceOf("like");
            	  }

            	}
            }

            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "contains"

    public class containsVal_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "containsVal"
    // Output\\FiltersLanguageGrammar.g:1725:1: containsVal : a= STRING -> contains_val(val=$STRING.text);
    public FiltersLanguageGrammarParser.containsVal_return containsVal() // throws RecognitionException [1]
    {   
        FiltersLanguageGrammarParser.containsVal_return retval = new FiltersLanguageGrammarParser.containsVal_return();
        retval.Start = input.LT(1);

        IToken a = null;

        try 
    	{
            // Output\\FiltersLanguageGrammar.g:1725:16: (a= STRING -> contains_val(val=$STRING.text))
            // Output\\FiltersLanguageGrammar.g:1725:18: a= STRING
            {
            	a=(IToken)Match(input,STRING,FOLLOW_STRING_in_containsVal9740); if (state.failed) return retval;
            	if ( (state.backtracking==0) )
            	{

            	  								a.Text = a.Text.Replace("'", "''");
            	  								a.Text = a.Text.Replace("\"", "");
            	  							
            	}


            	// TEMPLATE REWRITE
            	if ( (state.backtracking==0) )
            	{
            	  // 1729:10: -> contains_val(val=$STRING.text)
            	  {
            	      retval.ST = templateLib.GetInstanceOf("contains_val",
            	    new STAttrMap().Add("val", ((a != null) ? a.Text : null)));
            	  }

            	}
            }

            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "containsVal"

    public class startsWith_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "startsWith"
    // Output\\FiltersLanguageGrammar.g:1732:1: startsWith : 'starts_with' -> like();
    public FiltersLanguageGrammarParser.startsWith_return startsWith() // throws RecognitionException [1]
    {   
        FiltersLanguageGrammarParser.startsWith_return retval = new FiltersLanguageGrammarParser.startsWith_return();
        retval.Start = input.LT(1);

        try 
    	{
            // Output\\FiltersLanguageGrammar.g:1732:15: ( 'starts_with' -> like())
            // Output\\FiltersLanguageGrammar.g:1732:17: 'starts_with'
            {
            	Match(input,59,FOLLOW_59_in_startsWith9783); if (state.failed) return retval;


            	// TEMPLATE REWRITE
            	if ( (state.backtracking==0) )
            	{
            	  // 1732:32: -> like()
            	  {
            	      retval.ST = templateLib.GetInstanceOf("like");
            	  }

            	}
            }

            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "startsWith"

    public class startsWithVal_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "startsWithVal"
    // Output\\FiltersLanguageGrammar.g:1735:1: startsWithVal : a= STRING -> starts_with_val(val=$STRING.text);
    public FiltersLanguageGrammarParser.startsWithVal_return startsWithVal() // throws RecognitionException [1]
    {   
        FiltersLanguageGrammarParser.startsWithVal_return retval = new FiltersLanguageGrammarParser.startsWithVal_return();
        retval.Start = input.LT(1);

        IToken a = null;

        try 
    	{
            // Output\\FiltersLanguageGrammar.g:1735:17: (a= STRING -> starts_with_val(val=$STRING.text))
            // Output\\FiltersLanguageGrammar.g:1735:19: a= STRING
            {
            	a=(IToken)Match(input,STRING,FOLLOW_STRING_in_startsWithVal9811); if (state.failed) return retval;
            	if ( (state.backtracking==0) )
            	{

            	  								a.Text = a.Text.Replace("'", "''");
            	  								a.Text = a.Text.Replace("\"", "");
            	  							
            	}


            	// TEMPLATE REWRITE
            	if ( (state.backtracking==0) )
            	{
            	  // 1739:10: -> starts_with_val(val=$STRING.text)
            	  {
            	      retval.ST = templateLib.GetInstanceOf("starts_with_val",
            	    new STAttrMap().Add("val", ((a != null) ? a.Text : null)));
            	  }

            	}
            }

            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "startsWithVal"

    public class endsWith_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "endsWith"
    // Output\\FiltersLanguageGrammar.g:1742:1: endsWith : 'ends_with' -> like();
    public FiltersLanguageGrammarParser.endsWith_return endsWith() // throws RecognitionException [1]
    {   
        FiltersLanguageGrammarParser.endsWith_return retval = new FiltersLanguageGrammarParser.endsWith_return();
        retval.Start = input.LT(1);

        try 
    	{
            // Output\\FiltersLanguageGrammar.g:1742:13: ( 'ends_with' -> like())
            // Output\\FiltersLanguageGrammar.g:1742:15: 'ends_with'
            {
            	Match(input,60,FOLLOW_60_in_endsWith9853); if (state.failed) return retval;


            	// TEMPLATE REWRITE
            	if ( (state.backtracking==0) )
            	{
            	  // 1742:29: -> like()
            	  {
            	      retval.ST = templateLib.GetInstanceOf("like");
            	  }

            	}
            }

            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "endsWith"

    public class endsWithVal_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "endsWithVal"
    // Output\\FiltersLanguageGrammar.g:1745:1: endsWithVal : a= STRING -> ends_with_val(val=$STRING.text);
    public FiltersLanguageGrammarParser.endsWithVal_return endsWithVal() // throws RecognitionException [1]
    {   
        FiltersLanguageGrammarParser.endsWithVal_return retval = new FiltersLanguageGrammarParser.endsWithVal_return();
        retval.Start = input.LT(1);

        IToken a = null;

        try 
    	{
            // Output\\FiltersLanguageGrammar.g:1745:16: (a= STRING -> ends_with_val(val=$STRING.text))
            // Output\\FiltersLanguageGrammar.g:1745:18: a= STRING
            {
            	a=(IToken)Match(input,STRING,FOLLOW_STRING_in_endsWithVal9883); if (state.failed) return retval;
            	if ( (state.backtracking==0) )
            	{

            	  								a.Text = a.Text.Replace("'", "''");
            	  								a.Text = a.Text.Replace("\"", "");
            	  							
            	}


            	// TEMPLATE REWRITE
            	if ( (state.backtracking==0) )
            	{
            	  // 1749:10: -> ends_with_val(val=$STRING.text)
            	  {
            	      retval.ST = templateLib.GetInstanceOf("ends_with_val",
            	    new STAttrMap().Add("val", ((a != null) ? a.Text : null)));
            	  }

            	}
            }

            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "endsWithVal"

    public class doesNotContains_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "doesNotContains"
    // Output\\FiltersLanguageGrammar.g:1752:1: doesNotContains : 'does_not_contains' -> notlike();
    public FiltersLanguageGrammarParser.doesNotContains_return doesNotContains() // throws RecognitionException [1]
    {   
        FiltersLanguageGrammarParser.doesNotContains_return retval = new FiltersLanguageGrammarParser.doesNotContains_return();
        retval.Start = input.LT(1);

        try 
    	{
            // Output\\FiltersLanguageGrammar.g:1752:19: ( 'does_not_contains' -> notlike())
            // Output\\FiltersLanguageGrammar.g:1752:21: 'does_not_contains'
            {
            	Match(input,61,FOLLOW_61_in_doesNotContains9920); if (state.failed) return retval;


            	// TEMPLATE REWRITE
            	if ( (state.backtracking==0) )
            	{
            	  // 1752:41: -> notlike()
            	  {
            	      retval.ST = templateLib.GetInstanceOf("notlike");
            	  }

            	}
            }

            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "doesNotContains"

    public class doesNotContainsVal_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "doesNotContainsVal"
    // Output\\FiltersLanguageGrammar.g:1755:1: doesNotContainsVal : a= STRING -> does_not_contains_val(val=$STRING.text);
    public FiltersLanguageGrammarParser.doesNotContainsVal_return doesNotContainsVal() // throws RecognitionException [1]
    {   
        FiltersLanguageGrammarParser.doesNotContainsVal_return retval = new FiltersLanguageGrammarParser.doesNotContainsVal_return();
        retval.Start = input.LT(1);

        IToken a = null;

        try 
    	{
            // Output\\FiltersLanguageGrammar.g:1755:21: (a= STRING -> does_not_contains_val(val=$STRING.text))
            // Output\\FiltersLanguageGrammar.g:1755:23: a= STRING
            {
            	a=(IToken)Match(input,STRING,FOLLOW_STRING_in_doesNotContainsVal9946); if (state.failed) return retval;
            	if ( (state.backtracking==0) )
            	{

            	  								a.Text = a.Text.Replace("'", "''");
            	  								a.Text = a.Text.Replace("\"", "");
            	  							
            	}


            	// TEMPLATE REWRITE
            	if ( (state.backtracking==0) )
            	{
            	  // 1759:10: -> does_not_contains_val(val=$STRING.text)
            	  {
            	      retval.ST = templateLib.GetInstanceOf("does_not_contains_val",
            	    new STAttrMap().Add("val", ((a != null) ? a.Text : null)));
            	  }

            	}
            }

            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "doesNotContainsVal"

    public class multivalueinternalop_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "multivalueinternalop"
    // Output\\FiltersLanguageGrammar.g:1762:1: multivalueinternalop : 'in' -> in();
    public FiltersLanguageGrammarParser.multivalueinternalop_return multivalueinternalop() // throws RecognitionException [1]
    {   
        FiltersLanguageGrammarParser.multivalueinternalop_return retval = new FiltersLanguageGrammarParser.multivalueinternalop_return();
        retval.Start = input.LT(1);

        try 
    	{
            // Output\\FiltersLanguageGrammar.g:1762:22: ( 'in' -> in())
            // Output\\FiltersLanguageGrammar.g:1762:24: 'in'
            {
            	Match(input,62,FOLLOW_62_in_multivalueinternalop9981); if (state.failed) return retval;


            	// TEMPLATE REWRITE
            	if ( (state.backtracking==0) )
            	{
            	  // 1762:32: -> in()
            	  {
            	      retval.ST = templateLib.GetInstanceOf("in");
            	  }

            	}
            }

            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "multivalueinternalop"

    public class boolToken_return : ParserRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "boolToken"
    // Output\\FiltersLanguageGrammar.g:1768:1: boolToken : ( '\"true\"' -> true_bit() | '\"false\"' -> false_bit() | 'true' -> true_bit() | 'false' -> false_bit());
    public FiltersLanguageGrammarParser.boolToken_return boolToken() // throws RecognitionException [1]
    {   
        FiltersLanguageGrammarParser.boolToken_return retval = new FiltersLanguageGrammarParser.boolToken_return();
        retval.Start = input.LT(1);

        try 
    	{
            // Output\\FiltersLanguageGrammar.g:1768:11: ( '\"true\"' -> true_bit() | '\"false\"' -> false_bit() | 'true' -> true_bit() | 'false' -> false_bit())
            int alt52 = 4;
            switch ( input.LA(1) ) 
            {
            case 63:
            	{
                alt52 = 1;
                }
                break;
            case 64:
            	{
                alt52 = 2;
                }
                break;
            case 65:
            	{
                alt52 = 3;
                }
                break;
            case 66:
            	{
                alt52 = 4;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d52s0 =
            	        new NoViableAltException("", 52, 0, input);

            	    throw nvae_d52s0;
            }

            switch (alt52) 
            {
                case 1 :
                    // Output\\FiltersLanguageGrammar.g:1768:13: '\"true\"'
                    {
                    	Match(input,63,FOLLOW_63_in_boolToken10011); if (state.failed) return retval;


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1768:25: -> true_bit()
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("true_bit");
                    	  }

                    	}
                    }
                    break;
                case 2 :
                    // Output\\FiltersLanguageGrammar.g:1769:6: '\"false\"'
                    {
                    	Match(input,64,FOLLOW_64_in_boolToken10027); if (state.failed) return retval;


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1769:19: -> false_bit()
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("false_bit");
                    	  }

                    	}
                    }
                    break;
                case 3 :
                    // Output\\FiltersLanguageGrammar.g:1770:6: 'true'
                    {
                    	Match(input,65,FOLLOW_65_in_boolToken10043); if (state.failed) return retval;


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1770:17: -> true_bit()
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("true_bit");
                    	  }

                    	}
                    }
                    break;
                case 4 :
                    // Output\\FiltersLanguageGrammar.g:1771:6: 'false'
                    {
                    	Match(input,66,FOLLOW_66_in_boolToken10060); if (state.failed) return retval;


                    	// TEMPLATE REWRITE
                    	if ( (state.backtracking==0) )
                    	{
                    	  // 1771:18: -> false_bit()
                    	  {
                    	      retval.ST = templateLib.GetInstanceOf("false_bit");
                    	  }

                    	}
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "boolToken"

    // $ANTLR start "synpred1_FiltersLanguageGrammar"
    public void synpred1_FiltersLanguageGrammar_fragment() {
        FiltersLanguageGrammarParser.columnsspec_return a = default(FiltersLanguageGrammarParser.columnsspec_return);

        FiltersLanguageGrammarParser.sortingspec_return b = default(FiltersLanguageGrammarParser.sortingspec_return);


        // Output\\FiltersLanguageGrammar.g:474:9: ( logicalexpr a= columnsspec b= sortingspec )
        // Output\\FiltersLanguageGrammar.g:474:9: logicalexpr a= columnsspec b= sortingspec
        {
        	PushFollow(FOLLOW_logicalexpr_in_synpred1_FiltersLanguageGrammar114);
        	logicalexpr();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	PushFollow(FOLLOW_columnsspec_in_synpred1_FiltersLanguageGrammar120);
        	a = columnsspec();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	PushFollow(FOLLOW_sortingspec_in_synpred1_FiltersLanguageGrammar126);
        	b = sortingspec();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred1_FiltersLanguageGrammar"

    // $ANTLR start "synpred2_FiltersLanguageGrammar"
    public void synpred2_FiltersLanguageGrammar_fragment() {
        FiltersLanguageGrammarParser.columnsspec_return a = default(FiltersLanguageGrammarParser.columnsspec_return);


        // Output\\FiltersLanguageGrammar.g:479:6: ( logicalexpr a= columnsspec )
        // Output\\FiltersLanguageGrammar.g:479:6: logicalexpr a= columnsspec
        {
        	PushFollow(FOLLOW_logicalexpr_in_synpred2_FiltersLanguageGrammar171);
        	logicalexpr();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	PushFollow(FOLLOW_columnsspec_in_synpred2_FiltersLanguageGrammar177);
        	a = columnsspec();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred2_FiltersLanguageGrammar"

    // $ANTLR start "synpred3_FiltersLanguageGrammar"
    public void synpred3_FiltersLanguageGrammar_fragment() {
        FiltersLanguageGrammarParser.sortingspec_return b = default(FiltersLanguageGrammarParser.sortingspec_return);


        // Output\\FiltersLanguageGrammar.g:485:6: ( logicalexpr b= sortingspec )
        // Output\\FiltersLanguageGrammar.g:485:6: logicalexpr b= sortingspec
        {
        	PushFollow(FOLLOW_logicalexpr_in_synpred3_FiltersLanguageGrammar222);
        	logicalexpr();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	PushFollow(FOLLOW_sortingspec_in_synpred3_FiltersLanguageGrammar228);
        	b = sortingspec();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred3_FiltersLanguageGrammar"

    // $ANTLR start "synpred4_FiltersLanguageGrammar"
    public void synpred4_FiltersLanguageGrammar_fragment() {
        // Output\\FiltersLanguageGrammar.g:491:6: ( logicalexpr )
        // Output\\FiltersLanguageGrammar.g:491:6: logicalexpr
        {
        	PushFollow(FOLLOW_logicalexpr_in_synpred4_FiltersLanguageGrammar273);
        	logicalexpr();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred4_FiltersLanguageGrammar"

    // $ANTLR start "synpred6_FiltersLanguageGrammar"
    public void synpred6_FiltersLanguageGrammar_fragment() {
        FiltersLanguageGrammarParser.columnsspec_return a = default(FiltersLanguageGrammarParser.columnsspec_return);

        FiltersLanguageGrammarParser.sortingspec_return b = default(FiltersLanguageGrammarParser.sortingspec_return);


        // Output\\FiltersLanguageGrammar.g:498:6: ( '__cntl' logicalexpr a= columnsspec b= sortingspec )
        // Output\\FiltersLanguageGrammar.g:498:6: '__cntl' logicalexpr a= columnsspec b= sortingspec
        {
        	Match(input,12,FOLLOW_12_in_synpred6_FiltersLanguageGrammar342); if (state.failed) return ;
        	PushFollow(FOLLOW_logicalexpr_in_synpred6_FiltersLanguageGrammar344);
        	logicalexpr();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	PushFollow(FOLLOW_columnsspec_in_synpred6_FiltersLanguageGrammar350);
        	a = columnsspec();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	PushFollow(FOLLOW_sortingspec_in_synpred6_FiltersLanguageGrammar356);
        	b = sortingspec();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred6_FiltersLanguageGrammar"

    // $ANTLR start "synpred7_FiltersLanguageGrammar"
    public void synpred7_FiltersLanguageGrammar_fragment() {
        FiltersLanguageGrammarParser.columnsspec_return a = default(FiltersLanguageGrammarParser.columnsspec_return);


        // Output\\FiltersLanguageGrammar.g:503:6: ( '__cntl' logicalexpr a= columnsspec )
        // Output\\FiltersLanguageGrammar.g:503:6: '__cntl' logicalexpr a= columnsspec
        {
        	Match(input,12,FOLLOW_12_in_synpred7_FiltersLanguageGrammar401); if (state.failed) return ;
        	PushFollow(FOLLOW_logicalexpr_in_synpred7_FiltersLanguageGrammar403);
        	logicalexpr();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	PushFollow(FOLLOW_columnsspec_in_synpred7_FiltersLanguageGrammar409);
        	a = columnsspec();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred7_FiltersLanguageGrammar"

    // $ANTLR start "synpred8_FiltersLanguageGrammar"
    public void synpred8_FiltersLanguageGrammar_fragment() {
        FiltersLanguageGrammarParser.sortingspec_return b = default(FiltersLanguageGrammarParser.sortingspec_return);


        // Output\\FiltersLanguageGrammar.g:509:6: ( '__cntl' logicalexpr b= sortingspec )
        // Output\\FiltersLanguageGrammar.g:509:6: '__cntl' logicalexpr b= sortingspec
        {
        	Match(input,12,FOLLOW_12_in_synpred8_FiltersLanguageGrammar454); if (state.failed) return ;
        	PushFollow(FOLLOW_logicalexpr_in_synpred8_FiltersLanguageGrammar456);
        	logicalexpr();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	PushFollow(FOLLOW_sortingspec_in_synpred8_FiltersLanguageGrammar462);
        	b = sortingspec();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred8_FiltersLanguageGrammar"

    // $ANTLR start "synpred9_FiltersLanguageGrammar"
    public void synpred9_FiltersLanguageGrammar_fragment() {
        // Output\\FiltersLanguageGrammar.g:515:6: ( '__cntl' logicalexpr )
        // Output\\FiltersLanguageGrammar.g:515:6: '__cntl' logicalexpr
        {
        	Match(input,12,FOLLOW_12_in_synpred9_FiltersLanguageGrammar507); if (state.failed) return ;
        	PushFollow(FOLLOW_logicalexpr_in_synpred9_FiltersLanguageGrammar509);
        	logicalexpr();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred9_FiltersLanguageGrammar"

    // $ANTLR start "synpred10_FiltersLanguageGrammar"
    public void synpred10_FiltersLanguageGrammar_fragment() {
        // Output\\FiltersLanguageGrammar.g:521:6: ( '__cntl' 'sql' '(' query ')' )
        // Output\\FiltersLanguageGrammar.g:521:6: '__cntl' 'sql' '(' query ')'
        {
        	Match(input,12,FOLLOW_12_in_synpred10_FiltersLanguageGrammar554); if (state.failed) return ;
        	Match(input,9,FOLLOW_9_in_synpred10_FiltersLanguageGrammar556); if (state.failed) return ;
        	Match(input,10,FOLLOW_10_in_synpred10_FiltersLanguageGrammar558); if (state.failed) return ;
        	PushFollow(FOLLOW_query_in_synpred10_FiltersLanguageGrammar560);
        	query();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	Match(input,11,FOLLOW_11_in_synpred10_FiltersLanguageGrammar562); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred10_FiltersLanguageGrammar"

    // $ANTLR start "synpred11_FiltersLanguageGrammar"
    public void synpred11_FiltersLanguageGrammar_fragment() {
        FiltersLanguageGrammarParser.columnsspec_return a = default(FiltersLanguageGrammarParser.columnsspec_return);

        FiltersLanguageGrammarParser.sortingspec_return b = default(FiltersLanguageGrammarParser.sortingspec_return);


        // Output\\FiltersLanguageGrammar.g:522:6: ( '__cnt' logicalexpr a= columnsspec b= sortingspec )
        // Output\\FiltersLanguageGrammar.g:522:6: '__cnt' logicalexpr a= columnsspec b= sortingspec
        {
        	Match(input,13,FOLLOW_13_in_synpred11_FiltersLanguageGrammar584); if (state.failed) return ;
        	PushFollow(FOLLOW_logicalexpr_in_synpred11_FiltersLanguageGrammar586);
        	logicalexpr();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	PushFollow(FOLLOW_columnsspec_in_synpred11_FiltersLanguageGrammar592);
        	a = columnsspec();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	PushFollow(FOLLOW_sortingspec_in_synpred11_FiltersLanguageGrammar598);
        	b = sortingspec();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred11_FiltersLanguageGrammar"

    // $ANTLR start "synpred12_FiltersLanguageGrammar"
    public void synpred12_FiltersLanguageGrammar_fragment() {
        FiltersLanguageGrammarParser.columnsspec_return a = default(FiltersLanguageGrammarParser.columnsspec_return);


        // Output\\FiltersLanguageGrammar.g:527:6: ( '__cnt' logicalexpr a= columnsspec )
        // Output\\FiltersLanguageGrammar.g:527:6: '__cnt' logicalexpr a= columnsspec
        {
        	Match(input,13,FOLLOW_13_in_synpred12_FiltersLanguageGrammar643); if (state.failed) return ;
        	PushFollow(FOLLOW_logicalexpr_in_synpred12_FiltersLanguageGrammar645);
        	logicalexpr();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	PushFollow(FOLLOW_columnsspec_in_synpred12_FiltersLanguageGrammar651);
        	a = columnsspec();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred12_FiltersLanguageGrammar"

    // $ANTLR start "synpred13_FiltersLanguageGrammar"
    public void synpred13_FiltersLanguageGrammar_fragment() {
        FiltersLanguageGrammarParser.sortingspec_return b = default(FiltersLanguageGrammarParser.sortingspec_return);


        // Output\\FiltersLanguageGrammar.g:533:6: ( '__cnt' logicalexpr b= sortingspec )
        // Output\\FiltersLanguageGrammar.g:533:6: '__cnt' logicalexpr b= sortingspec
        {
        	Match(input,13,FOLLOW_13_in_synpred13_FiltersLanguageGrammar696); if (state.failed) return ;
        	PushFollow(FOLLOW_logicalexpr_in_synpred13_FiltersLanguageGrammar698);
        	logicalexpr();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	PushFollow(FOLLOW_sortingspec_in_synpred13_FiltersLanguageGrammar704);
        	b = sortingspec();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred13_FiltersLanguageGrammar"

    // $ANTLR start "synpred14_FiltersLanguageGrammar"
    public void synpred14_FiltersLanguageGrammar_fragment() {
        // Output\\FiltersLanguageGrammar.g:539:6: ( '__cnt' logicalexpr )
        // Output\\FiltersLanguageGrammar.g:539:6: '__cnt' logicalexpr
        {
        	Match(input,13,FOLLOW_13_in_synpred14_FiltersLanguageGrammar749); if (state.failed) return ;
        	PushFollow(FOLLOW_logicalexpr_in_synpred14_FiltersLanguageGrammar751);
        	logicalexpr();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred14_FiltersLanguageGrammar"

    // $ANTLR start "synpred35_FiltersLanguageGrammar"
    public void synpred35_FiltersLanguageGrammar_fragment() {
        // Output\\FiltersLanguageGrammar.g:582:6: ( parametersDate internalop valDate )
        // Output\\FiltersLanguageGrammar.g:582:6: parametersDate internalop valDate
        {
        	PushFollow(FOLLOW_parametersDate_in_synpred35_FiltersLanguageGrammar1698);
        	parametersDate();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	PushFollow(FOLLOW_internalop_in_synpred35_FiltersLanguageGrammar1700);
        	internalop();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	PushFollow(FOLLOW_valDate_in_synpred35_FiltersLanguageGrammar1702);
        	valDate();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred35_FiltersLanguageGrammar"

    // $ANTLR start "synpred41_FiltersLanguageGrammar"
    public void synpred41_FiltersLanguageGrammar_fragment() {
        // Output\\FiltersLanguageGrammar.g:588:6: ( parametersUser internalop valUser )
        // Output\\FiltersLanguageGrammar.g:588:6: parametersUser internalop valUser
        {
        	PushFollow(FOLLOW_parametersUser_in_synpred41_FiltersLanguageGrammar1940);
        	parametersUser();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	PushFollow(FOLLOW_internalop_in_synpred41_FiltersLanguageGrammar1942);
        	internalop();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	PushFollow(FOLLOW_valUser_in_synpred41_FiltersLanguageGrammar1944);
        	valUser();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred41_FiltersLanguageGrammar"

    // $ANTLR start "synpred49_FiltersLanguageGrammar"
    public void synpred49_FiltersLanguageGrammar_fragment() {
        IList list_c = null;
        FiltersLanguageGrammarParser.valDate_return c = default(FiltersLanguageGrammarParser.valDate_return);
         c = null;
        // Output\\FiltersLanguageGrammar.g:593:6: ( parametersDate multivalueinternalop '(' c+= valDate ( ',' c+= valDate )* ')' )
        // Output\\FiltersLanguageGrammar.g:593:6: parametersDate multivalueinternalop '(' c+= valDate ( ',' c+= valDate )* ')'
        {
        	PushFollow(FOLLOW_parametersDate_in_synpred49_FiltersLanguageGrammar2181);
        	parametersDate();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	PushFollow(FOLLOW_multivalueinternalop_in_synpred49_FiltersLanguageGrammar2183);
        	multivalueinternalop();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	Match(input,10,FOLLOW_10_in_synpred49_FiltersLanguageGrammar2185); if (state.failed) return ;
        	PushFollow(FOLLOW_valDate_in_synpred49_FiltersLanguageGrammar2191);
        	c = valDate();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	if (list_c == null) list_c = new ArrayList();
        	list_c.Add(c);

        	// Output\\FiltersLanguageGrammar.g:593:59: ( ',' c+= valDate )*
        	do 
        	{
        	    int alt55 = 2;
        	    int LA55_0 = input.LA(1);

        	    if ( (LA55_0 == 17) )
        	    {
        	        alt55 = 1;
        	    }


        	    switch (alt55) 
        		{
        			case 1 :
        			    // Output\\FiltersLanguageGrammar.g:593:60: ',' c+= valDate
        			    {
        			    	Match(input,17,FOLLOW_17_in_synpred49_FiltersLanguageGrammar2194); if (state.failed) return ;
        			    	PushFollow(FOLLOW_valDate_in_synpred49_FiltersLanguageGrammar2200);
        			    	c = valDate();
        			    	state.followingStackPointer--;
        			    	if (state.failed) return ;
        			    	if (list_c == null) list_c = new ArrayList();
        			    	list_c.Add(c);


        			    }
        			    break;

        			default:
        			    goto loop55;
        	    }
        	} while (true);

        	loop55:
        		;	// Stops C# compiler whining that label 'loop55' has no statements

        	Match(input,11,FOLLOW_11_in_synpred49_FiltersLanguageGrammar2204); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred49_FiltersLanguageGrammar"

    // $ANTLR start "synpred51_FiltersLanguageGrammar"
    public void synpred51_FiltersLanguageGrammar_fragment() {
        IList list_d = null;
        FiltersLanguageGrammarParser.valUser_return d = default(FiltersLanguageGrammarParser.valUser_return);
         d = null;
        // Output\\FiltersLanguageGrammar.g:594:6: ( parametersUser multivalueinternalop '(' d+= valUser ( ',' d+= valUser )* ')' )
        // Output\\FiltersLanguageGrammar.g:594:6: parametersUser multivalueinternalop '(' d+= valUser ( ',' d+= valUser )* ')'
        {
        	PushFollow(FOLLOW_parametersUser_in_synpred51_FiltersLanguageGrammar2236);
        	parametersUser();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	PushFollow(FOLLOW_multivalueinternalop_in_synpred51_FiltersLanguageGrammar2238);
        	multivalueinternalop();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	Match(input,10,FOLLOW_10_in_synpred51_FiltersLanguageGrammar2240); if (state.failed) return ;
        	PushFollow(FOLLOW_valUser_in_synpred51_FiltersLanguageGrammar2246);
        	d = valUser();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	if (list_d == null) list_d = new ArrayList();
        	list_d.Add(d);

        	// Output\\FiltersLanguageGrammar.g:594:59: ( ',' d+= valUser )*
        	do 
        	{
        	    int alt56 = 2;
        	    int LA56_0 = input.LA(1);

        	    if ( (LA56_0 == 17) )
        	    {
        	        alt56 = 1;
        	    }


        	    switch (alt56) 
        		{
        			case 1 :
        			    // Output\\FiltersLanguageGrammar.g:594:60: ',' d+= valUser
        			    {
        			    	Match(input,17,FOLLOW_17_in_synpred51_FiltersLanguageGrammar2249); if (state.failed) return ;
        			    	PushFollow(FOLLOW_valUser_in_synpred51_FiltersLanguageGrammar2255);
        			    	d = valUser();
        			    	state.followingStackPointer--;
        			    	if (state.failed) return ;
        			    	if (list_d == null) list_d = new ArrayList();
        			    	list_d.Add(d);


        			    }
        			    break;

        			default:
        			    goto loop56;
        	    }
        	} while (true);

        	loop56:
        		;	// Stops C# compiler whining that label 'loop56' has no statements

        	Match(input,11,FOLLOW_11_in_synpred51_FiltersLanguageGrammar2259); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred51_FiltersLanguageGrammar"

    // $ANTLR start "synpred61_FiltersLanguageGrammar"
    public void synpred61_FiltersLanguageGrammar_fragment() {
        IList list_c = null;
        FiltersLanguageGrammarParser.valDate_return c = default(FiltersLanguageGrammarParser.valDate_return);
         c = null;
        // Output\\FiltersLanguageGrammar.g:607:6: ( parametersDate 'wasever' '(' c+= valDate ( ',' c+= valDate )* ')' )
        // Output\\FiltersLanguageGrammar.g:607:6: parametersDate 'wasever' '(' c+= valDate ( ',' c+= valDate )* ')'
        {
        	PushFollow(FOLLOW_parametersDate_in_synpred61_FiltersLanguageGrammar2530);
        	parametersDate();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	Match(input,18,FOLLOW_18_in_synpred61_FiltersLanguageGrammar2532); if (state.failed) return ;
        	Match(input,10,FOLLOW_10_in_synpred61_FiltersLanguageGrammar2534); if (state.failed) return ;
        	PushFollow(FOLLOW_valDate_in_synpred61_FiltersLanguageGrammar2540);
        	c = valDate();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	if (list_c == null) list_c = new ArrayList();
        	list_c.Add(c);

        	// Output\\FiltersLanguageGrammar.g:607:48: ( ',' c+= valDate )*
        	do 
        	{
        	    int alt61 = 2;
        	    int LA61_0 = input.LA(1);

        	    if ( (LA61_0 == 17) )
        	    {
        	        alt61 = 1;
        	    }


        	    switch (alt61) 
        		{
        			case 1 :
        			    // Output\\FiltersLanguageGrammar.g:607:49: ',' c+= valDate
        			    {
        			    	Match(input,17,FOLLOW_17_in_synpred61_FiltersLanguageGrammar2543); if (state.failed) return ;
        			    	PushFollow(FOLLOW_valDate_in_synpred61_FiltersLanguageGrammar2549);
        			    	c = valDate();
        			    	state.followingStackPointer--;
        			    	if (state.failed) return ;
        			    	if (list_c == null) list_c = new ArrayList();
        			    	list_c.Add(c);


        			    }
        			    break;

        			default:
        			    goto loop61;
        	    }
        	} while (true);

        	loop61:
        		;	// Stops C# compiler whining that label 'loop61' has no statements

        	Match(input,11,FOLLOW_11_in_synpred61_FiltersLanguageGrammar2553); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred61_FiltersLanguageGrammar"

    // $ANTLR start "synpred63_FiltersLanguageGrammar"
    public void synpred63_FiltersLanguageGrammar_fragment() {
        IList list_d = null;
        FiltersLanguageGrammarParser.valUser_return d = default(FiltersLanguageGrammarParser.valUser_return);
         d = null;
        // Output\\FiltersLanguageGrammar.g:612:6: ( parametersUser 'wasever' '(' d+= valUser ( ',' d+= valUser )* ')' )
        // Output\\FiltersLanguageGrammar.g:612:6: parametersUser 'wasever' '(' d+= valUser ( ',' d+= valUser )* ')'
        {
        	PushFollow(FOLLOW_parametersUser_in_synpred63_FiltersLanguageGrammar2594);
        	parametersUser();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	Match(input,18,FOLLOW_18_in_synpred63_FiltersLanguageGrammar2596); if (state.failed) return ;
        	Match(input,10,FOLLOW_10_in_synpred63_FiltersLanguageGrammar2598); if (state.failed) return ;
        	PushFollow(FOLLOW_valUser_in_synpred63_FiltersLanguageGrammar2604);
        	d = valUser();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	if (list_d == null) list_d = new ArrayList();
        	list_d.Add(d);

        	// Output\\FiltersLanguageGrammar.g:612:48: ( ',' d+= valUser )*
        	do 
        	{
        	    int alt62 = 2;
        	    int LA62_0 = input.LA(1);

        	    if ( (LA62_0 == 17) )
        	    {
        	        alt62 = 1;
        	    }


        	    switch (alt62) 
        		{
        			case 1 :
        			    // Output\\FiltersLanguageGrammar.g:612:49: ',' d+= valUser
        			    {
        			    	Match(input,17,FOLLOW_17_in_synpred63_FiltersLanguageGrammar2607); if (state.failed) return ;
        			    	PushFollow(FOLLOW_valUser_in_synpred63_FiltersLanguageGrammar2613);
        			    	d = valUser();
        			    	state.followingStackPointer--;
        			    	if (state.failed) return ;
        			    	if (list_d == null) list_d = new ArrayList();
        			    	list_d.Add(d);


        			    }
        			    break;

        			default:
        			    goto loop62;
        	    }
        	} while (true);

        	loop62:
        		;	// Stops C# compiler whining that label 'loop62' has no statements

        	Match(input,11,FOLLOW_11_in_synpred63_FiltersLanguageGrammar2617); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred63_FiltersLanguageGrammar"

    // $ANTLR start "synpred82_FiltersLanguageGrammar"
    public void synpred82_FiltersLanguageGrammar_fragment() {
        // Output\\FiltersLanguageGrammar.g:759:6: ( parametersTextifyOneToMany internalopN2M valStr )
        // Output\\FiltersLanguageGrammar.g:759:6: parametersTextifyOneToMany internalopN2M valStr
        {
        	PushFollow(FOLLOW_parametersTextifyOneToMany_in_synpred82_FiltersLanguageGrammar4014);
        	parametersTextifyOneToMany();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	PushFollow(FOLLOW_internalopN2M_in_synpred82_FiltersLanguageGrammar4016);
        	internalopN2M();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	PushFollow(FOLLOW_valStr_in_synpred82_FiltersLanguageGrammar4018);
        	valStr();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred82_FiltersLanguageGrammar"

    // $ANTLR start "synpred83_FiltersLanguageGrammar"
    public void synpred83_FiltersLanguageGrammar_fragment() {
        // Output\\FiltersLanguageGrammar.g:774:6: ( parametersTextifyOneToMany internalopNotEqN2M valStr )
        // Output\\FiltersLanguageGrammar.g:774:6: parametersTextifyOneToMany internalopNotEqN2M valStr
        {
        	PushFollow(FOLLOW_parametersTextifyOneToMany_in_synpred83_FiltersLanguageGrammar4151);
        	parametersTextifyOneToMany();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	PushFollow(FOLLOW_internalopNotEqN2M_in_synpred83_FiltersLanguageGrammar4153);
        	internalopNotEqN2M();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	PushFollow(FOLLOW_valStr_in_synpred83_FiltersLanguageGrammar4155);
        	valStr();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred83_FiltersLanguageGrammar"

    // $ANTLR start "synpred84_FiltersLanguageGrammar"
    public void synpred84_FiltersLanguageGrammar_fragment() {
        // Output\\FiltersLanguageGrammar.g:788:6: ( parametersConstOneToMany internalopN2M valStr )
        // Output\\FiltersLanguageGrammar.g:788:6: parametersConstOneToMany internalopN2M valStr
        {
        	PushFollow(FOLLOW_parametersConstOneToMany_in_synpred84_FiltersLanguageGrammar4269);
        	parametersConstOneToMany();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	PushFollow(FOLLOW_internalopN2M_in_synpred84_FiltersLanguageGrammar4271);
        	internalopN2M();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	PushFollow(FOLLOW_valStr_in_synpred84_FiltersLanguageGrammar4273);
        	valStr();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred84_FiltersLanguageGrammar"

    // $ANTLR start "synpred85_FiltersLanguageGrammar"
    public void synpred85_FiltersLanguageGrammar_fragment() {
        // Output\\FiltersLanguageGrammar.g:806:6: ( parametersConstOneToMany internalopNotEqN2M valStr )
        // Output\\FiltersLanguageGrammar.g:806:6: parametersConstOneToMany internalopNotEqN2M valStr
        {
        	PushFollow(FOLLOW_parametersConstOneToMany_in_synpred85_FiltersLanguageGrammar4424);
        	parametersConstOneToMany();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	PushFollow(FOLLOW_internalopNotEqN2M_in_synpred85_FiltersLanguageGrammar4426);
        	internalopNotEqN2M();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	PushFollow(FOLLOW_valStr_in_synpred85_FiltersLanguageGrammar4428);
        	valStr();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred85_FiltersLanguageGrammar"

    // Delegated rules

   	public bool synpred4_FiltersLanguageGrammar() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred4_FiltersLanguageGrammar_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred2_FiltersLanguageGrammar() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred2_FiltersLanguageGrammar_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred7_FiltersLanguageGrammar() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred7_FiltersLanguageGrammar_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred49_FiltersLanguageGrammar() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred49_FiltersLanguageGrammar_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred12_FiltersLanguageGrammar() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred12_FiltersLanguageGrammar_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred1_FiltersLanguageGrammar() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred1_FiltersLanguageGrammar_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred6_FiltersLanguageGrammar() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred6_FiltersLanguageGrammar_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred11_FiltersLanguageGrammar() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred11_FiltersLanguageGrammar_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred51_FiltersLanguageGrammar() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred51_FiltersLanguageGrammar_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred63_FiltersLanguageGrammar() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred63_FiltersLanguageGrammar_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred9_FiltersLanguageGrammar() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred9_FiltersLanguageGrammar_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred84_FiltersLanguageGrammar() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred84_FiltersLanguageGrammar_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred41_FiltersLanguageGrammar() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred41_FiltersLanguageGrammar_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred10_FiltersLanguageGrammar() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred10_FiltersLanguageGrammar_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred14_FiltersLanguageGrammar() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred14_FiltersLanguageGrammar_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred83_FiltersLanguageGrammar() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred83_FiltersLanguageGrammar_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred3_FiltersLanguageGrammar() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred3_FiltersLanguageGrammar_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred13_FiltersLanguageGrammar() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred13_FiltersLanguageGrammar_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred61_FiltersLanguageGrammar() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred61_FiltersLanguageGrammar_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred82_FiltersLanguageGrammar() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred82_FiltersLanguageGrammar_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred35_FiltersLanguageGrammar() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred35_FiltersLanguageGrammar_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred85_FiltersLanguageGrammar() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred85_FiltersLanguageGrammar_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred8_FiltersLanguageGrammar() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred8_FiltersLanguageGrammar_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}


   	protected DFA1 dfa1;
   	protected DFA21 dfa21;
	private void InitializeCyclicDFAs()
	{
    	this.dfa1 = new DFA1(this);
    	this.dfa21 = new DFA21(this);
	    this.dfa1.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA1_SpecialStateTransition);
	    this.dfa21.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA21_SpecialStateTransition);
	}

    const string DFA1_eotS =
        "\x17\uffff";
    const string DFA1_eofS =
        "\x17\uffff";
    const string DFA1_minS =
        "\x01\x04\x05\x00\x01\uffff\x02\x00\x0e\uffff";
    const string DFA1_maxS =
        "\x01\x26\x05\x00\x01\uffff\x02\x00\x0e\uffff";
    const string DFA1_acceptS =
        "\x06\uffff\x01\x05\x02\uffff\x01\x01\x01\x02\x01\x03\x01\x04\x01"+
        "\x06\x01\x07\x01\x08\x01\x09\x01\x0a\x01\x0b\x01\x0c\x01\x0d\x01"+
        "\x0e\x01\x0f";
    const string DFA1_specialS =
        "\x01\uffff\x01\x00\x01\x01\x01\x02\x01\x03\x01\x04\x01\uffff\x01"+
        "\x05\x01\x06\x0e\uffff}>";
    static readonly string[] DFA1_transitionS = {
            "\x01\x03\x04\uffff\x01\x06\x01\x02\x01\uffff\x01\x07\x01\x08"+
            "\x02\uffff\x01\x01\x14\uffff\x01\x04\x01\x05",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "",
            "\x01\uffff",
            "\x01\uffff",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA1_eot = DFA.UnpackEncodedString(DFA1_eotS);
    static readonly short[] DFA1_eof = DFA.UnpackEncodedString(DFA1_eofS);
    static readonly char[] DFA1_min = DFA.UnpackEncodedStringToUnsignedChars(DFA1_minS);
    static readonly char[] DFA1_max = DFA.UnpackEncodedStringToUnsignedChars(DFA1_maxS);
    static readonly short[] DFA1_accept = DFA.UnpackEncodedString(DFA1_acceptS);
    static readonly short[] DFA1_special = DFA.UnpackEncodedString(DFA1_specialS);
    static readonly short[][] DFA1_transition = DFA.UnpackEncodedStringArray(DFA1_transitionS);

    protected class DFA1 : DFA
    {
        public DFA1(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 1;
            this.eot = DFA1_eot;
            this.eof = DFA1_eof;
            this.min = DFA1_min;
            this.max = DFA1_max;
            this.accept = DFA1_accept;
            this.special = DFA1_special;
            this.transition = DFA1_transition;

        }

        override public string Description
        {
            get { return "474:1: expr : ( logicalexpr a= columnsspec b= sortingspec -> specified(val=$logicalexpr.stcol=$a.stsort=$b.stview=GlobalModuleLastView) | logicalexpr a= columnsspec -> specifiedColumns(val=$logicalexpr.stcol=$a.stview=GlobalModuleLastViewprimid=GlobalPrimaryID) | logicalexpr b= sortingspec -> specifiedSorting(val=$logicalexpr.stsort=$b.stview=GlobalModuleLastViewcols=GlobalColsDefault) | logicalexpr -> defaultSQL(val=$logicalexpr.stview=GlobalModuleLastViewcols=GlobalColsDefaultprimid=GlobalPrimaryID) | 'sql' '(' query ')' -> builtSQL(val=$query.st) | '__cntl' logicalexpr a= columnsspec b= sortingspec -> countspecified_library(val=$logicalexpr.stcol=$a.stsort=$b.stview=GlobalModuleLastView) | '__cntl' logicalexpr a= columnsspec -> countspecifiedColumns_library(val=$logicalexpr.stcol=$a.stview=GlobalModuleLastViewprimid=GlobalPrimaryID) | '__cntl' logicalexpr b= sortingspec -> countspecifiedSorting_library(val=$logicalexpr.stsort=$b.stview=GlobalModuleLastViewcols=GlobalColsDefault) | '__cntl' logicalexpr -> countdefaultSQL_library(val=$logicalexpr.stview=GlobalModuleLastViewcols=GlobalColsDefaultprimid=GlobalPrimaryID) | '__cntl' 'sql' '(' query ')' -> countbuiltSQL(val=$query.st) | '__cnt' logicalexpr a= columnsspec b= sortingspec -> countspecified(val=$logicalexpr.stcol=$a.stsort=$b.stview=GlobalModuleLastView) | '__cnt' logicalexpr a= columnsspec -> countspecifiedColumns(val=$logicalexpr.stcol=$a.stview=GlobalModuleLastViewprimid=GlobalPrimaryID) | '__cnt' logicalexpr b= sortingspec -> countspecifiedSorting(val=$logicalexpr.stsort=$b.stview=GlobalModuleLastViewcols=GlobalColsDefault) | '__cnt' logicalexpr -> countdefaultSQL(val=$logicalexpr.stview=GlobalModuleLastViewcols=GlobalColsDefaultprimid=GlobalPrimaryID) | '__cnt' 'sql' '(' query ')' -> countbuiltSQL(val=$query.st));"; }
        }

    }


    protected internal int DFA1_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA1_1 = input.LA(1);

                   	 
                   	int index1_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_FiltersLanguageGrammar()) ) { s = 9; }

                   	else if ( (synpred2_FiltersLanguageGrammar()) ) { s = 10; }

                   	else if ( (synpred3_FiltersLanguageGrammar()) ) { s = 11; }

                   	else if ( (synpred4_FiltersLanguageGrammar()) ) { s = 12; }

                   	 
                   	input.Seek(index1_1);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA1_2 = input.LA(1);

                   	 
                   	int index1_2 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_FiltersLanguageGrammar()) ) { s = 9; }

                   	else if ( (synpred2_FiltersLanguageGrammar()) ) { s = 10; }

                   	else if ( (synpred3_FiltersLanguageGrammar()) ) { s = 11; }

                   	else if ( (synpred4_FiltersLanguageGrammar()) ) { s = 12; }

                   	 
                   	input.Seek(index1_2);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA1_3 = input.LA(1);

                   	 
                   	int index1_3 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_FiltersLanguageGrammar()) ) { s = 9; }

                   	else if ( (synpred2_FiltersLanguageGrammar()) ) { s = 10; }

                   	else if ( (synpred3_FiltersLanguageGrammar()) ) { s = 11; }

                   	else if ( (synpred4_FiltersLanguageGrammar()) ) { s = 12; }

                   	 
                   	input.Seek(index1_3);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 3 : 
                   	int LA1_4 = input.LA(1);

                   	 
                   	int index1_4 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_FiltersLanguageGrammar()) ) { s = 9; }

                   	else if ( (synpred2_FiltersLanguageGrammar()) ) { s = 10; }

                   	else if ( (synpred3_FiltersLanguageGrammar()) ) { s = 11; }

                   	else if ( (synpred4_FiltersLanguageGrammar()) ) { s = 12; }

                   	 
                   	input.Seek(index1_4);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 4 : 
                   	int LA1_5 = input.LA(1);

                   	 
                   	int index1_5 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred1_FiltersLanguageGrammar()) ) { s = 9; }

                   	else if ( (synpred2_FiltersLanguageGrammar()) ) { s = 10; }

                   	else if ( (synpred3_FiltersLanguageGrammar()) ) { s = 11; }

                   	else if ( (synpred4_FiltersLanguageGrammar()) ) { s = 12; }

                   	 
                   	input.Seek(index1_5);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 5 : 
                   	int LA1_7 = input.LA(1);

                   	 
                   	int index1_7 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred6_FiltersLanguageGrammar()) ) { s = 13; }

                   	else if ( (synpred7_FiltersLanguageGrammar()) ) { s = 14; }

                   	else if ( (synpred8_FiltersLanguageGrammar()) ) { s = 15; }

                   	else if ( (synpred9_FiltersLanguageGrammar()) ) { s = 16; }

                   	else if ( (synpred10_FiltersLanguageGrammar()) ) { s = 17; }

                   	 
                   	input.Seek(index1_7);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 6 : 
                   	int LA1_8 = input.LA(1);

                   	 
                   	int index1_8 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred11_FiltersLanguageGrammar()) ) { s = 18; }

                   	else if ( (synpred12_FiltersLanguageGrammar()) ) { s = 19; }

                   	else if ( (synpred13_FiltersLanguageGrammar()) ) { s = 20; }

                   	else if ( (synpred14_FiltersLanguageGrammar()) ) { s = 21; }

                   	else if ( (true) ) { s = 22; }

                   	 
                   	input.Seek(index1_8);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae1 =
            new NoViableAltException(dfa.Description, 1, _s, input);
        dfa.Error(nvae1);
        throw nvae1;
    }
    const string DFA21_eotS =
        "\x65\uffff";
    const string DFA21_eofS =
        "\x65\uffff";
    const string DFA21_minS =
        "\x01\x04\x02\uffff\x05\x12\x01\x04\x01\x12\x05\x04\x01\uffff\x01"+
        "\x0a\x01\x12\x01\x0a\x01\uffff\x01\x12\x01\x34\x01\x12\x02\uffff"+
        "\x05\x12\x01\x34\x02\x12\x11\uffff\x01\x00\x02\uffff\x06\x04\x01"+
        "\x0a\x01\uffff\x01\x00\x04\uffff\x01\x04\x07\uffff\x01\x04\x0a\uffff"+
        "\x01\x04\x02\uffff\x01\x0b\x02\uffff\x01\x0b\x03\uffff\x01\x04\x01"+
        "\x00\x01\x04\x01\x00\x02\x0b";
    const string DFA21_maxS =
        "\x01\x26\x02\uffff\x05\x3e\x01\x42\x01\x3e\x05\x42\x01\uffff\x01"+
        "\x0a\x01\x3e\x01\x0a\x01\uffff\x01\x3e\x01\x39\x01\x3e\x02\uffff"+
        "\x05\x3e\x01\x39\x02\x3e\x11\uffff\x01\x00\x02\uffff\x06\x22\x01"+
        "\x0a\x01\uffff\x01\x00\x04\uffff\x01\x24\x07\uffff\x01\x42\x0a\uffff"+
        "\x01\x22\x02\uffff\x01\x11\x02\uffff\x01\x11\x03\uffff\x01\x24\x01"+
        "\x00\x01\x24\x01\x00\x02\x11";
    const string DFA21_acceptS =
        "\x01\uffff\x01\x01\x01\x02\x0c\uffff\x01\x07\x03\uffff\x01\x10"+
        "\x03\uffff\x01\x0d\x01\x0a\x08\uffff\x01\x2e\x01\x30\x01\x29\x01"+
        "\x2d\x01\x2c\x01\x2b\x01\x2a\x01\x2f\x01\x0e\x01\x03\x01\x05\x01"+
        "\x21\x01\x08\x01\x0b\x01\x1b\x01\x19\x01\x12\x01\uffff\x01\x13\x01"+
        "\x18\x07\uffff\x01\x1d\x01\uffff\x01\x16\x01\x15\x01\x14\x01\x17"+
        "\x01\uffff\x01\x04\x01\x0f\x01\x1f\x01\x09\x01\x0c\x01\x06\x01\x27"+
        "\x01\uffff\x01\x20\x01\x28\x01\x1a\x01\x36\x01\x35\x01\x11\x01\x22"+
        "\x01\x1c\x01\x32\x01\x34\x01\uffff\x01\x31\x01\x33\x01\uffff\x01"+
        "\x1e\x01\x23\x01\uffff\x01\x24\x01\x25\x01\x26\x06\uffff";
    const string DFA21_specialS =
        "\x32\uffff\x01\x02\x0a\uffff\x01\x00\x22\uffff\x01\x03\x01\uffff"+
        "\x01\x01\x02\uffff}>";
    static readonly string[] DFA21_transitionS = {
            "\x01\x02\x05\uffff\x01\x01\x1a\uffff\x01\x03\x01\x04",
            "",
            "",
            "\x01\x12\x14\uffff\x01\x15\x01\x11\x01\x06\x01\x07\x01\x09"+
            "\x01\x14\x01\x16\x01\x05\x05\uffff\x01\x0b\x01\x08\x01\x0c\x01"+
            "\x0e\x01\x0d\x01\x0a\x01\x0f\x01\x17\x01\x13\x01\x18\x01\x10",
            "\x01\x12\x14\uffff\x01\x1e\x01\x1c\x01\x19\x01\x1a\x01\x1b"+
            "\x01\x20\x01\x1f\x01\x1d\x05\uffff\x01\x0b\x01\x08\x01\x0c\x01"+
            "\x0e\x01\x0d\x01\x0a\x01\x0f\x01\x17\x01\x13\x01\x18\x01\x10",
            "\x01\x25\x21\uffff\x01\x23\x01\x27\x04\x23\x01\x24\x01\x28"+
            "\x01\x22\x01\x21\x01\x26",
            "\x01\x2c\x21\uffff\x06\x2a\x01\x2b\x01\x2e\x01\x29\x01\x2d"+
            "\x01\x2f",
            "\x01\x2c\x21\uffff\x06\x2a\x01\x2b\x01\x2e\x01\x29\x01\x2d"+
            "\x01\x2f",
            "\x01\x32\x01\uffff\x01\x31\x0c\uffff\x08\x31\x08\x33\x02\x34"+
            "\x1a\uffff\x04\x30",
            "\x01\x3b\x21\uffff\x01\x35\x01\x3a\x01\x36\x01\x38\x01\x37"+
            "\x01\x39\x04\uffff\x01\x3c",
            "\x01\x3d\x01\uffff\x01\x31\x0c\uffff\x08\x31\x08\x3e\x02\x34"+
            "\x1a\uffff\x04\x30",
            "\x01\x3d\x01\uffff\x01\x31\x0c\uffff\x08\x31\x08\x33\x02\x34"+
            "\x1a\uffff\x04\x30",
            "\x01\x3d\x01\uffff\x01\x31\x0c\uffff\x08\x31\x08\x3f\x02\x34"+
            "\x1a\uffff\x04\x30",
            "\x01\x3d\x01\uffff\x01\x31\x0c\uffff\x08\x31\x08\x40\x02\x34"+
            "\x1a\uffff\x04\x30",
            "\x01\x3d\x01\uffff\x01\x31\x0c\uffff\x08\x31\x08\x41\x02\x34"+
            "\x1a\uffff\x04\x30",
            "",
            "\x01\x42",
            "\x01\x49\x21\uffff\x02\x43\x04\uffff\x01\x48\x01\x47\x01\x44"+
            "\x01\x46\x01\x45",
            "\x01\x4a",
            "",
            "\x01\x4c\x21\uffff\x06\x4d\x04\uffff\x01\x4b",
            "\x01\x4f\x01\x4e\x04\x4f",
            "\x01\x51\x21\uffff\x06\x50\x04\uffff\x01\x52",
            "",
            "",
            "\x01\x2c\x21\uffff\x06\x2a\x01\x2b\x01\x2e\x01\x29\x01\x2d"+
            "\x01\x2f",
            "\x01\x2c\x21\uffff\x06\x2a\x01\x2b\x01\x2e\x01\x29\x01\x2d"+
            "\x01\x2f",
            "\x01\x3b\x21\uffff\x01\x35\x01\x3a\x01\x36\x01\x38\x01\x37"+
            "\x01\x39\x04\uffff\x01\x3c",
            "\x01\x49\x21\uffff\x02\x43\x04\uffff\x01\x48\x01\x47\x01\x44"+
            "\x01\x46\x01\x45",
            "\x01\x25\x21\uffff\x01\x23\x01\x27\x04\x23\x01\x24\x01\x28"+
            "\x01\x22\x01\x21\x01\x26",
            "\x01\x4f\x01\x4e\x04\x4f",
            "\x01\x51\x21\uffff\x06\x50\x04\uffff\x01\x52",
            "\x01\x4c\x21\uffff\x06\x4d\x04\uffff\x01\x4b",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\uffff",
            "",
            "",
            "\x01\x31\x01\uffff\x01\x31\x0c\uffff\x08\x31\x08\x33",
            "\x01\x31\x01\uffff\x01\x31\x0c\uffff\x08\x31\x08\x3f",
            "\x01\x31\x01\uffff\x01\x31\x0c\uffff\x08\x31\x08\x40",
            "\x01\x31\x01\uffff\x01\x31\x0c\uffff\x08\x31\x08\x41",
            "\x01\x31\x01\uffff\x01\x31\x0c\uffff\x08\x31\x08\x3e",
            "\x01\x31\x01\uffff\x01\x31\x0c\uffff\x08\x31\x08\x33",
            "\x01\x55",
            "",
            "\x01\uffff",
            "",
            "",
            "",
            "",
            "\x01\x58\x01\uffff\x01\x3c\x0c\uffff\x08\x3c\x08\uffff\x02"+
            "\x59",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x5b\x01\uffff\x01\x5a\x0c\uffff\x08\x5a\x08\x5e\x02\x5c"+
            "\x1a\uffff\x04\x5d",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x5a\x01\uffff\x01\x5a\x0c\uffff\x08\x5a\x08\x5e",
            "",
            "",
            "\x01\x60\x05\uffff\x01\x5f",
            "",
            "",
            "\x01\x62\x05\uffff\x01\x61",
            "",
            "",
            "",
            "\x01\x63\x01\uffff\x01\x3c\x0c\uffff\x08\x3c\x08\uffff\x02"+
            "\x59",
            "\x01\uffff",
            "\x01\x64\x01\uffff\x01\x5a\x0c\uffff\x08\x5a\x08\uffff\x02"+
            "\x5c",
            "\x01\uffff",
            "\x01\x60\x05\uffff\x01\x5f",
            "\x01\x62\x05\uffff\x01\x61"
    };

    static readonly short[] DFA21_eot = DFA.UnpackEncodedString(DFA21_eotS);
    static readonly short[] DFA21_eof = DFA.UnpackEncodedString(DFA21_eofS);
    static readonly char[] DFA21_min = DFA.UnpackEncodedStringToUnsignedChars(DFA21_minS);
    static readonly char[] DFA21_max = DFA.UnpackEncodedStringToUnsignedChars(DFA21_maxS);
    static readonly short[] DFA21_accept = DFA.UnpackEncodedString(DFA21_acceptS);
    static readonly short[] DFA21_special = DFA.UnpackEncodedString(DFA21_specialS);
    static readonly short[][] DFA21_transition = DFA.UnpackEncodedStringArray(DFA21_transitionS);

    protected class DFA21 : DFA
    {
        public DFA21(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 21;
            this.eot = DFA21_eot;
            this.eof = DFA21_eof;
            this.min = DFA21_min;
            this.max = DFA21_max;
            this.accept = DFA21_accept;
            this.special = DFA21_special;
            this.transition = DFA21_transition;

        }

        override public string Description
        {
            get { return "560:1: paramexpr : ( '(' logicalexpr ')' -> parenthesis(val=$logicalexpr.st) | token_for_fts -> fts_param(val=$token_for_fts.stmaintable=GlobalMainTableprimid=GlobalPrimaryIDftsid=GlobalFtsID) | parametersStr internalop valStr -> parameter(p=$parametersStr.sto=$internalop.stv=$valStr.st) | paramLongStr internalLongStrOp valLongStr -> parameter(p=$paramLongStr.sto=$internalLongStrOp.stv=$valLongStr.st) | parametersStr contains containsVal -> parameter(p=$parametersStr.sto=$contains.stv=$containsVal.st) | paramLongStr contains containsVal -> parameter(p=$paramLongStr.sto=$contains.stv=$containsVal.st) | parametersUser contains containsVal -> parameter(p=$parametersUser.sto=$contains.stv=$containsVal.st) | parametersStr doesNotContains doesNotContainsVal -> parameter(p=$parametersStr.sto=$doesNotContains.stv=$doesNotContainsVal.st) | paramLongStr doesNotContains doesNotContainsVal -> parameter(p=$paramLongStr.sto=$doesNotContains.stv=$doesNotContainsVal.st) | parametersUser doesNotContains doesNotContainsVal -> parameter(p=$parametersUser.sto=$doesNotContains.stv=$doesNotContainsVal.st) | parametersStr startsWith startsWithVal -> parameter(p=$parametersStr.sto=$startsWith.stv=$startsWithVal.st) | paramLongStr startsWith startsWithVal -> parameter(p=$paramLongStr.sto=$startsWith.stv=$startsWithVal.st) | parametersUser startsWith startsWithVal -> parameter(p=$parametersUser.sto=$startsWith.stv=$startsWithVal.st) | parametersStr endsWith endsWithVal -> parameter(p=$parametersStr.sto=$endsWith.stv=$endsWithVal.st) | paramLongStr endsWith endsWithVal -> parameter(p=$paramLongStr.sto=$endsWith.stv=$endsWithVal.st) | parametersUser endsWith endsWithVal -> parameter(p=$parametersUser.sto=$endsWith.stv=$endsWithVal.st) | parametersInt internalop valInt -> parameter(p=$parametersInt.sto=$internalop.stv=$valInt.st) | parametersDate internalop valDate -> parameter(p=$parametersDate.sto=$internalop.stv=$valDate.st) | parametersDate internalopSpan valDateSpan -> parameter(p=$parametersDate.sto=$internalopSpan.stv=$valDateSpan.st) | parametersDate lsOpSpan valDateSpanLs -> parameter(p=$parametersDate.sto=$lsOpSpan.stv=$valDateSpanLs.st) | parametersDate grOpSpan valDateSpanGr -> parameter(p=$parametersDate.sto=$grOpSpan.stv=$valDateSpanGr.st) | parametersDate lsOrEqOpSpan valDateSpanLsOrEq -> parameter(p=$parametersDate.sto=$lsOrEqOpSpan.stv=$valDateSpanLsOrEq.st) | parametersDate grOrEqOpSpan valDateSpanGrOrEq -> parameter(p=$parametersDate.sto=$grOrEqOpSpan.stv=$valDateSpanGrOrEq.st) | parametersUser internalop valUser -> parameter(p=$parametersUser.sto=$internalop.stv=$valUser.st) | parametersBool internalop valBool -> parameter(p=$parametersBool.sto=$internalop.stv=$valBool.st) | parametersMapped internalop valStr -> parameter(p=$parametersMapped.sto=$internalop.stv=$valStr.st) | parametersStr multivalueinternalop '(' a+= valStr ( ',' a+= valStr )* ')' -> multiparameter(p=$parametersStr.sto=$multivalueinternalop.stv=$a) | parametersInt multivalueinternalop '(' b+= valInt ( ',' b+= valInt )* ')' -> multiparameter(p=$parametersInt.sto=$multivalueinternalop.stv=$b) | parametersDate multivalueinternalop '(' c+= valDate ( ',' c+= valDate )* ')' -> multiparameter(p=$parametersDate.sto=$multivalueinternalop.stv=$c) | parametersUser multivalueinternalop '(' d+= valUser ( ',' d+= valUser )* ')' -> multiparameter(p=$parametersUser.sto=$multivalueinternalop.stv=$d) | paramLongStr multivalueinternalop '(' longS+= valStr ( ',' longS+= valStr )* ')' -> multiparameter(p=$paramLongStr.sto=$multivalueinternalop.stv=$longS) | parametersMapped multivalueinternalop '(' mapped+= valStr ( ',' mapped+= valStr )* ')' -> multiparameter(p=$parametersMapped.sto=$multivalueinternalop.stv=$mapped) | parametersStr 'wasever' '(' a+= valStr ( ',' a+= valStr )* ')' -> wasever(col=$parametersStr.stval=$aview=GlobalModuleEverViewprimid=GlobalPrimaryID) | parametersInt 'wasever' '(' b+= valInt ( ',' b+= valInt )* ')' -> wasever(col=$parametersInt.stval=$bview=GlobalModuleEverViewprimid=GlobalPrimaryID) | parametersDate 'wasever' '(' c+= valDate ( ',' c+= valDate )* ')' -> wasever(col=$parametersDate.stval=$cview=GlobalModuleEverViewprimid=GlobalPrimaryID) | parametersUser 'wasever' '(' d+= valUser ( ',' d+= valUser )* ')' -> wasever(col=$parametersUser.stval=$dview=GlobalModuleEverViewprimid=GlobalPrimaryID) | parametersBool 'wasever' '(' e+= valBool ( ',' e+= valBool )* ')' -> wasever(col=$parametersBool.stval=$eview=GlobalModuleEverViewprimid=GlobalPrimaryID) | parametersDate 'wasever' '(' f+= valDateSpan ( ',' f+= valDateSpan )* ')' -> wasever(col=$parametersDate.stval=$fview=GlobalModuleEverViewprimid=GlobalPrimaryID) | paramLongStr 'wasever' '(' longS+= valStr ( ',' longS+= valStr )* ')' -> wasever(col=$paramLongStr.stval=$longSview=GlobalModuleEverViewprimid=GlobalPrimaryID) | parametersMapped 'wasever' '(' mapped+= valStr ( ',' mapped+= valStr )* ')' -> wasever(col=$parametersMapped.stval=$mappedview=GlobalModuleEverViewprimid=GlobalPrimaryID) | parametersManyToMany internalopN2M valStr -> many_to_many(val=$valStr.stop=$internalopN2M.stmaintable=_globalMainTableList[_n2mCount - 1]primid=_globalPrimaryIDList[_n2mCount - 1]n2mtable=_globalN2MTableList[_n2mCount - 1]replyid=_globalN2MReplyIDList[_n2mCount - 1]objtable=_globalN2MObjTableList[_n2mCount - 1]n2mobjid=_globalN2MObjIDList[_n2mCount - 1]valname=$parametersManyToMany.stisdeletedrestriction=_globalN2MIsDeletedRestriction[_n2mCount - 1]) | parametersManyToMany internalopNotEqN2M valStr -> many_to_many_not(val=$valStr.stmaintable=_globalMainTableList[_n2mCount - 1]primid=_globalPrimaryIDList[_n2mCount - 1]n2mtable=_globalN2MTableList[_n2mCount - 1]replyid=_globalN2MReplyIDList[_n2mCount - 1]objtable=_globalN2MObjTableList[_n2mCount - 1]n2mobjid=_globalN2MObjIDList[_n2mCount - 1]valname=$parametersManyToMany.stisdeletedrestriction=_globalN2MIsDeletedRestriction[_n2mCount - 1]) | parametersManyToMany multivalueinternalop '(' g+= valStr ( ',' g+= valStr )* ')' -> many_to_many_multi(val=$gop=$multivalueinternalop.stmaintable=_globalMainTableList[_n2mCount - 1]primid=_globalPrimaryIDList[_n2mCount - 1]n2mtable=_globalN2MTableList[_n2mCount - 1]replyid=_globalN2MReplyIDList[_n2mCount - 1]objtable=_globalN2MObjTableList[_n2mCount - 1]n2mobjid=_globalN2MObjIDList[_n2mCount - 1]valname=$parametersManyToMany.stisdeletedrestriction=_globalN2MIsDeletedRestriction[_n2mCount - 1]) | parametersManyToMany 'wasever' '(' h+= valStr ( ',' h+= valStr )* ')' -> many_to_many_wasever(val=$hmaintable=_globalMainTableList[_n2mCount - 1]primid=_globalPrimaryIDList[_n2mCount - 1]n2mtable=_globalN2MTableList[_n2mCount - 1]replyid=_globalN2MReplyIDList[_n2mCount - 1]objtable=_globalN2MObjTableList[_n2mCount - 1]n2mobjid=_globalN2MObjIDList[_n2mCount - 1]valname=$parametersManyToMany.stisdeletedrestriction=_globalN2MIsDeletedRestriction[_n2mCount - 1]) | parametersManyToMany contains containsVal -> many_to_many(val=$containsVal.stop=$contains.stmaintable=_globalMainTableList[_n2mCount - 1]primid=_globalPrimaryIDList[_n2mCount - 1]n2mtable=_globalN2MTableList[_n2mCount - 1]replyid=_globalN2MReplyIDList[_n2mCount - 1]objtable=_globalN2MObjTableList[_n2mCount - 1]n2mobjid=_globalN2MObjIDList[_n2mCount - 1]valname=$parametersManyToMany.stisdeletedrestriction=_globalN2MIsDeletedRestriction[_n2mCount - 1]) | parametersManyToMany doesNotContains doesNotContainsVal -> many_to_many_not_contains(val=$doesNotContainsVal.stmaintable=_globalMainTableList[_n2mCount - 1]primid=_globalPrimaryIDList[_n2mCount - 1]n2mtable=_globalN2MTableList[_n2mCount - 1]replyid=_globalN2MReplyIDList[_n2mCount - 1]objtable=_globalN2MObjTableList[_n2mCount - 1]n2mobjid=_globalN2MObjIDList[_n2mCount - 1]valname=$parametersManyToMany.stisdeletedrestriction=_globalN2MIsDeletedRestriction[_n2mCount - 1]) | parametersManyToMany startsWith startsWithVal -> many_to_many(val=$startsWithVal.stop=$startsWith.stmaintable=_globalMainTableList[_n2mCount - 1]primid=_globalPrimaryIDList[_n2mCount - 1]n2mtable=_globalN2MTableList[_n2mCount - 1]replyid=_globalN2MReplyIDList[_n2mCount - 1]objtable=_globalN2MObjTableList[_n2mCount - 1]n2mobjid=_globalN2MObjIDList[_n2mCount - 1]valname=$parametersManyToMany.stisdeletedrestriction=_globalN2MIsDeletedRestriction[_n2mCount - 1]) | parametersManyToMany endsWith endsWithVal -> many_to_many(val=$endsWithVal.stop=$endsWith.stmaintable=_globalMainTableList[_n2mCount - 1]primid=_globalPrimaryIDList[_n2mCount - 1]n2mtable=_globalN2MTableList[_n2mCount - 1]replyid=_globalN2MReplyIDList[_n2mCount - 1]objtable=_globalN2MObjTableList[_n2mCount - 1]n2mobjid=_globalN2MObjIDList[_n2mCount - 1]valname=$parametersManyToMany.stisdeletedrestriction=_globalN2MIsDeletedRestriction[_n2mCount - 1]) | parametersTextifyOneToMany internalopN2M valStr -> textify_one_to_many(val=$valStr.stop=$internalopN2M.stprimid=_globalTextifyPrimaryIDList[_one2manyTextifyCount - 1]foreignKey=_globalTextifyOneToManyForeignKey[_one2manyTextifyCount - 1]tableName=_globalTextifyOneToManyTableName[_one2manyTextifyCount - 1]filteredFieldName=_globalTextifyOneToManyFieldName[_one2manyTextifyCount - 1]isDeleted=_globalTextifyOneToManyIsDeletedName[_one2manyTextifyCount - 1]) | parametersTextifyOneToMany internalopNotEqN2M valStr -> textify_one_to_many_not(val=$valStr.stprimid=_globalTextifyPrimaryIDList[_one2manyTextifyCount - 1]foreignKey=_globalTextifyOneToManyForeignKey[_one2manyTextifyCount - 1]tableName=_globalTextifyOneToManyTableName[_one2manyTextifyCount - 1]filteredFieldName=_globalTextifyOneToManyFieldName[_one2manyTextifyCount - 1]isDeleted=_globalTextifyOneToManyIsDeletedName[_one2manyTextifyCount - 1]) | parametersConstOneToMany internalopN2M valStr -> const_one_to_many(val=$valStr.stop=$internalopN2M.stprimid=_globalConstPrimaryIDList[_one2manyConstCount - 1]foreignKey=_globalConstOneToManyForeignKey[_one2manyConstCount - 1]tableName=_globalConstOneToManyTableName[_one2manyConstCount - 1]filteredFieldName=_globalConstOneToManyFieldName[_one2manyConstCount - 1]isDeleted=_globalConstOneToManyIsDeletedName[_one2manyConstCount - 1]constColumnName=_globalConstOneToManyConstColumnName[_one2manyConstCount - 1]constIntValue=_globalConstOneToManyConstIntValue[_one2manyConstCount - 1]) | parametersConstOneToMany internalopNotEqN2M valStr -> const_one_to_many_not(val=$valStr.stprimid=_globalConstPrimaryIDList[_one2manyConstCount - 1]foreignKey=_globalConstOneToManyForeignKey[_one2manyConstCount - 1]tableName=_globalConstOneToManyTableName[_one2manyConstCount - 1]filteredFieldName=_globalConstOneToManyFieldName[_one2manyConstCount - 1]isDeleted=_globalConstOneToManyIsDeletedName[_one2manyConstCount - 1]constColumnName=_globalConstOneToManyConstColumnName[_one2manyConstCount - 1]constIntValue=_globalConstOneToManyConstIntValue[_one2manyConstCount - 1]) | parametersTableMappedOneToMany internalopN2M valStr -> table_mapped_one_to_many(val=$valStr.stop=$internalopN2M.stprimid=_globalTableMappedPrimaryIDList[_one2manyTableMappedCount - 1]foreignKey=_globalTableMappedOneToManyForeignKey[_one2manyTableMappedCount - 1]tableName=_globalTableMappedOneToManyTableName[_one2manyTableMappedCount - 1]filteredFieldName=_globalTableMappedOneToManyFieldName[_one2manyTableMappedCount - 1]secondTableName=_globalTableMappedOneToManySecondTableName[_one2manyTableMappedCount - 1]secondTablePK=_globalTableMappedOneToManySecondTablePrimaryKey[_one2manyTableMappedCount - 1]secondTableFK=_globalTableMappedOneToManySecondTableForeignKey[_one2manyTableMappedCount - 1]) | parametersTableMappedOneToMany internalopNotEqN2M valStr -> table_mapped_one_to_many_not(val=$valStr.stprimid=_globalTableMappedPrimaryIDList[_one2manyTableMappedCount - 1]foreignKey=_globalTableMappedOneToManyForeignKey[_one2manyTableMappedCount - 1]tableName=_globalTableMappedOneToManyTableName[_one2manyTableMappedCount - 1]filteredFieldName=_globalTableMappedOneToManyFieldName[_one2manyTableMappedCount - 1]secondTableName=_globalTableMappedOneToManySecondTableName[_one2manyTableMappedCount - 1]secondTablePK=_globalTableMappedOneToManySecondTablePrimaryKey[_one2manyTableMappedCount - 1]secondTableFK=_globalTableMappedOneToManySecondTableForeignKey[_one2manyTableMappedCount - 1]));"; }
        }

    }


    protected internal int DFA21_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA21_61 = input.LA(1);

                   	 
                   	int index21_61 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred35_FiltersLanguageGrammar()) ) { s = 49; }

                   	else if ( (synpred41_FiltersLanguageGrammar()) ) { s = 52; }

                   	else if ( (synpred82_FiltersLanguageGrammar()) ) { s = 86; }

                   	else if ( (synpred84_FiltersLanguageGrammar()) ) { s = 87; }

                   	 
                   	input.Seek(index21_61);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA21_98 = input.LA(1);

                   	 
                   	int index21_98 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred61_FiltersLanguageGrammar()) ) { s = 90; }

                   	else if ( (synpred63_FiltersLanguageGrammar()) ) { s = 92; }

                   	 
                   	input.Seek(index21_98);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA21_50 = input.LA(1);

                   	 
                   	int index21_50 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred35_FiltersLanguageGrammar()) ) { s = 49; }

                   	else if ( (synpred41_FiltersLanguageGrammar()) ) { s = 52; }

                   	else if ( (synpred83_FiltersLanguageGrammar()) ) { s = 83; }

                   	else if ( (synpred85_FiltersLanguageGrammar()) ) { s = 84; }

                   	 
                   	input.Seek(index21_50);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 3 : 
                   	int LA21_96 = input.LA(1);

                   	 
                   	int index21_96 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred49_FiltersLanguageGrammar()) ) { s = 60; }

                   	else if ( (synpred51_FiltersLanguageGrammar()) ) { s = 89; }

                   	 
                   	input.Seek(index21_96);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae21 =
            new NoViableAltException(dfa.Description, 21, _s, input);
        dfa.Error(nvae21);
        throw nvae21;
    }
 

    public static readonly BitSet FOLLOW_expr_in_main77 = new BitSet(new ulong[]{0x0000000000000000UL});
    public static readonly BitSet FOLLOW_EOF_in_main79 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_logicalexpr_in_expr114 = new BitSet(new ulong[]{0x0000800000000000UL});
    public static readonly BitSet FOLLOW_columnsspec_in_expr120 = new BitSet(new ulong[]{0x0008000000000000UL});
    public static readonly BitSet FOLLOW_sortingspec_in_expr126 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_logicalexpr_in_expr171 = new BitSet(new ulong[]{0x0000800000000000UL});
    public static readonly BitSet FOLLOW_columnsspec_in_expr177 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_logicalexpr_in_expr222 = new BitSet(new ulong[]{0x0008000000000000UL});
    public static readonly BitSet FOLLOW_sortingspec_in_expr228 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_logicalexpr_in_expr273 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_9_in_expr318 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_10_in_expr320 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_query_in_expr322 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_11_in_expr324 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_12_in_expr342 = new BitSet(new ulong[]{0x0000006000010410UL});
    public static readonly BitSet FOLLOW_logicalexpr_in_expr344 = new BitSet(new ulong[]{0x0000800000000000UL});
    public static readonly BitSet FOLLOW_columnsspec_in_expr350 = new BitSet(new ulong[]{0x0008000000000000UL});
    public static readonly BitSet FOLLOW_sortingspec_in_expr356 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_12_in_expr401 = new BitSet(new ulong[]{0x0000006000010410UL});
    public static readonly BitSet FOLLOW_logicalexpr_in_expr403 = new BitSet(new ulong[]{0x0000800000000000UL});
    public static readonly BitSet FOLLOW_columnsspec_in_expr409 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_12_in_expr454 = new BitSet(new ulong[]{0x0000006000010410UL});
    public static readonly BitSet FOLLOW_logicalexpr_in_expr456 = new BitSet(new ulong[]{0x0008000000000000UL});
    public static readonly BitSet FOLLOW_sortingspec_in_expr462 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_12_in_expr507 = new BitSet(new ulong[]{0x0000006000010410UL});
    public static readonly BitSet FOLLOW_logicalexpr_in_expr509 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_12_in_expr554 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_9_in_expr556 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_10_in_expr558 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_query_in_expr560 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_11_in_expr562 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_13_in_expr584 = new BitSet(new ulong[]{0x0000006000010410UL});
    public static readonly BitSet FOLLOW_logicalexpr_in_expr586 = new BitSet(new ulong[]{0x0000800000000000UL});
    public static readonly BitSet FOLLOW_columnsspec_in_expr592 = new BitSet(new ulong[]{0x0008000000000000UL});
    public static readonly BitSet FOLLOW_sortingspec_in_expr598 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_13_in_expr643 = new BitSet(new ulong[]{0x0000006000010410UL});
    public static readonly BitSet FOLLOW_logicalexpr_in_expr645 = new BitSet(new ulong[]{0x0000800000000000UL});
    public static readonly BitSet FOLLOW_columnsspec_in_expr651 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_13_in_expr696 = new BitSet(new ulong[]{0x0000006000010410UL});
    public static readonly BitSet FOLLOW_logicalexpr_in_expr698 = new BitSet(new ulong[]{0x0008000000000000UL});
    public static readonly BitSet FOLLOW_sortingspec_in_expr704 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_13_in_expr749 = new BitSet(new ulong[]{0x0000006000010410UL});
    public static readonly BitSet FOLLOW_logicalexpr_in_expr751 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_13_in_expr796 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_9_in_expr798 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_10_in_expr800 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_query_in_expr802 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_11_in_expr804 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_andatom_in_logicalexpr839 = new BitSet(new ulong[]{0x0000000000004002UL});
    public static readonly BitSet FOLLOW_14_in_logicalexpr855 = new BitSet(new ulong[]{0x0000006000010410UL});
    public static readonly BitSet FOLLOW_andatom_in_logicalexpr861 = new BitSet(new ulong[]{0x0000000000004002UL});
    public static readonly BitSet FOLLOW_notexpr_in_andatom899 = new BitSet(new ulong[]{0x0000000000008002UL});
    public static readonly BitSet FOLLOW_15_in_andatom915 = new BitSet(new ulong[]{0x0000006000010410UL});
    public static readonly BitSet FOLLOW_notexpr_in_andatom921 = new BitSet(new ulong[]{0x0000000000008002UL});
    public static readonly BitSet FOLLOW_16_in_notexpr953 = new BitSet(new ulong[]{0x0000006000010410UL});
    public static readonly BitSet FOLLOW_paramexpr_in_notexpr959 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_paramexpr_in_notexpr977 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_10_in_paramexpr996 = new BitSet(new ulong[]{0x0000006000010410UL});
    public static readonly BitSet FOLLOW_logicalexpr_in_paramexpr998 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_11_in_paramexpr1000 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_token_for_fts_in_paramexpr1028 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parametersStr_in_paramexpr1067 = new BitSet(new ulong[]{0x03F0000000000000UL});
    public static readonly BitSet FOLLOW_internalop_in_paramexpr1069 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_valStr_in_paramexpr1071 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_paramLongStr_in_paramexpr1111 = new BitSet(new ulong[]{0x0030000000000000UL});
    public static readonly BitSet FOLLOW_internalLongStrOp_in_paramexpr1113 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_valLongStr_in_paramexpr1115 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parametersStr_in_paramexpr1152 = new BitSet(new ulong[]{0x0400000000000000UL});
    public static readonly BitSet FOLLOW_contains_in_paramexpr1154 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_containsVal_in_paramexpr1156 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_paramLongStr_in_paramexpr1195 = new BitSet(new ulong[]{0x0400000000000000UL});
    public static readonly BitSet FOLLOW_contains_in_paramexpr1197 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_containsVal_in_paramexpr1199 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parametersUser_in_paramexpr1238 = new BitSet(new ulong[]{0x0400000000000000UL});
    public static readonly BitSet FOLLOW_contains_in_paramexpr1240 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_containsVal_in_paramexpr1242 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parametersStr_in_paramexpr1281 = new BitSet(new ulong[]{0x2000000000000000UL});
    public static readonly BitSet FOLLOW_doesNotContains_in_paramexpr1283 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_doesNotContainsVal_in_paramexpr1285 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_paramLongStr_in_paramexpr1320 = new BitSet(new ulong[]{0x2000000000000000UL});
    public static readonly BitSet FOLLOW_doesNotContains_in_paramexpr1322 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_doesNotContainsVal_in_paramexpr1324 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parametersUser_in_paramexpr1360 = new BitSet(new ulong[]{0x2000000000000000UL});
    public static readonly BitSet FOLLOW_doesNotContains_in_paramexpr1362 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_doesNotContainsVal_in_paramexpr1364 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parametersStr_in_paramexpr1399 = new BitSet(new ulong[]{0x0800000000000000UL});
    public static readonly BitSet FOLLOW_startsWith_in_paramexpr1401 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_startsWithVal_in_paramexpr1403 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_paramLongStr_in_paramexpr1441 = new BitSet(new ulong[]{0x0800000000000000UL});
    public static readonly BitSet FOLLOW_startsWith_in_paramexpr1443 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_startsWithVal_in_paramexpr1445 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parametersUser_in_paramexpr1483 = new BitSet(new ulong[]{0x0800000000000000UL});
    public static readonly BitSet FOLLOW_startsWith_in_paramexpr1485 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_startsWithVal_in_paramexpr1487 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parametersStr_in_paramexpr1525 = new BitSet(new ulong[]{0x1000000000000000UL});
    public static readonly BitSet FOLLOW_endsWith_in_paramexpr1527 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_endsWithVal_in_paramexpr1529 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_paramLongStr_in_paramexpr1568 = new BitSet(new ulong[]{0x1000000000000000UL});
    public static readonly BitSet FOLLOW_endsWith_in_paramexpr1570 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_endsWithVal_in_paramexpr1572 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parametersUser_in_paramexpr1611 = new BitSet(new ulong[]{0x1000000000000000UL});
    public static readonly BitSet FOLLOW_endsWith_in_paramexpr1613 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_endsWithVal_in_paramexpr1615 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parametersInt_in_paramexpr1654 = new BitSet(new ulong[]{0x03F0000000000000UL});
    public static readonly BitSet FOLLOW_internalop_in_paramexpr1656 = new BitSet(new ulong[]{0x0000000000000030UL});
    public static readonly BitSet FOLLOW_valInt_in_paramexpr1658 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parametersDate_in_paramexpr1698 = new BitSet(new ulong[]{0x03F0000000000000UL});
    public static readonly BitSet FOLLOW_internalop_in_paramexpr1700 = new BitSet(new ulong[]{0x0000000007F80050UL});
    public static readonly BitSet FOLLOW_valDate_in_paramexpr1702 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parametersDate_in_paramexpr1740 = new BitSet(new ulong[]{0x0030000000000000UL});
    public static readonly BitSet FOLLOW_internalopSpan_in_paramexpr1742 = new BitSet(new ulong[]{0x00000007F8000000UL});
    public static readonly BitSet FOLLOW_valDateSpan_in_paramexpr1744 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parametersDate_in_paramexpr1780 = new BitSet(new ulong[]{0x0100000000000000UL});
    public static readonly BitSet FOLLOW_lsOpSpan_in_paramexpr1782 = new BitSet(new ulong[]{0x00000007F8000000UL});
    public static readonly BitSet FOLLOW_valDateSpanLs_in_paramexpr1784 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parametersDate_in_paramexpr1821 = new BitSet(new ulong[]{0x0040000000000000UL});
    public static readonly BitSet FOLLOW_grOpSpan_in_paramexpr1823 = new BitSet(new ulong[]{0x00000007F8000000UL});
    public static readonly BitSet FOLLOW_valDateSpanGr_in_paramexpr1825 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parametersDate_in_paramexpr1862 = new BitSet(new ulong[]{0x0200000000000000UL});
    public static readonly BitSet FOLLOW_lsOrEqOpSpan_in_paramexpr1864 = new BitSet(new ulong[]{0x00000007F8000000UL});
    public static readonly BitSet FOLLOW_valDateSpanLsOrEq_in_paramexpr1866 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parametersDate_in_paramexpr1901 = new BitSet(new ulong[]{0x0080000000000000UL});
    public static readonly BitSet FOLLOW_grOrEqOpSpan_in_paramexpr1903 = new BitSet(new ulong[]{0x00000007F8000000UL});
    public static readonly BitSet FOLLOW_valDateSpanGrOrEq_in_paramexpr1905 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parametersUser_in_paramexpr1940 = new BitSet(new ulong[]{0x03F0000000000000UL});
    public static readonly BitSet FOLLOW_internalop_in_paramexpr1942 = new BitSet(new ulong[]{0x0000001800000010UL});
    public static readonly BitSet FOLLOW_valUser_in_paramexpr1944 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parametersBool_in_paramexpr1982 = new BitSet(new ulong[]{0x03F0000000000000UL});
    public static readonly BitSet FOLLOW_internalop_in_paramexpr1984 = new BitSet(new ulong[]{0x8000000000000000UL,0x0000000000000007UL});
    public static readonly BitSet FOLLOW_valBool_in_paramexpr1986 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parametersMapped_in_paramexpr2024 = new BitSet(new ulong[]{0x03F0000000000000UL});
    public static readonly BitSet FOLLOW_internalop_in_paramexpr2026 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_valStr_in_paramexpr2028 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parametersStr_in_paramexpr2067 = new BitSet(new ulong[]{0x4000000000000000UL});
    public static readonly BitSet FOLLOW_multivalueinternalop_in_paramexpr2069 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_10_in_paramexpr2071 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_valStr_in_paramexpr2077 = new BitSet(new ulong[]{0x0000000000020800UL});
    public static readonly BitSet FOLLOW_17_in_paramexpr2080 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_valStr_in_paramexpr2086 = new BitSet(new ulong[]{0x0000000000020800UL});
    public static readonly BitSet FOLLOW_11_in_paramexpr2090 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parametersInt_in_paramexpr2124 = new BitSet(new ulong[]{0x4000000000000000UL});
    public static readonly BitSet FOLLOW_multivalueinternalop_in_paramexpr2126 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_10_in_paramexpr2128 = new BitSet(new ulong[]{0x0000000000000030UL});
    public static readonly BitSet FOLLOW_valInt_in_paramexpr2134 = new BitSet(new ulong[]{0x0000000000020800UL});
    public static readonly BitSet FOLLOW_17_in_paramexpr2137 = new BitSet(new ulong[]{0x0000000000000030UL});
    public static readonly BitSet FOLLOW_valInt_in_paramexpr2143 = new BitSet(new ulong[]{0x0000000000020800UL});
    public static readonly BitSet FOLLOW_11_in_paramexpr2147 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parametersDate_in_paramexpr2181 = new BitSet(new ulong[]{0x4000000000000000UL});
    public static readonly BitSet FOLLOW_multivalueinternalop_in_paramexpr2183 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_10_in_paramexpr2185 = new BitSet(new ulong[]{0x0000000007F80050UL});
    public static readonly BitSet FOLLOW_valDate_in_paramexpr2191 = new BitSet(new ulong[]{0x0000000000020800UL});
    public static readonly BitSet FOLLOW_17_in_paramexpr2194 = new BitSet(new ulong[]{0x0000000007F80050UL});
    public static readonly BitSet FOLLOW_valDate_in_paramexpr2200 = new BitSet(new ulong[]{0x0000000000020800UL});
    public static readonly BitSet FOLLOW_11_in_paramexpr2204 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parametersUser_in_paramexpr2236 = new BitSet(new ulong[]{0x4000000000000000UL});
    public static readonly BitSet FOLLOW_multivalueinternalop_in_paramexpr2238 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_10_in_paramexpr2240 = new BitSet(new ulong[]{0x0000001800000010UL});
    public static readonly BitSet FOLLOW_valUser_in_paramexpr2246 = new BitSet(new ulong[]{0x0000000000020800UL});
    public static readonly BitSet FOLLOW_17_in_paramexpr2249 = new BitSet(new ulong[]{0x0000001800000010UL});
    public static readonly BitSet FOLLOW_valUser_in_paramexpr2255 = new BitSet(new ulong[]{0x0000000000020800UL});
    public static readonly BitSet FOLLOW_11_in_paramexpr2259 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_paramLongStr_in_paramexpr2291 = new BitSet(new ulong[]{0x4000000000000000UL});
    public static readonly BitSet FOLLOW_multivalueinternalop_in_paramexpr2293 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_10_in_paramexpr2295 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_valStr_in_paramexpr2301 = new BitSet(new ulong[]{0x0000000000020800UL});
    public static readonly BitSet FOLLOW_17_in_paramexpr2304 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_valStr_in_paramexpr2310 = new BitSet(new ulong[]{0x0000000000020800UL});
    public static readonly BitSet FOLLOW_11_in_paramexpr2314 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parametersMapped_in_paramexpr2346 = new BitSet(new ulong[]{0x4000000000000000UL});
    public static readonly BitSet FOLLOW_multivalueinternalop_in_paramexpr2348 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_10_in_paramexpr2350 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_valStr_in_paramexpr2356 = new BitSet(new ulong[]{0x0000000000020800UL});
    public static readonly BitSet FOLLOW_17_in_paramexpr2359 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_valStr_in_paramexpr2365 = new BitSet(new ulong[]{0x0000000000020800UL});
    public static readonly BitSet FOLLOW_11_in_paramexpr2369 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parametersStr_in_paramexpr2402 = new BitSet(new ulong[]{0x0000000000040000UL});
    public static readonly BitSet FOLLOW_18_in_paramexpr2404 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_10_in_paramexpr2406 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_valStr_in_paramexpr2412 = new BitSet(new ulong[]{0x0000000000020800UL});
    public static readonly BitSet FOLLOW_17_in_paramexpr2415 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_valStr_in_paramexpr2421 = new BitSet(new ulong[]{0x0000000000020800UL});
    public static readonly BitSet FOLLOW_11_in_paramexpr2425 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parametersInt_in_paramexpr2466 = new BitSet(new ulong[]{0x0000000000040000UL});
    public static readonly BitSet FOLLOW_18_in_paramexpr2468 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_10_in_paramexpr2470 = new BitSet(new ulong[]{0x0000000000000030UL});
    public static readonly BitSet FOLLOW_valInt_in_paramexpr2476 = new BitSet(new ulong[]{0x0000000000020800UL});
    public static readonly BitSet FOLLOW_17_in_paramexpr2479 = new BitSet(new ulong[]{0x0000000000000030UL});
    public static readonly BitSet FOLLOW_valInt_in_paramexpr2485 = new BitSet(new ulong[]{0x0000000000020800UL});
    public static readonly BitSet FOLLOW_11_in_paramexpr2489 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parametersDate_in_paramexpr2530 = new BitSet(new ulong[]{0x0000000000040000UL});
    public static readonly BitSet FOLLOW_18_in_paramexpr2532 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_10_in_paramexpr2534 = new BitSet(new ulong[]{0x0000000007F80050UL});
    public static readonly BitSet FOLLOW_valDate_in_paramexpr2540 = new BitSet(new ulong[]{0x0000000000020800UL});
    public static readonly BitSet FOLLOW_17_in_paramexpr2543 = new BitSet(new ulong[]{0x0000000007F80050UL});
    public static readonly BitSet FOLLOW_valDate_in_paramexpr2549 = new BitSet(new ulong[]{0x0000000000020800UL});
    public static readonly BitSet FOLLOW_11_in_paramexpr2553 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parametersUser_in_paramexpr2594 = new BitSet(new ulong[]{0x0000000000040000UL});
    public static readonly BitSet FOLLOW_18_in_paramexpr2596 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_10_in_paramexpr2598 = new BitSet(new ulong[]{0x0000001800000010UL});
    public static readonly BitSet FOLLOW_valUser_in_paramexpr2604 = new BitSet(new ulong[]{0x0000000000020800UL});
    public static readonly BitSet FOLLOW_17_in_paramexpr2607 = new BitSet(new ulong[]{0x0000001800000010UL});
    public static readonly BitSet FOLLOW_valUser_in_paramexpr2613 = new BitSet(new ulong[]{0x0000000000020800UL});
    public static readonly BitSet FOLLOW_11_in_paramexpr2617 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parametersBool_in_paramexpr2659 = new BitSet(new ulong[]{0x0000000000040000UL});
    public static readonly BitSet FOLLOW_18_in_paramexpr2661 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_10_in_paramexpr2663 = new BitSet(new ulong[]{0x8000000000000000UL,0x0000000000000007UL});
    public static readonly BitSet FOLLOW_valBool_in_paramexpr2669 = new BitSet(new ulong[]{0x0000000000020800UL});
    public static readonly BitSet FOLLOW_17_in_paramexpr2672 = new BitSet(new ulong[]{0x8000000000000000UL,0x0000000000000007UL});
    public static readonly BitSet FOLLOW_valBool_in_paramexpr2678 = new BitSet(new ulong[]{0x0000000000020800UL});
    public static readonly BitSet FOLLOW_11_in_paramexpr2682 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parametersDate_in_paramexpr2723 = new BitSet(new ulong[]{0x0000000000040000UL});
    public static readonly BitSet FOLLOW_18_in_paramexpr2725 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_10_in_paramexpr2727 = new BitSet(new ulong[]{0x00000007F8000000UL});
    public static readonly BitSet FOLLOW_valDateSpan_in_paramexpr2733 = new BitSet(new ulong[]{0x0000000000020800UL});
    public static readonly BitSet FOLLOW_17_in_paramexpr2736 = new BitSet(new ulong[]{0x00000007F8000000UL});
    public static readonly BitSet FOLLOW_valDateSpan_in_paramexpr2742 = new BitSet(new ulong[]{0x0000000000020800UL});
    public static readonly BitSet FOLLOW_11_in_paramexpr2746 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_paramLongStr_in_paramexpr2787 = new BitSet(new ulong[]{0x0000000000040000UL});
    public static readonly BitSet FOLLOW_18_in_paramexpr2789 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_10_in_paramexpr2791 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_valStr_in_paramexpr2797 = new BitSet(new ulong[]{0x0000000000020800UL});
    public static readonly BitSet FOLLOW_17_in_paramexpr2800 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_valStr_in_paramexpr2806 = new BitSet(new ulong[]{0x0000000000020800UL});
    public static readonly BitSet FOLLOW_11_in_paramexpr2810 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parametersMapped_in_paramexpr2851 = new BitSet(new ulong[]{0x0000000000040000UL});
    public static readonly BitSet FOLLOW_18_in_paramexpr2853 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_10_in_paramexpr2855 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_valStr_in_paramexpr2861 = new BitSet(new ulong[]{0x0000000000020800UL});
    public static readonly BitSet FOLLOW_17_in_paramexpr2864 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_valStr_in_paramexpr2870 = new BitSet(new ulong[]{0x0000000000020800UL});
    public static readonly BitSet FOLLOW_11_in_paramexpr2874 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parametersManyToMany_in_paramexpr2915 = new BitSet(new ulong[]{0x03D0000000000000UL});
    public static readonly BitSet FOLLOW_internalopN2M_in_paramexpr2917 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_valStr_in_paramexpr2919 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parametersManyToMany_in_paramexpr3046 = new BitSet(new ulong[]{0x0020000000000000UL});
    public static readonly BitSet FOLLOW_internalopNotEqN2M_in_paramexpr3048 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_valStr_in_paramexpr3050 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parametersManyToMany_in_paramexpr3179 = new BitSet(new ulong[]{0x4000000000000000UL});
    public static readonly BitSet FOLLOW_multivalueinternalop_in_paramexpr3181 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_10_in_paramexpr3183 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_valStr_in_paramexpr3189 = new BitSet(new ulong[]{0x0000000000020800UL});
    public static readonly BitSet FOLLOW_17_in_paramexpr3192 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_valStr_in_paramexpr3198 = new BitSet(new ulong[]{0x0000000000020800UL});
    public static readonly BitSet FOLLOW_11_in_paramexpr3202 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parametersManyToMany_in_paramexpr3337 = new BitSet(new ulong[]{0x0000000000040000UL});
    public static readonly BitSet FOLLOW_18_in_paramexpr3339 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_10_in_paramexpr3341 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_valStr_in_paramexpr3347 = new BitSet(new ulong[]{0x0000000000020800UL});
    public static readonly BitSet FOLLOW_17_in_paramexpr3350 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_valStr_in_paramexpr3356 = new BitSet(new ulong[]{0x0000000000020800UL});
    public static readonly BitSet FOLLOW_11_in_paramexpr3360 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parametersManyToMany_in_paramexpr3488 = new BitSet(new ulong[]{0x0400000000000000UL});
    public static readonly BitSet FOLLOW_contains_in_paramexpr3490 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_containsVal_in_paramexpr3492 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parametersManyToMany_in_paramexpr3619 = new BitSet(new ulong[]{0x2000000000000000UL});
    public static readonly BitSet FOLLOW_doesNotContains_in_paramexpr3621 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_doesNotContainsVal_in_paramexpr3623 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parametersManyToMany_in_paramexpr3752 = new BitSet(new ulong[]{0x0800000000000000UL});
    public static readonly BitSet FOLLOW_startsWith_in_paramexpr3754 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_startsWithVal_in_paramexpr3756 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parametersManyToMany_in_paramexpr3883 = new BitSet(new ulong[]{0x1000000000000000UL});
    public static readonly BitSet FOLLOW_endsWith_in_paramexpr3885 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_endsWithVal_in_paramexpr3887 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parametersTextifyOneToMany_in_paramexpr4014 = new BitSet(new ulong[]{0x03D0000000000000UL});
    public static readonly BitSet FOLLOW_internalopN2M_in_paramexpr4016 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_valStr_in_paramexpr4018 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parametersTextifyOneToMany_in_paramexpr4151 = new BitSet(new ulong[]{0x0020000000000000UL});
    public static readonly BitSet FOLLOW_internalopNotEqN2M_in_paramexpr4153 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_valStr_in_paramexpr4155 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parametersConstOneToMany_in_paramexpr4269 = new BitSet(new ulong[]{0x03D0000000000000UL});
    public static readonly BitSet FOLLOW_internalopN2M_in_paramexpr4271 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_valStr_in_paramexpr4273 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parametersConstOneToMany_in_paramexpr4424 = new BitSet(new ulong[]{0x0020000000000000UL});
    public static readonly BitSet FOLLOW_internalopNotEqN2M_in_paramexpr4426 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_valStr_in_paramexpr4428 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parametersTableMappedOneToMany_in_paramexpr4579 = new BitSet(new ulong[]{0x03D0000000000000UL});
    public static readonly BitSet FOLLOW_internalopN2M_in_paramexpr4581 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_valStr_in_paramexpr4583 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parametersTableMappedOneToMany_in_paramexpr4748 = new BitSet(new ulong[]{0x0020000000000000UL});
    public static readonly BitSet FOLLOW_internalopNotEqN2M_in_paramexpr4750 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_valStr_in_paramexpr4752 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_STRING_in_valInt4933 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INT_in_valInt4971 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_boolToken_in_valBool5009 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_STRING_in_query5049 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_STRING_in_valStr5097 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_STRING_in_valLongStr5144 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_19_in_valDate5192 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_20_in_valDate5234 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_21_in_valDate5276 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_22_in_valDate5318 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_23_in_valDate5360 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_24_in_valDate5402 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_25_in_valDate5444 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_26_in_valDate5486 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_STRING_in_valDate5528 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_DATE_in_valDate5570 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_27_in_valDateSpanLs5617 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_28_in_valDateSpanLs5661 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_29_in_valDateSpanLs5705 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_30_in_valDateSpanLs5749 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_31_in_valDateSpanLs5793 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_32_in_valDateSpanLs5837 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_33_in_valDateSpanLs5881 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_34_in_valDateSpanLs5925 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_27_in_valDateSpanLsOrEq5974 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_28_in_valDateSpanLsOrEq6020 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_29_in_valDateSpanLsOrEq6066 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_30_in_valDateSpanLsOrEq6112 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_31_in_valDateSpanLsOrEq6158 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_32_in_valDateSpanLsOrEq6204 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_33_in_valDateSpanLsOrEq6250 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_34_in_valDateSpanLsOrEq6296 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_27_in_valDateSpanGr6347 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_28_in_valDateSpanGr6391 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_29_in_valDateSpanGr6435 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_30_in_valDateSpanGr6479 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_31_in_valDateSpanGr6523 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_32_in_valDateSpanGr6567 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_33_in_valDateSpanGr6611 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_34_in_valDateSpanGr6655 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_27_in_valDateSpanGrOrEq6704 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_28_in_valDateSpanGrOrEq6750 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_29_in_valDateSpanGrOrEq6796 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_30_in_valDateSpanGrOrEq6842 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_31_in_valDateSpanGrOrEq6888 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_32_in_valDateSpanGrOrEq6934 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_33_in_valDateSpanGrOrEq6980 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_34_in_valDateSpanGrOrEq7026 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_27_in_valDateSpan7077 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_28_in_valDateSpan7126 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_29_in_valDateSpan7175 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_30_in_valDateSpan7224 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_31_in_valDateSpan7273 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_32_in_valDateSpan7322 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_33_in_valDateSpan7371 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_34_in_valDateSpan7420 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_STRING_in_valUser7475 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_35_in_valUser7517 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_36_in_valUser7559 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_37_in_parametersStr7615 = new BitSet(new ulong[]{0x0000060000000000UL});
    public static readonly BitSet FOLLOW_user_stringparameters_in_parametersStr7618 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_38_in_parametersStr7638 = new BitSet(new ulong[]{0x0000060000000000UL});
    public static readonly BitSet FOLLOW_user_stringparameters_in_parametersStr7641 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_37_in_paramLongStr7674 = new BitSet(new ulong[]{0x0000010000000000UL});
    public static readonly BitSet FOLLOW_user_longstringparameters_in_paramLongStr7677 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_38_in_paramLongStr7697 = new BitSet(new ulong[]{0x0000010000000000UL});
    public static readonly BitSet FOLLOW_user_longstringparameters_in_paramLongStr7700 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_37_in_parametersInt7733 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_user_intparameters_in_parametersInt7736 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_38_in_parametersInt7756 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_user_intparameters_in_parametersInt7759 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_37_in_parametersDate7792 = new BitSet(new ulong[]{0x0000000000000000UL});
    public static readonly BitSet FOLLOW_user_normaldateparameters_in_parametersDate7795 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_38_in_parametersDate7815 = new BitSet(new ulong[]{0x0000000000000000UL});
    public static readonly BitSet FOLLOW_user_normaldateparameters_in_parametersDate7818 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_37_in_parametersDate7838 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_user_pastdateparameters_in_parametersDate7841 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_38_in_parametersDate7861 = new BitSet(new ulong[]{0x0000080000000000UL});
    public static readonly BitSet FOLLOW_user_pastdateparameters_in_parametersDate7864 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_37_in_parametersUser7897 = new BitSet(new ulong[]{0x0000000000000000UL});
    public static readonly BitSet FOLLOW_user_userparameters_in_parametersUser7900 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_38_in_parametersUser7920 = new BitSet(new ulong[]{0x0000000000000000UL});
    public static readonly BitSet FOLLOW_user_userparameters_in_parametersUser7923 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_37_in_parametersBool7956 = new BitSet(new ulong[]{0x0000000000000000UL});
    public static readonly BitSet FOLLOW_user_boolparameters_in_parametersBool7959 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_38_in_parametersBool7979 = new BitSet(new ulong[]{0x0000000000000000UL});
    public static readonly BitSet FOLLOW_user_boolparameters_in_parametersBool7982 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_37_in_parametersMapped8014 = new BitSet(new ulong[]{0x0000100000000000UL});
    public static readonly BitSet FOLLOW_user_mappedparameters_in_parametersMapped8017 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_38_in_parametersMapped8037 = new BitSet(new ulong[]{0x0000100000000000UL});
    public static readonly BitSet FOLLOW_user_mappedparameters_in_parametersMapped8040 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_37_in_parametersManyToMany8071 = new BitSet(new ulong[]{0x0000400000000000UL});
    public static readonly BitSet FOLLOW_user_manytomanyparameters_in_parametersManyToMany8074 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_38_in_parametersManyToMany8094 = new BitSet(new ulong[]{0x0000400000000000UL});
    public static readonly BitSet FOLLOW_user_manytomanyparameters_in_parametersManyToMany8097 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_37_in_parametersConstOneToMany8129 = new BitSet(new ulong[]{0x0000000000000000UL});
    public static readonly BitSet FOLLOW_user_constonetomanyparameters_in_parametersConstOneToMany8132 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_38_in_parametersConstOneToMany8152 = new BitSet(new ulong[]{0x0000000000000000UL});
    public static readonly BitSet FOLLOW_user_constonetomanyparameters_in_parametersConstOneToMany8155 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_37_in_parametersTextifyOneToMany8189 = new BitSet(new ulong[]{0x0000000000000000UL});
    public static readonly BitSet FOLLOW_user_textifyonetomanyparameters_in_parametersTextifyOneToMany8192 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_38_in_parametersTextifyOneToMany8212 = new BitSet(new ulong[]{0x0000000000000000UL});
    public static readonly BitSet FOLLOW_user_textifyonetomanyparameters_in_parametersTextifyOneToMany8215 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_37_in_parametersTableMappedOneToMany8248 = new BitSet(new ulong[]{0x0000008000000000UL});
    public static readonly BitSet FOLLOW_user_tablemappedonetomanyparameters_in_parametersTableMappedOneToMany8251 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_38_in_parametersTableMappedOneToMany8271 = new BitSet(new ulong[]{0x0000008000000000UL});
    public static readonly BitSet FOLLOW_user_tablemappedonetomanyparameters_in_parametersTableMappedOneToMany8274 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_STRING_in_token_for_fts8314 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_39_in_user_tablemappedonetomanyparameters8362 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_40_in_user_longstringparameters8392 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_41_in_user_stringparameters8428 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_42_in_user_stringparameters8449 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_43_in_user_pastdateparameters8485 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_44_in_user_mappedparameters8509 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_45_in_user_intparameters8533 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_46_in_user_manytomanyparameters8557 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_39_in_user_columnsvisible8589 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_40_in_user_columnsvisible8626 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_41_in_user_columnsvisible8644 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_42_in_user_columnsvisible8662 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_43_in_user_columnsvisible8680 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_44_in_user_columnsvisible8698 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_45_in_user_columnsvisible8716 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_46_in_user_columnsvisible8734 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_47_in_columnsspec8777 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_10_in_columnsspec8779 = new BitSet(new ulong[]{0x00007F8000000000UL});
    public static readonly BitSet FOLLOW_user_columnsvisible_in_columnsspec8785 = new BitSet(new ulong[]{0x0001000000020800UL});
    public static readonly BitSet FOLLOW_48_in_columnsspec8788 = new BitSet(new ulong[]{0x0000000000000030UL});
    public static readonly BitSet FOLLOW_valInt_in_columnsspec8794 = new BitSet(new ulong[]{0x0000000000020800UL});
    public static readonly BitSet FOLLOW_17_in_columnsspec8799 = new BitSet(new ulong[]{0x00007F8000000000UL});
    public static readonly BitSet FOLLOW_user_columnsvisible_in_columnsspec8805 = new BitSet(new ulong[]{0x0001000000020800UL});
    public static readonly BitSet FOLLOW_48_in_columnsspec8808 = new BitSet(new ulong[]{0x0000000000000030UL});
    public static readonly BitSet FOLLOW_valInt_in_columnsspec8814 = new BitSet(new ulong[]{0x0000000000020800UL});
    public static readonly BitSet FOLLOW_11_in_columnsspec8821 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_39_in_user_sortingcolumns8863 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_40_in_user_sortingcolumns8904 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_41_in_user_sortingcolumns8936 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_42_in_user_sortingcolumns8968 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_43_in_user_sortingcolumns9000 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_44_in_user_sortingcolumns9032 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_45_in_user_sortingcolumns9064 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_46_in_user_sortingcolumns9096 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_49_in_sortingdir9142 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_50_in_sortingdir9172 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_51_in_sortingspec9211 = new BitSet(new ulong[]{0x0001000000000000UL});
    public static readonly BitSet FOLLOW_48_in_sortingspec9213 = new BitSet(new ulong[]{0x00007F8000000000UL});
    public static readonly BitSet FOLLOW_user_sortingcolumns_in_sortingspec9215 = new BitSet(new ulong[]{0x0006000000000000UL});
    public static readonly BitSet FOLLOW_sortingdir_in_sortingspec9217 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_52_in_internalLongStrOp9254 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_53_in_internalLongStrOp9274 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_52_in_internalopSpan9300 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_53_in_internalopSpan9320 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_54_in_grOpSpan9347 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_55_in_grOrEqOpSpan9374 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_56_in_lsOpSpan9401 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_57_in_lsOrEqOpSpan9428 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_52_in_internalop9455 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_54_in_internalop9475 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_56_in_internalop9495 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_55_in_internalop9515 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_57_in_internalop9534 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_53_in_internalop9553 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_52_in_internalopN2M9579 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_54_in_internalopN2M9599 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_56_in_internalopN2M9619 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_55_in_internalopN2M9639 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_57_in_internalopN2M9658 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_53_in_internalopNotEqN2M9683 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_58_in_contains9710 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_STRING_in_containsVal9740 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_59_in_startsWith9783 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_STRING_in_startsWithVal9811 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_60_in_endsWith9853 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_STRING_in_endsWithVal9883 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_61_in_doesNotContains9920 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_STRING_in_doesNotContainsVal9946 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_62_in_multivalueinternalop9981 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_63_in_boolToken10011 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_64_in_boolToken10027 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_65_in_boolToken10043 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_66_in_boolToken10060 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_logicalexpr_in_synpred1_FiltersLanguageGrammar114 = new BitSet(new ulong[]{0x0000800000000000UL});
    public static readonly BitSet FOLLOW_columnsspec_in_synpred1_FiltersLanguageGrammar120 = new BitSet(new ulong[]{0x0008000000000000UL});
    public static readonly BitSet FOLLOW_sortingspec_in_synpred1_FiltersLanguageGrammar126 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_logicalexpr_in_synpred2_FiltersLanguageGrammar171 = new BitSet(new ulong[]{0x0000800000000000UL});
    public static readonly BitSet FOLLOW_columnsspec_in_synpred2_FiltersLanguageGrammar177 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_logicalexpr_in_synpred3_FiltersLanguageGrammar222 = new BitSet(new ulong[]{0x0008000000000000UL});
    public static readonly BitSet FOLLOW_sortingspec_in_synpred3_FiltersLanguageGrammar228 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_logicalexpr_in_synpred4_FiltersLanguageGrammar273 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_12_in_synpred6_FiltersLanguageGrammar342 = new BitSet(new ulong[]{0x0000006000010410UL});
    public static readonly BitSet FOLLOW_logicalexpr_in_synpred6_FiltersLanguageGrammar344 = new BitSet(new ulong[]{0x0000800000000000UL});
    public static readonly BitSet FOLLOW_columnsspec_in_synpred6_FiltersLanguageGrammar350 = new BitSet(new ulong[]{0x0008000000000000UL});
    public static readonly BitSet FOLLOW_sortingspec_in_synpred6_FiltersLanguageGrammar356 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_12_in_synpred7_FiltersLanguageGrammar401 = new BitSet(new ulong[]{0x0000006000010410UL});
    public static readonly BitSet FOLLOW_logicalexpr_in_synpred7_FiltersLanguageGrammar403 = new BitSet(new ulong[]{0x0000800000000000UL});
    public static readonly BitSet FOLLOW_columnsspec_in_synpred7_FiltersLanguageGrammar409 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_12_in_synpred8_FiltersLanguageGrammar454 = new BitSet(new ulong[]{0x0000006000010410UL});
    public static readonly BitSet FOLLOW_logicalexpr_in_synpred8_FiltersLanguageGrammar456 = new BitSet(new ulong[]{0x0008000000000000UL});
    public static readonly BitSet FOLLOW_sortingspec_in_synpred8_FiltersLanguageGrammar462 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_12_in_synpred9_FiltersLanguageGrammar507 = new BitSet(new ulong[]{0x0000006000010410UL});
    public static readonly BitSet FOLLOW_logicalexpr_in_synpred9_FiltersLanguageGrammar509 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_12_in_synpred10_FiltersLanguageGrammar554 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_9_in_synpred10_FiltersLanguageGrammar556 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_10_in_synpred10_FiltersLanguageGrammar558 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_query_in_synpred10_FiltersLanguageGrammar560 = new BitSet(new ulong[]{0x0000000000000800UL});
    public static readonly BitSet FOLLOW_11_in_synpred10_FiltersLanguageGrammar562 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_13_in_synpred11_FiltersLanguageGrammar584 = new BitSet(new ulong[]{0x0000006000010410UL});
    public static readonly BitSet FOLLOW_logicalexpr_in_synpred11_FiltersLanguageGrammar586 = new BitSet(new ulong[]{0x0000800000000000UL});
    public static readonly BitSet FOLLOW_columnsspec_in_synpred11_FiltersLanguageGrammar592 = new BitSet(new ulong[]{0x0008000000000000UL});
    public static readonly BitSet FOLLOW_sortingspec_in_synpred11_FiltersLanguageGrammar598 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_13_in_synpred12_FiltersLanguageGrammar643 = new BitSet(new ulong[]{0x0000006000010410UL});
    public static readonly BitSet FOLLOW_logicalexpr_in_synpred12_FiltersLanguageGrammar645 = new BitSet(new ulong[]{0x0000800000000000UL});
    public static readonly BitSet FOLLOW_columnsspec_in_synpred12_FiltersLanguageGrammar651 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_13_in_synpred13_FiltersLanguageGrammar696 = new BitSet(new ulong[]{0x0000006000010410UL});
    public static readonly BitSet FOLLOW_logicalexpr_in_synpred13_FiltersLanguageGrammar698 = new BitSet(new ulong[]{0x0008000000000000UL});
    public static readonly BitSet FOLLOW_sortingspec_in_synpred13_FiltersLanguageGrammar704 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_13_in_synpred14_FiltersLanguageGrammar749 = new BitSet(new ulong[]{0x0000006000010410UL});
    public static readonly BitSet FOLLOW_logicalexpr_in_synpred14_FiltersLanguageGrammar751 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parametersDate_in_synpred35_FiltersLanguageGrammar1698 = new BitSet(new ulong[]{0x03F0000000000000UL});
    public static readonly BitSet FOLLOW_internalop_in_synpred35_FiltersLanguageGrammar1700 = new BitSet(new ulong[]{0x0000000007F80050UL});
    public static readonly BitSet FOLLOW_valDate_in_synpred35_FiltersLanguageGrammar1702 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parametersUser_in_synpred41_FiltersLanguageGrammar1940 = new BitSet(new ulong[]{0x03F0000000000000UL});
    public static readonly BitSet FOLLOW_internalop_in_synpred41_FiltersLanguageGrammar1942 = new BitSet(new ulong[]{0x0000001800000010UL});
    public static readonly BitSet FOLLOW_valUser_in_synpred41_FiltersLanguageGrammar1944 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parametersDate_in_synpred49_FiltersLanguageGrammar2181 = new BitSet(new ulong[]{0x4000000000000000UL});
    public static readonly BitSet FOLLOW_multivalueinternalop_in_synpred49_FiltersLanguageGrammar2183 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_10_in_synpred49_FiltersLanguageGrammar2185 = new BitSet(new ulong[]{0x0000000007F80050UL});
    public static readonly BitSet FOLLOW_valDate_in_synpred49_FiltersLanguageGrammar2191 = new BitSet(new ulong[]{0x0000000000020800UL});
    public static readonly BitSet FOLLOW_17_in_synpred49_FiltersLanguageGrammar2194 = new BitSet(new ulong[]{0x0000000007F80050UL});
    public static readonly BitSet FOLLOW_valDate_in_synpred49_FiltersLanguageGrammar2200 = new BitSet(new ulong[]{0x0000000000020800UL});
    public static readonly BitSet FOLLOW_11_in_synpred49_FiltersLanguageGrammar2204 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parametersUser_in_synpred51_FiltersLanguageGrammar2236 = new BitSet(new ulong[]{0x4000000000000000UL});
    public static readonly BitSet FOLLOW_multivalueinternalop_in_synpred51_FiltersLanguageGrammar2238 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_10_in_synpred51_FiltersLanguageGrammar2240 = new BitSet(new ulong[]{0x0000001800000010UL});
    public static readonly BitSet FOLLOW_valUser_in_synpred51_FiltersLanguageGrammar2246 = new BitSet(new ulong[]{0x0000000000020800UL});
    public static readonly BitSet FOLLOW_17_in_synpred51_FiltersLanguageGrammar2249 = new BitSet(new ulong[]{0x0000001800000010UL});
    public static readonly BitSet FOLLOW_valUser_in_synpred51_FiltersLanguageGrammar2255 = new BitSet(new ulong[]{0x0000000000020800UL});
    public static readonly BitSet FOLLOW_11_in_synpred51_FiltersLanguageGrammar2259 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parametersDate_in_synpred61_FiltersLanguageGrammar2530 = new BitSet(new ulong[]{0x0000000000040000UL});
    public static readonly BitSet FOLLOW_18_in_synpred61_FiltersLanguageGrammar2532 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_10_in_synpred61_FiltersLanguageGrammar2534 = new BitSet(new ulong[]{0x0000000007F80050UL});
    public static readonly BitSet FOLLOW_valDate_in_synpred61_FiltersLanguageGrammar2540 = new BitSet(new ulong[]{0x0000000000020800UL});
    public static readonly BitSet FOLLOW_17_in_synpred61_FiltersLanguageGrammar2543 = new BitSet(new ulong[]{0x0000000007F80050UL});
    public static readonly BitSet FOLLOW_valDate_in_synpred61_FiltersLanguageGrammar2549 = new BitSet(new ulong[]{0x0000000000020800UL});
    public static readonly BitSet FOLLOW_11_in_synpred61_FiltersLanguageGrammar2553 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parametersUser_in_synpred63_FiltersLanguageGrammar2594 = new BitSet(new ulong[]{0x0000000000040000UL});
    public static readonly BitSet FOLLOW_18_in_synpred63_FiltersLanguageGrammar2596 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_10_in_synpred63_FiltersLanguageGrammar2598 = new BitSet(new ulong[]{0x0000001800000010UL});
    public static readonly BitSet FOLLOW_valUser_in_synpred63_FiltersLanguageGrammar2604 = new BitSet(new ulong[]{0x0000000000020800UL});
    public static readonly BitSet FOLLOW_17_in_synpred63_FiltersLanguageGrammar2607 = new BitSet(new ulong[]{0x0000001800000010UL});
    public static readonly BitSet FOLLOW_valUser_in_synpred63_FiltersLanguageGrammar2613 = new BitSet(new ulong[]{0x0000000000020800UL});
    public static readonly BitSet FOLLOW_11_in_synpred63_FiltersLanguageGrammar2617 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parametersTextifyOneToMany_in_synpred82_FiltersLanguageGrammar4014 = new BitSet(new ulong[]{0x03D0000000000000UL});
    public static readonly BitSet FOLLOW_internalopN2M_in_synpred82_FiltersLanguageGrammar4016 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_valStr_in_synpred82_FiltersLanguageGrammar4018 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parametersTextifyOneToMany_in_synpred83_FiltersLanguageGrammar4151 = new BitSet(new ulong[]{0x0020000000000000UL});
    public static readonly BitSet FOLLOW_internalopNotEqN2M_in_synpred83_FiltersLanguageGrammar4153 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_valStr_in_synpred83_FiltersLanguageGrammar4155 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parametersConstOneToMany_in_synpred84_FiltersLanguageGrammar4269 = new BitSet(new ulong[]{0x03D0000000000000UL});
    public static readonly BitSet FOLLOW_internalopN2M_in_synpred84_FiltersLanguageGrammar4271 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_valStr_in_synpred84_FiltersLanguageGrammar4273 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parametersConstOneToMany_in_synpred85_FiltersLanguageGrammar4424 = new BitSet(new ulong[]{0x0020000000000000UL});
    public static readonly BitSet FOLLOW_internalopNotEqN2M_in_synpred85_FiltersLanguageGrammar4426 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_valStr_in_synpred85_FiltersLanguageGrammar4428 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}