// $ANTLR 3.1.3 Mar 17, 2009 19:23:44 Output\\FiltersLanguageGrammar.g 2012-08-14 22:45:36

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162


using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;


public partial class FiltersLanguageGrammarLexer : Lexer {
    public const int T__66 = 66;
    public const int T__64 = 64;
    public const int T__29 = 29;
    public const int T__28 = 28;
    public const int T__65 = 65;
    public const int T__27 = 27;
    public const int T__62 = 62;
    public const int T__26 = 26;
    public const int T__63 = 63;
    public const int T__25 = 25;
    public const int T__24 = 24;
    public const int T__23 = 23;
    public const int T__22 = 22;
    public const int T__21 = 21;
    public const int T__20 = 20;
    public const int T__61 = 61;
    public const int EOF = -1;
    public const int T__60 = 60;
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
    public const int T__33 = 33;
    public const int WS = 8;
    public const int T__34 = 34;
    public const int T__35 = 35;
    public const int T__36 = 36;
    public const int T__37 = 37;
    public const int T__38 = 38;
    public const int T__39 = 39;
    public const int DATE = 6;
    public const int STRING = 4;

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


    // delegates
    // delegators

    public FiltersLanguageGrammarLexer() 
    {
		InitializeCyclicDFAs();
    }
    public FiltersLanguageGrammarLexer(ICharStream input)
		: this(input, null) {
    }
    public FiltersLanguageGrammarLexer(ICharStream input, RecognizerSharedState state)
		: base(input, state) {
		InitializeCyclicDFAs(); 

    }
    
    override public string GrammarFileName
    {
    	get { return "Output\\FiltersLanguageGrammar.g";} 
    }

    // $ANTLR start "T__9"
    public void mT__9() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__9;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Output\\FiltersLanguageGrammar.g:22:6: ( 'sql' )
            // Output\\FiltersLanguageGrammar.g:22:8: 'sql'
            {
            	Match("sql"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__9"

    // $ANTLR start "T__10"
    public void mT__10() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__10;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Output\\FiltersLanguageGrammar.g:23:7: ( '(' )
            // Output\\FiltersLanguageGrammar.g:23:9: '('
            {
            	Match('('); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__10"

    // $ANTLR start "T__11"
    public void mT__11() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__11;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Output\\FiltersLanguageGrammar.g:24:7: ( ')' )
            // Output\\FiltersLanguageGrammar.g:24:9: ')'
            {
            	Match(')'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__11"

    // $ANTLR start "T__12"
    public void mT__12() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__12;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Output\\FiltersLanguageGrammar.g:25:7: ( '__cntl' )
            // Output\\FiltersLanguageGrammar.g:25:9: '__cntl'
            {
            	Match("__cntl"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__12"

    // $ANTLR start "T__13"
    public void mT__13() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__13;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Output\\FiltersLanguageGrammar.g:26:7: ( '__cnt' )
            // Output\\FiltersLanguageGrammar.g:26:9: '__cnt'
            {
            	Match("__cnt"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__13"

    // $ANTLR start "T__14"
    public void mT__14() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__14;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Output\\FiltersLanguageGrammar.g:27:7: ( 'or' )
            // Output\\FiltersLanguageGrammar.g:27:9: 'or'
            {
            	Match("or"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__14"

    // $ANTLR start "T__15"
    public void mT__15() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__15;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Output\\FiltersLanguageGrammar.g:28:7: ( 'and' )
            // Output\\FiltersLanguageGrammar.g:28:9: 'and'
            {
            	Match("and"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__15"

    // $ANTLR start "T__16"
    public void mT__16() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__16;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Output\\FiltersLanguageGrammar.g:29:7: ( 'not' )
            // Output\\FiltersLanguageGrammar.g:29:9: 'not'
            {
            	Match("not"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__16"

    // $ANTLR start "T__17"
    public void mT__17() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__17;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Output\\FiltersLanguageGrammar.g:30:7: ( ',' )
            // Output\\FiltersLanguageGrammar.g:30:9: ','
            {
            	Match(','); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__17"

    // $ANTLR start "T__18"
    public void mT__18() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__18;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Output\\FiltersLanguageGrammar.g:31:7: ( 'wasever' )
            // Output\\FiltersLanguageGrammar.g:31:9: 'wasever'
            {
            	Match("wasever"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__18"

    // $ANTLR start "T__19"
    public void mT__19() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__19;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Output\\FiltersLanguageGrammar.g:32:7: ( '\"now\"' )
            // Output\\FiltersLanguageGrammar.g:32:9: '\"now\"'
            {
            	Match("\"now\""); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__19"

    // $ANTLR start "T__20"
    public void mT__20() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__20;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Output\\FiltersLanguageGrammar.g:33:7: ( 'now' )
            // Output\\FiltersLanguageGrammar.g:33:9: 'now'
            {
            	Match("now"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__20"

    // $ANTLR start "T__21"
    public void mT__21() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__21;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Output\\FiltersLanguageGrammar.g:34:7: ( 'today' )
            // Output\\FiltersLanguageGrammar.g:34:9: 'today'
            {
            	Match("today"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__21"

    // $ANTLR start "T__22"
    public void mT__22() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__22;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Output\\FiltersLanguageGrammar.g:35:7: ( '\"today\"' )
            // Output\\FiltersLanguageGrammar.g:35:9: '\"today\"'
            {
            	Match("\"today\""); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__22"

    // $ANTLR start "T__23"
    public void mT__23() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__23;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Output\\FiltersLanguageGrammar.g:36:7: ( 'yesterday' )
            // Output\\FiltersLanguageGrammar.g:36:9: 'yesterday'
            {
            	Match("yesterday"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__23"

    // $ANTLR start "T__24"
    public void mT__24() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__24;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Output\\FiltersLanguageGrammar.g:37:7: ( '\"yesterday\"' )
            // Output\\FiltersLanguageGrammar.g:37:9: '\"yesterday\"'
            {
            	Match("\"yesterday\""); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__24"

    // $ANTLR start "T__25"
    public void mT__25() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__25;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Output\\FiltersLanguageGrammar.g:38:7: ( 'tomorrow' )
            // Output\\FiltersLanguageGrammar.g:38:9: 'tomorrow'
            {
            	Match("tomorrow"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__25"

    // $ANTLR start "T__26"
    public void mT__26() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__26;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Output\\FiltersLanguageGrammar.g:39:7: ( '\"tomorrow\"' )
            // Output\\FiltersLanguageGrammar.g:39:9: '\"tomorrow\"'
            {
            	Match("\"tomorrow\""); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__26"

    // $ANTLR start "T__27"
    public void mT__27() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__27;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Output\\FiltersLanguageGrammar.g:40:7: ( 'lastweek' )
            // Output\\FiltersLanguageGrammar.g:40:9: 'lastweek'
            {
            	Match("lastweek"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__27"

    // $ANTLR start "T__28"
    public void mT__28() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__28;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Output\\FiltersLanguageGrammar.g:41:7: ( '\"lastweek\"' )
            // Output\\FiltersLanguageGrammar.g:41:9: '\"lastweek\"'
            {
            	Match("\"lastweek\""); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__28"

    // $ANTLR start "T__29"
    public void mT__29() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__29;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Output\\FiltersLanguageGrammar.g:42:7: ( 'lastmonth' )
            // Output\\FiltersLanguageGrammar.g:42:9: 'lastmonth'
            {
            	Match("lastmonth"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__29"

    // $ANTLR start "T__30"
    public void mT__30() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__30;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Output\\FiltersLanguageGrammar.g:43:7: ( '\"lastmonth\"' )
            // Output\\FiltersLanguageGrammar.g:43:9: '\"lastmonth\"'
            {
            	Match("\"lastmonth\""); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__30"

    // $ANTLR start "T__31"
    public void mT__31() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__31;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Output\\FiltersLanguageGrammar.g:44:7: ( 'thisweek' )
            // Output\\FiltersLanguageGrammar.g:44:9: 'thisweek'
            {
            	Match("thisweek"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__31"

    // $ANTLR start "T__32"
    public void mT__32() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__32;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Output\\FiltersLanguageGrammar.g:45:7: ( '\"thisweek\"' )
            // Output\\FiltersLanguageGrammar.g:45:9: '\"thisweek\"'
            {
            	Match("\"thisweek\""); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__32"

    // $ANTLR start "T__33"
    public void mT__33() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__33;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Output\\FiltersLanguageGrammar.g:46:7: ( 'thismonth' )
            // Output\\FiltersLanguageGrammar.g:46:9: 'thismonth'
            {
            	Match("thismonth"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__33"

    // $ANTLR start "T__34"
    public void mT__34() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__34;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Output\\FiltersLanguageGrammar.g:47:7: ( '\"thismonth\"' )
            // Output\\FiltersLanguageGrammar.g:47:9: '\"thismonth\"'
            {
            	Match("\"thismonth\""); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__34"

    // $ANTLR start "T__35"
    public void mT__35() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__35;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Output\\FiltersLanguageGrammar.g:48:7: ( '\"me\"' )
            // Output\\FiltersLanguageGrammar.g:48:9: '\"me\"'
            {
            	Match("\"me\""); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__35"

    // $ANTLR start "T__36"
    public void mT__36() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__36;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Output\\FiltersLanguageGrammar.g:49:7: ( 'me' )
            // Output\\FiltersLanguageGrammar.g:49:9: 'me'
            {
            	Match("me"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__36"

    // $ANTLR start "T__37"
    public void mT__37() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__37;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Output\\FiltersLanguageGrammar.g:50:7: ( 'user.' )
            // Output\\FiltersLanguageGrammar.g:50:9: 'user.'
            {
            	Match("user."); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__37"

    // $ANTLR start "T__38"
    public void mT__38() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__38;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Output\\FiltersLanguageGrammar.g:51:7: ( 'u.' )
            // Output\\FiltersLanguageGrammar.g:51:9: 'u.'
            {
            	Match("u."); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__38"

    // $ANTLR start "T__39"
    public void mT__39() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__39;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Output\\FiltersLanguageGrammar.g:52:7: ( 'gg' )
            // Output\\FiltersLanguageGrammar.g:52:9: 'gg'
            {
            	Match("gg"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__39"

    // $ANTLR start "T__40"
    public void mT__40() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__40;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Output\\FiltersLanguageGrammar.g:53:7: ( 'super_power' )
            // Output\\FiltersLanguageGrammar.g:53:9: 'super_power'
            {
            	Match("super_power"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__40"

    // $ANTLR start "T__41"
    public void mT__41() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__41;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Output\\FiltersLanguageGrammar.g:54:7: ( 'name' )
            // Output\\FiltersLanguageGrammar.g:54:9: 'name'
            {
            	Match("name"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__41"

    // $ANTLR start "T__42"
    public void mT__42() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__42;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Output\\FiltersLanguageGrammar.g:55:7: ( 'surname' )
            // Output\\FiltersLanguageGrammar.g:55:9: 'surname'
            {
            	Match("surname"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__42"

    // $ANTLR start "T__43"
    public void mT__43() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__43;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Output\\FiltersLanguageGrammar.g:56:7: ( 'birthdate' )
            // Output\\FiltersLanguageGrammar.g:56:9: 'birthdate'
            {
            	Match("birthdate"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__43"

    // $ANTLR start "T__44"
    public void mT__44() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__44;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Output\\FiltersLanguageGrammar.g:57:7: ( 'country' )
            // Output\\FiltersLanguageGrammar.g:57:9: 'country'
            {
            	Match("country"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__44"

    // $ANTLR start "T__45"
    public void mT__45() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__45;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Output\\FiltersLanguageGrammar.g:58:7: ( 'id' )
            // Output\\FiltersLanguageGrammar.g:58:9: 'id'
            {
            	Match("id"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__45"

    // $ANTLR start "T__46"
    public void mT__46() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__46;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Output\\FiltersLanguageGrammar.g:59:7: ( 'email' )
            // Output\\FiltersLanguageGrammar.g:59:9: 'email'
            {
            	Match("email"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__46"

    // $ANTLR start "T__47"
    public void mT__47() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__47;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Output\\FiltersLanguageGrammar.g:60:7: ( 'user_columns' )
            // Output\\FiltersLanguageGrammar.g:60:9: 'user_columns'
            {
            	Match("user_columns"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__47"

    // $ANTLR start "T__48"
    public void mT__48() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__48;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Output\\FiltersLanguageGrammar.g:61:7: ( ':' )
            // Output\\FiltersLanguageGrammar.g:61:9: ':'
            {
            	Match(':'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__48"

    // $ANTLR start "T__49"
    public void mT__49() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__49;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Output\\FiltersLanguageGrammar.g:62:7: ( '+' )
            // Output\\FiltersLanguageGrammar.g:62:9: '+'
            {
            	Match('+'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__49"

    // $ANTLR start "T__50"
    public void mT__50() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__50;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Output\\FiltersLanguageGrammar.g:63:7: ( '-' )
            // Output\\FiltersLanguageGrammar.g:63:9: '-'
            {
            	Match('-'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__50"

    // $ANTLR start "T__51"
    public void mT__51() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__51;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Output\\FiltersLanguageGrammar.g:64:7: ( 'user_sorted_by' )
            // Output\\FiltersLanguageGrammar.g:64:9: 'user_sorted_by'
            {
            	Match("user_sorted_by"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__51"

    // $ANTLR start "T__52"
    public void mT__52() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__52;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Output\\FiltersLanguageGrammar.g:65:7: ( '=' )
            // Output\\FiltersLanguageGrammar.g:65:9: '='
            {
            	Match('='); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__52"

    // $ANTLR start "T__53"
    public void mT__53() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__53;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Output\\FiltersLanguageGrammar.g:66:7: ( '!=' )
            // Output\\FiltersLanguageGrammar.g:66:9: '!='
            {
            	Match("!="); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__53"

    // $ANTLR start "T__54"
    public void mT__54() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__54;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Output\\FiltersLanguageGrammar.g:67:7: ( '>' )
            // Output\\FiltersLanguageGrammar.g:67:9: '>'
            {
            	Match('>'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__54"

    // $ANTLR start "T__55"
    public void mT__55() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__55;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Output\\FiltersLanguageGrammar.g:68:7: ( '>=' )
            // Output\\FiltersLanguageGrammar.g:68:9: '>='
            {
            	Match(">="); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__55"

    // $ANTLR start "T__56"
    public void mT__56() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__56;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Output\\FiltersLanguageGrammar.g:69:7: ( '<' )
            // Output\\FiltersLanguageGrammar.g:69:9: '<'
            {
            	Match('<'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__56"

    // $ANTLR start "T__57"
    public void mT__57() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__57;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Output\\FiltersLanguageGrammar.g:70:7: ( '<=' )
            // Output\\FiltersLanguageGrammar.g:70:9: '<='
            {
            	Match("<="); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__57"

    // $ANTLR start "T__58"
    public void mT__58() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__58;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Output\\FiltersLanguageGrammar.g:71:7: ( 'contains' )
            // Output\\FiltersLanguageGrammar.g:71:9: 'contains'
            {
            	Match("contains"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__58"

    // $ANTLR start "T__59"
    public void mT__59() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__59;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Output\\FiltersLanguageGrammar.g:72:7: ( 'starts_with' )
            // Output\\FiltersLanguageGrammar.g:72:9: 'starts_with'
            {
            	Match("starts_with"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__59"

    // $ANTLR start "T__60"
    public void mT__60() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__60;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Output\\FiltersLanguageGrammar.g:73:7: ( 'ends_with' )
            // Output\\FiltersLanguageGrammar.g:73:9: 'ends_with'
            {
            	Match("ends_with"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__60"

    // $ANTLR start "T__61"
    public void mT__61() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__61;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Output\\FiltersLanguageGrammar.g:74:7: ( 'does_not_contains' )
            // Output\\FiltersLanguageGrammar.g:74:9: 'does_not_contains'
            {
            	Match("does_not_contains"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__61"

    // $ANTLR start "T__62"
    public void mT__62() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__62;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Output\\FiltersLanguageGrammar.g:75:7: ( 'in' )
            // Output\\FiltersLanguageGrammar.g:75:9: 'in'
            {
            	Match("in"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__62"

    // $ANTLR start "T__63"
    public void mT__63() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__63;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Output\\FiltersLanguageGrammar.g:76:7: ( '\"true\"' )
            // Output\\FiltersLanguageGrammar.g:76:9: '\"true\"'
            {
            	Match("\"true\""); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__63"

    // $ANTLR start "T__64"
    public void mT__64() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__64;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Output\\FiltersLanguageGrammar.g:77:7: ( '\"false\"' )
            // Output\\FiltersLanguageGrammar.g:77:9: '\"false\"'
            {
            	Match("\"false\""); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__64"

    // $ANTLR start "T__65"
    public void mT__65() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__65;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Output\\FiltersLanguageGrammar.g:78:7: ( 'true' )
            // Output\\FiltersLanguageGrammar.g:78:9: 'true'
            {
            	Match("true"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__65"

    // $ANTLR start "T__66"
    public void mT__66() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__66;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Output\\FiltersLanguageGrammar.g:79:7: ( 'false' )
            // Output\\FiltersLanguageGrammar.g:79:9: 'false'
            {
            	Match("false"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__66"

    // $ANTLR start "INT"
    public void mINT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = INT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Output\\FiltersLanguageGrammar.g:1777:7: ( ( '0' .. '9' )+ )
            // Output\\FiltersLanguageGrammar.g:1777:9: ( '0' .. '9' )+
            {
            	// Output\\FiltersLanguageGrammar.g:1777:9: ( '0' .. '9' )+
            	int cnt1 = 0;
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);

            	    if ( ((LA1_0 >= '0' && LA1_0 <= '9')) )
            	    {
            	        alt1 = 1;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // Output\\FiltersLanguageGrammar.g:1777:10: '0' .. '9'
            			    {
            			    	MatchRange('0','9'); 

            			    }
            			    break;

            			default:
            			    if ( cnt1 >= 1 ) goto loop1;
            		            EarlyExitException eee1 =
            		                new EarlyExitException(1, input);
            		            throw eee1;
            	    }
            	    cnt1++;
            	} while (true);

            	loop1:
            		;	// Stops C# compiler whining that label 'loop1' has no statements


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "INT"

    // $ANTLR start "DATE"
    public void mDATE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = DATE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Output\\FiltersLanguageGrammar.g:1780:7: ( '0' .. '9' '0' .. '9' '0' .. '9' '0' .. '9' '-' '0' .. '9' '0' .. '9' '-' '0' .. '9' '0' .. '9' )
            // Output\\FiltersLanguageGrammar.g:1780:9: '0' .. '9' '0' .. '9' '0' .. '9' '0' .. '9' '-' '0' .. '9' '0' .. '9' '-' '0' .. '9' '0' .. '9'
            {
            	MatchRange('0','9'); 
            	MatchRange('0','9'); 
            	MatchRange('0','9'); 
            	MatchRange('0','9'); 
            	Match('-'); 
            	MatchRange('0','9'); 
            	MatchRange('0','9'); 
            	Match('-'); 
            	MatchRange('0','9'); 
            	MatchRange('0','9'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "DATE"

    // $ANTLR start "STRING"
    public void mSTRING() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = STRING;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Output\\FiltersLanguageGrammar.g:1783:9: ( STRCHAR (~ ( STRCHAR ) )* STRCHAR )
            // Output\\FiltersLanguageGrammar.g:1783:11: STRCHAR (~ ( STRCHAR ) )* STRCHAR
            {
            	mSTRCHAR(); 
            	// Output\\FiltersLanguageGrammar.g:1783:19: (~ ( STRCHAR ) )*
            	do 
            	{
            	    int alt2 = 2;
            	    int LA2_0 = input.LA(1);

            	    if ( ((LA2_0 >= '\u0000' && LA2_0 <= '!') || (LA2_0 >= '#' && LA2_0 <= '\uFFFF')) )
            	    {
            	        alt2 = 1;
            	    }


            	    switch (alt2) 
            		{
            			case 1 :
            			    // Output\\FiltersLanguageGrammar.g:1783:19: ~ ( STRCHAR )
            			    {
            			    	if ( (input.LA(1) >= '\u0000' && input.LA(1) <= '!') || (input.LA(1) >= '#' && input.LA(1) <= '\uFFFF') ) 
            			    	{
            			    	    input.Consume();

            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    Recover(mse);
            			    	    throw mse;}


            			    }
            			    break;

            			default:
            			    goto loop2;
            	    }
            	} while (true);

            	loop2:
            		;	// Stops C# compiler whining that label 'loop2' has no statements

            	mSTRCHAR(); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "STRING"

    // $ANTLR start "STRCHAR"
    public void mSTRCHAR() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = STRCHAR;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Output\\FiltersLanguageGrammar.g:1786:10: ( '\\\"' )
            // Output\\FiltersLanguageGrammar.g:1786:12: '\\\"'
            {
            	Match('\"'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "STRCHAR"

    // $ANTLR start "WS"
    public void mWS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = WS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // Output\\FiltersLanguageGrammar.g:1789:6: ( ( ' ' | '\\t' | '\\r' | '\\n' )+ )
            // Output\\FiltersLanguageGrammar.g:1789:10: ( ' ' | '\\t' | '\\r' | '\\n' )+
            {
            	// Output\\FiltersLanguageGrammar.g:1789:10: ( ' ' | '\\t' | '\\r' | '\\n' )+
            	int cnt3 = 0;
            	do 
            	{
            	    int alt3 = 2;
            	    int LA3_0 = input.LA(1);

            	    if ( ((LA3_0 >= '\t' && LA3_0 <= '\n') || LA3_0 == '\r' || LA3_0 == ' ') )
            	    {
            	        alt3 = 1;
            	    }


            	    switch (alt3) 
            		{
            			case 1 :
            			    // Output\\FiltersLanguageGrammar.g:
            			    {
            			    	if ( (input.LA(1) >= '\t' && input.LA(1) <= '\n') || input.LA(1) == '\r' || input.LA(1) == ' ' ) 
            			    	{
            			    	    input.Consume();

            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    Recover(mse);
            			    	    throw mse;}


            			    }
            			    break;

            			default:
            			    if ( cnt3 >= 1 ) goto loop3;
            		            EarlyExitException eee3 =
            		                new EarlyExitException(3, input);
            		            throw eee3;
            	    }
            	    cnt3++;
            	} while (true);

            	loop3:
            		;	// Stops C# compiler whining that label 'loop3' has no statements


            						_channel=HIDDEN;
            					

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "WS"

    override public void mTokens() // throws RecognitionException 
    {
        // Output\\FiltersLanguageGrammar.g:1:8: ( T__9 | T__10 | T__11 | T__12 | T__13 | T__14 | T__15 | T__16 | T__17 | T__18 | T__19 | T__20 | T__21 | T__22 | T__23 | T__24 | T__25 | T__26 | T__27 | T__28 | T__29 | T__30 | T__31 | T__32 | T__33 | T__34 | T__35 | T__36 | T__37 | T__38 | T__39 | T__40 | T__41 | T__42 | T__43 | T__44 | T__45 | T__46 | T__47 | T__48 | T__49 | T__50 | T__51 | T__52 | T__53 | T__54 | T__55 | T__56 | T__57 | T__58 | T__59 | T__60 | T__61 | T__62 | T__63 | T__64 | T__65 | T__66 | INT | DATE | STRING | STRCHAR | WS )
        int alt4 = 63;
        alt4 = dfa4.Predict(input);
        switch (alt4) 
        {
            case 1 :
                // Output\\FiltersLanguageGrammar.g:1:10: T__9
                {
                	mT__9(); 

                }
                break;
            case 2 :
                // Output\\FiltersLanguageGrammar.g:1:15: T__10
                {
                	mT__10(); 

                }
                break;
            case 3 :
                // Output\\FiltersLanguageGrammar.g:1:21: T__11
                {
                	mT__11(); 

                }
                break;
            case 4 :
                // Output\\FiltersLanguageGrammar.g:1:27: T__12
                {
                	mT__12(); 

                }
                break;
            case 5 :
                // Output\\FiltersLanguageGrammar.g:1:33: T__13
                {
                	mT__13(); 

                }
                break;
            case 6 :
                // Output\\FiltersLanguageGrammar.g:1:39: T__14
                {
                	mT__14(); 

                }
                break;
            case 7 :
                // Output\\FiltersLanguageGrammar.g:1:45: T__15
                {
                	mT__15(); 

                }
                break;
            case 8 :
                // Output\\FiltersLanguageGrammar.g:1:51: T__16
                {
                	mT__16(); 

                }
                break;
            case 9 :
                // Output\\FiltersLanguageGrammar.g:1:57: T__17
                {
                	mT__17(); 

                }
                break;
            case 10 :
                // Output\\FiltersLanguageGrammar.g:1:63: T__18
                {
                	mT__18(); 

                }
                break;
            case 11 :
                // Output\\FiltersLanguageGrammar.g:1:69: T__19
                {
                	mT__19(); 

                }
                break;
            case 12 :
                // Output\\FiltersLanguageGrammar.g:1:75: T__20
                {
                	mT__20(); 

                }
                break;
            case 13 :
                // Output\\FiltersLanguageGrammar.g:1:81: T__21
                {
                	mT__21(); 

                }
                break;
            case 14 :
                // Output\\FiltersLanguageGrammar.g:1:87: T__22
                {
                	mT__22(); 

                }
                break;
            case 15 :
                // Output\\FiltersLanguageGrammar.g:1:93: T__23
                {
                	mT__23(); 

                }
                break;
            case 16 :
                // Output\\FiltersLanguageGrammar.g:1:99: T__24
                {
                	mT__24(); 

                }
                break;
            case 17 :
                // Output\\FiltersLanguageGrammar.g:1:105: T__25
                {
                	mT__25(); 

                }
                break;
            case 18 :
                // Output\\FiltersLanguageGrammar.g:1:111: T__26
                {
                	mT__26(); 

                }
                break;
            case 19 :
                // Output\\FiltersLanguageGrammar.g:1:117: T__27
                {
                	mT__27(); 

                }
                break;
            case 20 :
                // Output\\FiltersLanguageGrammar.g:1:123: T__28
                {
                	mT__28(); 

                }
                break;
            case 21 :
                // Output\\FiltersLanguageGrammar.g:1:129: T__29
                {
                	mT__29(); 

                }
                break;
            case 22 :
                // Output\\FiltersLanguageGrammar.g:1:135: T__30
                {
                	mT__30(); 

                }
                break;
            case 23 :
                // Output\\FiltersLanguageGrammar.g:1:141: T__31
                {
                	mT__31(); 

                }
                break;
            case 24 :
                // Output\\FiltersLanguageGrammar.g:1:147: T__32
                {
                	mT__32(); 

                }
                break;
            case 25 :
                // Output\\FiltersLanguageGrammar.g:1:153: T__33
                {
                	mT__33(); 

                }
                break;
            case 26 :
                // Output\\FiltersLanguageGrammar.g:1:159: T__34
                {
                	mT__34(); 

                }
                break;
            case 27 :
                // Output\\FiltersLanguageGrammar.g:1:165: T__35
                {
                	mT__35(); 

                }
                break;
            case 28 :
                // Output\\FiltersLanguageGrammar.g:1:171: T__36
                {
                	mT__36(); 

                }
                break;
            case 29 :
                // Output\\FiltersLanguageGrammar.g:1:177: T__37
                {
                	mT__37(); 

                }
                break;
            case 30 :
                // Output\\FiltersLanguageGrammar.g:1:183: T__38
                {
                	mT__38(); 

                }
                break;
            case 31 :
                // Output\\FiltersLanguageGrammar.g:1:189: T__39
                {
                	mT__39(); 

                }
                break;
            case 32 :
                // Output\\FiltersLanguageGrammar.g:1:195: T__40
                {
                	mT__40(); 

                }
                break;
            case 33 :
                // Output\\FiltersLanguageGrammar.g:1:201: T__41
                {
                	mT__41(); 

                }
                break;
            case 34 :
                // Output\\FiltersLanguageGrammar.g:1:207: T__42
                {
                	mT__42(); 

                }
                break;
            case 35 :
                // Output\\FiltersLanguageGrammar.g:1:213: T__43
                {
                	mT__43(); 

                }
                break;
            case 36 :
                // Output\\FiltersLanguageGrammar.g:1:219: T__44
                {
                	mT__44(); 

                }
                break;
            case 37 :
                // Output\\FiltersLanguageGrammar.g:1:225: T__45
                {
                	mT__45(); 

                }
                break;
            case 38 :
                // Output\\FiltersLanguageGrammar.g:1:231: T__46
                {
                	mT__46(); 

                }
                break;
            case 39 :
                // Output\\FiltersLanguageGrammar.g:1:237: T__47
                {
                	mT__47(); 

                }
                break;
            case 40 :
                // Output\\FiltersLanguageGrammar.g:1:243: T__48
                {
                	mT__48(); 

                }
                break;
            case 41 :
                // Output\\FiltersLanguageGrammar.g:1:249: T__49
                {
                	mT__49(); 

                }
                break;
            case 42 :
                // Output\\FiltersLanguageGrammar.g:1:255: T__50
                {
                	mT__50(); 

                }
                break;
            case 43 :
                // Output\\FiltersLanguageGrammar.g:1:261: T__51
                {
                	mT__51(); 

                }
                break;
            case 44 :
                // Output\\FiltersLanguageGrammar.g:1:267: T__52
                {
                	mT__52(); 

                }
                break;
            case 45 :
                // Output\\FiltersLanguageGrammar.g:1:273: T__53
                {
                	mT__53(); 

                }
                break;
            case 46 :
                // Output\\FiltersLanguageGrammar.g:1:279: T__54
                {
                	mT__54(); 

                }
                break;
            case 47 :
                // Output\\FiltersLanguageGrammar.g:1:285: T__55
                {
                	mT__55(); 

                }
                break;
            case 48 :
                // Output\\FiltersLanguageGrammar.g:1:291: T__56
                {
                	mT__56(); 

                }
                break;
            case 49 :
                // Output\\FiltersLanguageGrammar.g:1:297: T__57
                {
                	mT__57(); 

                }
                break;
            case 50 :
                // Output\\FiltersLanguageGrammar.g:1:303: T__58
                {
                	mT__58(); 

                }
                break;
            case 51 :
                // Output\\FiltersLanguageGrammar.g:1:309: T__59
                {
                	mT__59(); 

                }
                break;
            case 52 :
                // Output\\FiltersLanguageGrammar.g:1:315: T__60
                {
                	mT__60(); 

                }
                break;
            case 53 :
                // Output\\FiltersLanguageGrammar.g:1:321: T__61
                {
                	mT__61(); 

                }
                break;
            case 54 :
                // Output\\FiltersLanguageGrammar.g:1:327: T__62
                {
                	mT__62(); 

                }
                break;
            case 55 :
                // Output\\FiltersLanguageGrammar.g:1:333: T__63
                {
                	mT__63(); 

                }
                break;
            case 56 :
                // Output\\FiltersLanguageGrammar.g:1:339: T__64
                {
                	mT__64(); 

                }
                break;
            case 57 :
                // Output\\FiltersLanguageGrammar.g:1:345: T__65
                {
                	mT__65(); 

                }
                break;
            case 58 :
                // Output\\FiltersLanguageGrammar.g:1:351: T__66
                {
                	mT__66(); 

                }
                break;
            case 59 :
                // Output\\FiltersLanguageGrammar.g:1:357: INT
                {
                	mINT(); 

                }
                break;
            case 60 :
                // Output\\FiltersLanguageGrammar.g:1:361: DATE
                {
                	mDATE(); 

                }
                break;
            case 61 :
                // Output\\FiltersLanguageGrammar.g:1:366: STRING
                {
                	mSTRING(); 

                }
                break;
            case 62 :
                // Output\\FiltersLanguageGrammar.g:1:373: STRCHAR
                {
                	mSTRCHAR(); 

                }
                break;
            case 63 :
                // Output\\FiltersLanguageGrammar.g:1:381: WS
                {
                	mWS(); 

                }
                break;

        }

    }


    protected DFA4 dfa4;
	private void InitializeCyclicDFAs()
	{
	    this.dfa4 = new DFA4(this);
	    this.dfa4.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA4_SpecialStateTransition);
	}

    const string DFA4_eotS =
        "\x0a\uffff\x01\x2c\x0f\uffff\x01\x3a\x01\x3c\x02\uffff\x01\x3e"+
        "\x1e\uffff\x01\x3e\x15\uffff\x01\x3e\x0d\uffff\x01\x3e\x01\x74\x44"+
        "\uffff";
    const string DFA4_eofS =
        "\u00a7\uffff";
    const string DFA4_minS =
        "\x01\x09\x01\x71\x02\uffff\x01\x5f\x02\uffff\x01\x61\x02\uffff"+
        "\x01\x00\x01\x68\x01\uffff\x01\x61\x01\uffff\x01\x2e\x02\uffff\x01"+
        "\x6f\x01\x64\x01\x6d\x05\uffff\x02\x3d\x02\uffff\x01\x30\x02\uffff"+
        "\x01\x70\x01\uffff\x01\x63\x01\x74\x01\uffff\x06\x00\x02\uffff\x01"+
        "\x64\x01\x69\x01\uffff\x01\x73\x01\x65\x01\uffff\x01\x6e\x08\uffff"+
        "\x01\x30\x03\uffff\x01\x6e\x02\uffff\x08\x00\x02\uffff\x01\x73\x01"+
        "\x74\x01\x72\x02\uffff\x01\x30\x01\x74\x07\x00\x01\uffff\x01\x00"+
        "\x02\x6d\x01\x2e\x01\x2d\x01\x6c\x01\uffff\x06\x00\x01\uffff\x01"+
        "\x00\x05\uffff\x01\x63\x04\uffff\x04\x00\x01\uffff\x04\x00\x03\uffff"+
        "\x03\x00\x01\uffff\x03\x00\x02\uffff\x06\x00\x01\uffff\x06\x00\x02"+
        "\uffff\x02\x00\x01\uffff\x01\x00\x09\uffff";
    const string DFA4_maxS =
        "\x01\x79\x01\x75\x02\uffff\x01\x5f\x02\uffff\x01\x6f\x02\uffff"+
        "\x01\uffff\x01\x72\x01\uffff\x01\x61\x01\uffff\x01\x73\x02\uffff"+
        "\x01\x6f\x02\x6e\x05\uffff\x02\x3d\x02\uffff\x01\x39\x02\uffff\x01"+
        "\x72\x01\uffff\x01\x63\x01\x77\x01\uffff\x06\uffff\x02\uffff\x01"+
        "\x6d\x01\x69\x01\uffff\x01\x73\x01\x65\x01\uffff\x01\x75\x08\uffff"+
        "\x01\x39\x03\uffff\x01\x6e\x02\uffff\x08\uffff\x02\uffff\x01\x73"+
        "\x01\x74\x01\x72\x02\uffff\x01\x39\x01\x74\x07\uffff\x01\uffff\x01"+
        "\uffff\x02\x77\x01\x5f\x01\x2d\x01\x6c\x01\uffff\x06\uffff\x01\uffff"+
        "\x01\uffff\x05\uffff\x01\x73\x04\uffff\x04\uffff\x01\uffff\x04\uffff"+
        "\x03\uffff\x03\uffff\x01\uffff\x03\uffff\x02\uffff\x06\uffff\x01"+
        "\uffff\x06\uffff\x02\uffff\x02\uffff\x01\uffff\x01\uffff\x09\uffff";
    const string DFA4_acceptS =
        "\x02\uffff\x01\x02\x01\x03\x01\uffff\x01\x06\x01\x07\x01\uffff"+
        "\x01\x09\x01\x0a\x02\uffff\x01\x0f\x01\uffff\x01\x1c\x01\uffff\x01"+
        "\x1f\x01\x23\x03\uffff\x01\x28\x01\x29\x01\x2a\x01\x2c\x01\x2d\x02"+
        "\uffff\x01\x35\x01\x3a\x01\uffff\x01\x3f\x01\x01\x01\uffff\x01\x33"+
        "\x02\uffff\x01\x21\x06\uffff\x01\x3e\x01\x3d\x02\uffff\x01\x39\x02"+
        "\uffff\x01\x1e\x01\uffff\x01\x25\x01\x36\x01\x26\x01\x34\x01\x2f"+
        "\x01\x2e\x01\x31\x01\x30\x01\uffff\x01\x3b\x01\x20\x01\x22\x01\uffff"+
        "\x01\x08\x01\x0c\x08\uffff\x01\x0d\x01\x11\x03\uffff\x01\x24\x01"+
        "\x32\x09\uffff\x01\x1b\x06\uffff\x01\x0b\x06\uffff\x01\x1b\x01\uffff"+
        "\x01\x17\x01\x19\x01\x13\x01\x15\x01\x1d\x01\uffff\x01\x3c\x01\x04"+
        "\x01\x05\x01\x0b\x04\uffff\x01\x37\x04\uffff\x01\x27\x01\x2b\x01"+
        "\x0e\x03\uffff\x01\x37\x03\uffff\x01\x38\x01\x0e\x06\uffff\x01\x38"+
        "\x06\uffff\x01\x12\x01\x18\x02\uffff\x01\x14\x01\uffff\x01\x12\x01"+
        "\x18\x01\x1a\x01\x10\x01\x14\x01\x16\x01\x1a\x01\x10\x01\x16";
    const string DFA4_specialS =
        "\x0a\uffff\x01\x00\x1b\uffff\x01\x14\x01\x03\x01\x0d\x01\x2f\x01"+
        "\x24\x01\x38\x18\uffff\x01\x13\x01\x0e\x01\x01\x01\x2e\x01\x0c\x01"+
        "\x28\x01\x23\x01\x39\x09\uffff\x01\x12\x01\x10\x01\x1f\x01\x02\x01"+
        "\x2d\x01\x07\x01\x2b\x01\uffff\x01\x31\x06\uffff\x01\x11\x01\x1d"+
        "\x01\x0b\x01\x37\x01\x08\x01\x2c\x01\uffff\x01\x32\x0a\uffff\x01"+
        "\x0f\x01\x1e\x01\x36\x01\x29\x01\uffff\x01\x09\x01\x19\x01\x16\x01"+
        "\x30\x03\uffff\x01\x21\x01\x35\x01\x2a\x01\uffff\x01\x0a\x01\x1a"+
        "\x01\x15\x02\uffff\x01\x22\x01\x34\x01\x26\x01\x04\x01\x1b\x01\x18"+
        "\x01\uffff\x01\x20\x01\x33\x01\x25\x01\x05\x01\x1c\x01\x17\x02\uffff"+
        "\x01\x27\x01\x06\x01\uffff\x01\x3a\x09\uffff}>";
    static readonly string[] DFA4_transitionS = {
            "\x02\x1f\x02\uffff\x01\x1f\x12\uffff\x01\x1f\x01\x19\x01\x0a"+
            "\x05\uffff\x01\x02\x01\x03\x01\uffff\x01\x16\x01\x08\x01\x17"+
            "\x02\uffff\x0a\x1e\x01\x15\x01\uffff\x01\x1b\x01\x18\x01\x1a"+
            "\x20\uffff\x01\x04\x01\uffff\x01\x06\x01\x11\x01\x12\x01\x1c"+
            "\x01\x14\x01\x1d\x01\x10\x01\uffff\x01\x13\x02\uffff\x01\x0d"+
            "\x01\x0e\x01\x07\x01\x05\x03\uffff\x01\x01\x01\x0b\x01\x0f\x01"+
            "\uffff\x01\x09\x01\uffff\x01\x0c",
            "\x01\x20\x02\uffff\x01\x22\x01\x21",
            "",
            "",
            "\x01\x23",
            "",
            "",
            "\x01\x25\x0d\uffff\x01\x24",
            "",
            "",
            "\x66\x2d\x01\x2b\x05\x2d\x01\x29\x01\x2a\x01\x26\x05\x2d\x01"+
            "\x27\x04\x2d\x01\x28\uff86\x2d",
            "\x01\x2f\x06\uffff\x01\x2e\x02\uffff\x01\x30",
            "",
            "\x01\x31",
            "",
            "\x01\x33\x44\uffff\x01\x32",
            "",
            "",
            "\x01\x34",
            "\x01\x35\x09\uffff\x01\x36",
            "\x01\x37\x01\x38",
            "",
            "",
            "",
            "",
            "",
            "\x01\x39",
            "\x01\x3b",
            "",
            "",
            "\x0a\x3d",
            "",
            "",
            "\x01\x3f\x01\uffff\x01\x40",
            "",
            "\x01\x41",
            "\x01\x42\x02\uffff\x01\x43",
            "",
            "\x6f\x2d\x01\x44\uff90\x2d",
            "\x68\x2d\x01\x46\x06\x2d\x01\x45\x02\x2d\x01\x47\uff8d\x2d",
            "\x65\x2d\x01\x48\uff9a\x2d",
            "\x61\x2d\x01\x49\uff9e\x2d",
            "\x65\x2d\x01\x4a\uff9a\x2d",
            "\x61\x2d\x01\x4b\uff9e\x2d",
            "",
            "",
            "\x01\x4c\x08\uffff\x01\x4d",
            "\x01\x4e",
            "",
            "\x01\x4f",
            "\x01\x50",
            "",
            "\x01\x52\x06\uffff\x01\x51",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x0a\x53",
            "",
            "",
            "",
            "\x01\x54",
            "",
            "",
            "\x77\x2d\x01\x55\uff88\x2d",
            "\x64\x2d\x01\x56\x08\x2d\x01\x57\uff92\x2d",
            "\x69\x2d\x01\x58\uff96\x2d",
            "\x75\x2d\x01\x59\uff8a\x2d",
            "\x73\x2d\x01\x5a\uff8c\x2d",
            "\x73\x2d\x01\x5b\uff8c\x2d",
            "\x22\x2d\x01\x5c\uffdd\x2d",
            "\x6c\x2d\x01\x5d\uff93\x2d",
            "",
            "",
            "\x01\x5e",
            "\x01\x5f",
            "\x01\x60",
            "",
            "",
            "\x0a\x61",
            "\x01\x62",
            "\x22\x2d\x01\x63\uffdd\x2d",
            "\x61\x2d\x01\x64\uff9e\x2d",
            "\x6f\x2d\x01\x65\uff90\x2d",
            "\x73\x2d\x01\x66\uff8c\x2d",
            "\x65\x2d\x01\x67\uff9a\x2d",
            "\x74\x2d\x01\x68\uff8b\x2d",
            "\x74\x2d\x01\x69\uff8b\x2d",
            "",
            "\x73\x2d\x01\x6b\uff8c\x2d",
            "\x01\x6d\x09\uffff\x01\x6c",
            "\x01\x6f\x09\uffff\x01\x6e",
            "\x01\x70\x30\uffff\x01\x71",
            "\x01\x72",
            "\x01\x73",
            "",
            "\x79\x2d\x01\x76\uff86\x2d",
            "\x72\x2d\x01\x77\uff8d\x2d",
            "\x6d\x2d\x01\x79\x09\x2d\x01\x78\uff88\x2d",
            "\x22\x2d\x01\x7a\uffdd\x2d",
            "\x65\x2d\x01\x7b\uff9a\x2d",
            "\x6d\x2d\x01\x7d\x09\x2d\x01\x7c\uff88\x2d",
            "",
            "\x65\x2d\x01\x7e\uff9a\x2d",
            "",
            "",
            "",
            "",
            "",
            "\x01\x7f\x0f\uffff\x01\u0080",
            "",
            "",
            "",
            "",
            "\x22\x2d\x01\u0081\uffdd\x2d",
            "\x72\x2d\x01\u0082\uff8d\x2d",
            "\x65\x2d\x01\u0083\uff9a\x2d",
            "\x6f\x2d\x01\u0084\uff90\x2d",
            "",
            "\x72\x2d\x01\u0086\uff8d\x2d",
            "\x65\x2d\x01\u0087\uff9a\x2d",
            "\x6f\x2d\x01\u0088\uff90\x2d",
            "\x22\x2d\x01\u0089\uffdd\x2d",
            "",
            "",
            "",
            "\x6f\x2d\x01\u008b\uff90\x2d",
            "\x65\x2d\x01\u008c\uff9a\x2d",
            "\x6e\x2d\x01\u008d\uff91\x2d",
            "",
            "\x64\x2d\x01\u008e\uff9b\x2d",
            "\x65\x2d\x01\u008f\uff9a\x2d",
            "\x6e\x2d\x01\u0090\uff91\x2d",
            "",
            "",
            "\x77\x2d\x01\u0092\uff88\x2d",
            "\x6b\x2d\x01\u0093\uff94\x2d",
            "\x74\x2d\x01\u0094\uff8b\x2d",
            "\x61\x2d\x01\u0095\uff9e\x2d",
            "\x6b\x2d\x01\u0096\uff94\x2d",
            "\x74\x2d\x01\u0097\uff8b\x2d",
            "",
            "\x22\x2d\x01\u0098\uffdd\x2d",
            "\x22\x2d\x01\u0099\uffdd\x2d",
            "\x68\x2d\x01\u009a\uff97\x2d",
            "\x79\x2d\x01\u009b\uff86\x2d",
            "\x22\x2d\x01\u009c\uffdd\x2d",
            "\x68\x2d\x01\u009d\uff97\x2d",
            "",
            "",
            "\x22\x2d\x01\u00a0\uffdd\x2d",
            "\x22\x2d\x01\u00a1\uffdd\x2d",
            "",
            "\x22\x2d\x01\u00a3\uffdd\x2d",
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

    static readonly short[] DFA4_eot = DFA.UnpackEncodedString(DFA4_eotS);
    static readonly short[] DFA4_eof = DFA.UnpackEncodedString(DFA4_eofS);
    static readonly char[] DFA4_min = DFA.UnpackEncodedStringToUnsignedChars(DFA4_minS);
    static readonly char[] DFA4_max = DFA.UnpackEncodedStringToUnsignedChars(DFA4_maxS);
    static readonly short[] DFA4_accept = DFA.UnpackEncodedString(DFA4_acceptS);
    static readonly short[] DFA4_special = DFA.UnpackEncodedString(DFA4_specialS);
    static readonly short[][] DFA4_transition = DFA.UnpackEncodedStringArray(DFA4_transitionS);

    protected class DFA4 : DFA
    {
        public DFA4(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 4;
            this.eot = DFA4_eot;
            this.eof = DFA4_eof;
            this.min = DFA4_min;
            this.max = DFA4_max;
            this.accept = DFA4_accept;
            this.special = DFA4_special;
            this.transition = DFA4_transition;

        }

        override public string Description
        {
            get { return "1:1: Tokens : ( T__9 | T__10 | T__11 | T__12 | T__13 | T__14 | T__15 | T__16 | T__17 | T__18 | T__19 | T__20 | T__21 | T__22 | T__23 | T__24 | T__25 | T__26 | T__27 | T__28 | T__29 | T__30 | T__31 | T__32 | T__33 | T__34 | T__35 | T__36 | T__37 | T__38 | T__39 | T__40 | T__41 | T__42 | T__43 | T__44 | T__45 | T__46 | T__47 | T__48 | T__49 | T__50 | T__51 | T__52 | T__53 | T__54 | T__55 | T__56 | T__57 | T__58 | T__59 | T__60 | T__61 | T__62 | T__63 | T__64 | T__65 | T__66 | INT | DATE | STRING | STRCHAR | WS );"; }
        }

    }


    protected internal int DFA4_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            IIntStream input = _input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA4_10 = input.LA(1);

                   	s = -1;
                   	if ( (LA4_10 == 'n') ) { s = 38; }

                   	else if ( (LA4_10 == 't') ) { s = 39; }

                   	else if ( (LA4_10 == 'y') ) { s = 40; }

                   	else if ( (LA4_10 == 'l') ) { s = 41; }

                   	else if ( (LA4_10 == 'm') ) { s = 42; }

                   	else if ( (LA4_10 == 'f') ) { s = 43; }

                   	else if ( ((LA4_10 >= '\u0000' && LA4_10 <= 'e') || (LA4_10 >= 'g' && LA4_10 <= 'k') || (LA4_10 >= 'o' && LA4_10 <= 's') || (LA4_10 >= 'u' && LA4_10 <= 'x') || (LA4_10 >= 'z' && LA4_10 <= '\uFFFF')) ) { s = 45; }

                   	else s = 44;

                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA4_70 = input.LA(1);

                   	s = -1;
                   	if ( (LA4_70 == 'i') ) { s = 88; }

                   	else if ( ((LA4_70 >= '\u0000' && LA4_70 <= 'h') || (LA4_70 >= 'j' && LA4_70 <= '\uFFFF')) ) { s = 45; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA4_88 = input.LA(1);

                   	s = -1;
                   	if ( (LA4_88 == 's') ) { s = 102; }

                   	else if ( ((LA4_88 >= '\u0000' && LA4_88 <= 'r') || (LA4_88 >= 't' && LA4_88 <= '\uFFFF')) ) { s = 45; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 3 : 
                   	int LA4_39 = input.LA(1);

                   	s = -1;
                   	if ( (LA4_39 == 'o') ) { s = 69; }

                   	else if ( (LA4_39 == 'h') ) { s = 70; }

                   	else if ( (LA4_39 == 'r') ) { s = 71; }

                   	else if ( ((LA4_39 >= '\u0000' && LA4_39 <= 'g') || (LA4_39 >= 'i' && LA4_39 <= 'n') || (LA4_39 >= 'p' && LA4_39 <= 'q') || (LA4_39 >= 's' && LA4_39 <= '\uFFFF')) ) { s = 45; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 4 : 
                   	int LA4_142 = input.LA(1);

                   	s = -1;
                   	if ( (LA4_142 == 'a') ) { s = 149; }

                   	else if ( ((LA4_142 >= '\u0000' && LA4_142 <= '`') || (LA4_142 >= 'b' && LA4_142 <= '\uFFFF')) ) { s = 45; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 5 : 
                   	int LA4_149 = input.LA(1);

                   	s = -1;
                   	if ( (LA4_149 == 'y') ) { s = 155; }

                   	else if ( ((LA4_149 >= '\u0000' && LA4_149 <= 'x') || (LA4_149 >= 'z' && LA4_149 <= '\uFFFF')) ) { s = 45; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 6 : 
                   	int LA4_155 = input.LA(1);

                   	s = -1;
                   	if ( (LA4_155 == '\"') ) { s = 161; }

                   	else if ( ((LA4_155 >= '\u0000' && LA4_155 <= '!') || (LA4_155 >= '#' && LA4_155 <= '\uFFFF')) ) { s = 45; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 7 : 
                   	int LA4_90 = input.LA(1);

                   	s = -1;
                   	if ( (LA4_90 == 't') ) { s = 104; }

                   	else if ( ((LA4_90 >= '\u0000' && LA4_90 <= 's') || (LA4_90 >= 'u' && LA4_90 <= '\uFFFF')) ) { s = 45; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 8 : 
                   	int LA4_104 = input.LA(1);

                   	s = -1;
                   	if ( (LA4_104 == 'e') ) { s = 123; }

                   	else if ( ((LA4_104 >= '\u0000' && LA4_104 <= 'd') || (LA4_104 >= 'f' && LA4_104 <= '\uFFFF')) ) { s = 45; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 9 : 
                   	int LA4_123 = input.LA(1);

                   	s = -1;
                   	if ( (LA4_123 == 'r') ) { s = 134; }

                   	else if ( ((LA4_123 >= '\u0000' && LA4_123 <= 'q') || (LA4_123 >= 's' && LA4_123 <= '\uFFFF')) ) { s = 45; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 10 : 
                   	int LA4_134 = input.LA(1);

                   	s = -1;
                   	if ( (LA4_134 == 'd') ) { s = 142; }

                   	else if ( ((LA4_134 >= '\u0000' && LA4_134 <= 'c') || (LA4_134 >= 'e' && LA4_134 <= '\uFFFF')) ) { s = 45; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 11 : 
                   	int LA4_102 = input.LA(1);

                   	s = -1;
                   	if ( (LA4_102 == 'w') ) { s = 120; }

                   	else if ( (LA4_102 == 'm') ) { s = 121; }

                   	else if ( ((LA4_102 >= '\u0000' && LA4_102 <= 'l') || (LA4_102 >= 'n' && LA4_102 <= 'v') || (LA4_102 >= 'x' && LA4_102 <= '\uFFFF')) ) { s = 45; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 12 : 
                   	int LA4_72 = input.LA(1);

                   	s = -1;
                   	if ( (LA4_72 == 's') ) { s = 90; }

                   	else if ( ((LA4_72 >= '\u0000' && LA4_72 <= 'r') || (LA4_72 >= 't' && LA4_72 <= '\uFFFF')) ) { s = 45; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 13 : 
                   	int LA4_40 = input.LA(1);

                   	s = -1;
                   	if ( (LA4_40 == 'e') ) { s = 72; }

                   	else if ( ((LA4_40 >= '\u0000' && LA4_40 <= 'd') || (LA4_40 >= 'f' && LA4_40 <= '\uFFFF')) ) { s = 45; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 14 : 
                   	int LA4_69 = input.LA(1);

                   	s = -1;
                   	if ( (LA4_69 == 'd') ) { s = 86; }

                   	else if ( (LA4_69 == 'm') ) { s = 87; }

                   	else if ( ((LA4_69 >= '\u0000' && LA4_69 <= 'c') || (LA4_69 >= 'e' && LA4_69 <= 'l') || (LA4_69 >= 'n' && LA4_69 <= '\uFFFF')) ) { s = 45; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 15 : 
                   	int LA4_118 = input.LA(1);

                   	s = -1;
                   	if ( (LA4_118 == '\"') ) { s = 129; }

                   	else if ( ((LA4_118 >= '\u0000' && LA4_118 <= '!') || (LA4_118 >= '#' && LA4_118 <= '\uFFFF')) ) { s = 45; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 16 : 
                   	int LA4_86 = input.LA(1);

                   	s = -1;
                   	if ( (LA4_86 == 'a') ) { s = 100; }

                   	else if ( ((LA4_86 >= '\u0000' && LA4_86 <= '`') || (LA4_86 >= 'b' && LA4_86 <= '\uFFFF')) ) { s = 45; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 17 : 
                   	int LA4_100 = input.LA(1);

                   	s = -1;
                   	if ( (LA4_100 == 'y') ) { s = 118; }

                   	else if ( ((LA4_100 >= '\u0000' && LA4_100 <= 'x') || (LA4_100 >= 'z' && LA4_100 <= '\uFFFF')) ) { s = 45; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 18 : 
                   	int LA4_85 = input.LA(1);

                   	s = -1;
                   	if ( (LA4_85 == '\"') ) { s = 99; }

                   	else if ( ((LA4_85 >= '\u0000' && LA4_85 <= '!') || (LA4_85 >= '#' && LA4_85 <= '\uFFFF')) ) { s = 45; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 19 : 
                   	int LA4_68 = input.LA(1);

                   	s = -1;
                   	if ( (LA4_68 == 'w') ) { s = 85; }

                   	else if ( ((LA4_68 >= '\u0000' && LA4_68 <= 'v') || (LA4_68 >= 'x' && LA4_68 <= '\uFFFF')) ) { s = 45; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 20 : 
                   	int LA4_38 = input.LA(1);

                   	s = -1;
                   	if ( (LA4_38 == 'o') ) { s = 68; }

                   	else if ( ((LA4_38 >= '\u0000' && LA4_38 <= 'n') || (LA4_38 >= 'p' && LA4_38 <= '\uFFFF')) ) { s = 45; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 21 : 
                   	int LA4_136 = input.LA(1);

                   	s = -1;
                   	if ( (LA4_136 == 'n') ) { s = 144; }

                   	else if ( ((LA4_136 >= '\u0000' && LA4_136 <= 'm') || (LA4_136 >= 'o' && LA4_136 <= '\uFFFF')) ) { s = 45; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 22 : 
                   	int LA4_125 = input.LA(1);

                   	s = -1;
                   	if ( (LA4_125 == 'o') ) { s = 136; }

                   	else if ( ((LA4_125 >= '\u0000' && LA4_125 <= 'n') || (LA4_125 >= 'p' && LA4_125 <= '\uFFFF')) ) { s = 45; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 23 : 
                   	int LA4_151 = input.LA(1);

                   	s = -1;
                   	if ( (LA4_151 == 'h') ) { s = 157; }

                   	else if ( ((LA4_151 >= '\u0000' && LA4_151 <= 'g') || (LA4_151 >= 'i' && LA4_151 <= '\uFFFF')) ) { s = 45; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 24 : 
                   	int LA4_144 = input.LA(1);

                   	s = -1;
                   	if ( (LA4_144 == 't') ) { s = 151; }

                   	else if ( ((LA4_144 >= '\u0000' && LA4_144 <= 's') || (LA4_144 >= 'u' && LA4_144 <= '\uFFFF')) ) { s = 45; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 25 : 
                   	int LA4_124 = input.LA(1);

                   	s = -1;
                   	if ( (LA4_124 == 'e') ) { s = 135; }

                   	else if ( ((LA4_124 >= '\u0000' && LA4_124 <= 'd') || (LA4_124 >= 'f' && LA4_124 <= '\uFFFF')) ) { s = 45; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 26 : 
                   	int LA4_135 = input.LA(1);

                   	s = -1;
                   	if ( (LA4_135 == 'e') ) { s = 143; }

                   	else if ( ((LA4_135 >= '\u0000' && LA4_135 <= 'd') || (LA4_135 >= 'f' && LA4_135 <= '\uFFFF')) ) { s = 45; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 27 : 
                   	int LA4_143 = input.LA(1);

                   	s = -1;
                   	if ( (LA4_143 == 'k') ) { s = 150; }

                   	else if ( ((LA4_143 >= '\u0000' && LA4_143 <= 'j') || (LA4_143 >= 'l' && LA4_143 <= '\uFFFF')) ) { s = 45; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 28 : 
                   	int LA4_150 = input.LA(1);

                   	s = -1;
                   	if ( (LA4_150 == '\"') ) { s = 156; }

                   	else if ( ((LA4_150 >= '\u0000' && LA4_150 <= '!') || (LA4_150 >= '#' && LA4_150 <= '\uFFFF')) ) { s = 45; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 29 : 
                   	int LA4_101 = input.LA(1);

                   	s = -1;
                   	if ( (LA4_101 == 'r') ) { s = 119; }

                   	else if ( ((LA4_101 >= '\u0000' && LA4_101 <= 'q') || (LA4_101 >= 's' && LA4_101 <= '\uFFFF')) ) { s = 45; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 30 : 
                   	int LA4_119 = input.LA(1);

                   	s = -1;
                   	if ( (LA4_119 == 'r') ) { s = 130; }

                   	else if ( ((LA4_119 >= '\u0000' && LA4_119 <= 'q') || (LA4_119 >= 's' && LA4_119 <= '\uFFFF')) ) { s = 45; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 31 : 
                   	int LA4_87 = input.LA(1);

                   	s = -1;
                   	if ( (LA4_87 == 'o') ) { s = 101; }

                   	else if ( ((LA4_87 >= '\u0000' && LA4_87 <= 'n') || (LA4_87 >= 'p' && LA4_87 <= '\uFFFF')) ) { s = 45; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 32 : 
                   	int LA4_146 = input.LA(1);

                   	s = -1;
                   	if ( (LA4_146 == '\"') ) { s = 152; }

                   	else if ( ((LA4_146 >= '\u0000' && LA4_146 <= '!') || (LA4_146 >= '#' && LA4_146 <= '\uFFFF')) ) { s = 45; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 33 : 
                   	int LA4_130 = input.LA(1);

                   	s = -1;
                   	if ( (LA4_130 == 'o') ) { s = 139; }

                   	else if ( ((LA4_130 >= '\u0000' && LA4_130 <= 'n') || (LA4_130 >= 'p' && LA4_130 <= '\uFFFF')) ) { s = 45; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 34 : 
                   	int LA4_139 = input.LA(1);

                   	s = -1;
                   	if ( (LA4_139 == 'w') ) { s = 146; }

                   	else if ( ((LA4_139 >= '\u0000' && LA4_139 <= 'v') || (LA4_139 >= 'x' && LA4_139 <= '\uFFFF')) ) { s = 45; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 35 : 
                   	int LA4_74 = input.LA(1);

                   	s = -1;
                   	if ( (LA4_74 == '\"') ) { s = 92; }

                   	else if ( ((LA4_74 >= '\u0000' && LA4_74 <= '!') || (LA4_74 >= '#' && LA4_74 <= '\uFFFF')) ) { s = 45; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 36 : 
                   	int LA4_42 = input.LA(1);

                   	s = -1;
                   	if ( (LA4_42 == 'e') ) { s = 74; }

                   	else if ( ((LA4_42 >= '\u0000' && LA4_42 <= 'd') || (LA4_42 >= 'f' && LA4_42 <= '\uFFFF')) ) { s = 45; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 37 : 
                   	int LA4_148 = input.LA(1);

                   	s = -1;
                   	if ( (LA4_148 == 'h') ) { s = 154; }

                   	else if ( ((LA4_148 >= '\u0000' && LA4_148 <= 'g') || (LA4_148 >= 'i' && LA4_148 <= '\uFFFF')) ) { s = 45; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 38 : 
                   	int LA4_141 = input.LA(1);

                   	s = -1;
                   	if ( (LA4_141 == 't') ) { s = 148; }

                   	else if ( ((LA4_141 >= '\u0000' && LA4_141 <= 's') || (LA4_141 >= 'u' && LA4_141 <= '\uFFFF')) ) { s = 45; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 39 : 
                   	int LA4_154 = input.LA(1);

                   	s = -1;
                   	if ( (LA4_154 == '\"') ) { s = 160; }

                   	else if ( ((LA4_154 >= '\u0000' && LA4_154 <= '!') || (LA4_154 >= '#' && LA4_154 <= '\uFFFF')) ) { s = 45; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 40 : 
                   	int LA4_73 = input.LA(1);

                   	s = -1;
                   	if ( (LA4_73 == 's') ) { s = 91; }

                   	else if ( ((LA4_73 >= '\u0000' && LA4_73 <= 'r') || (LA4_73 >= 't' && LA4_73 <= '\uFFFF')) ) { s = 45; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 41 : 
                   	int LA4_121 = input.LA(1);

                   	s = -1;
                   	if ( (LA4_121 == 'o') ) { s = 132; }

                   	else if ( ((LA4_121 >= '\u0000' && LA4_121 <= 'n') || (LA4_121 >= 'p' && LA4_121 <= '\uFFFF')) ) { s = 45; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 42 : 
                   	int LA4_132 = input.LA(1);

                   	s = -1;
                   	if ( (LA4_132 == 'n') ) { s = 141; }

                   	else if ( ((LA4_132 >= '\u0000' && LA4_132 <= 'm') || (LA4_132 >= 'o' && LA4_132 <= '\uFFFF')) ) { s = 45; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 43 : 
                   	int LA4_91 = input.LA(1);

                   	s = -1;
                   	if ( (LA4_91 == 't') ) { s = 105; }

                   	else if ( ((LA4_91 >= '\u0000' && LA4_91 <= 's') || (LA4_91 >= 'u' && LA4_91 <= '\uFFFF')) ) { s = 45; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 44 : 
                   	int LA4_105 = input.LA(1);

                   	s = -1;
                   	if ( (LA4_105 == 'w') ) { s = 124; }

                   	else if ( (LA4_105 == 'm') ) { s = 125; }

                   	else if ( ((LA4_105 >= '\u0000' && LA4_105 <= 'l') || (LA4_105 >= 'n' && LA4_105 <= 'v') || (LA4_105 >= 'x' && LA4_105 <= '\uFFFF')) ) { s = 45; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 45 : 
                   	int LA4_89 = input.LA(1);

                   	s = -1;
                   	if ( (LA4_89 == 'e') ) { s = 103; }

                   	else if ( ((LA4_89 >= '\u0000' && LA4_89 <= 'd') || (LA4_89 >= 'f' && LA4_89 <= '\uFFFF')) ) { s = 45; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 46 : 
                   	int LA4_71 = input.LA(1);

                   	s = -1;
                   	if ( (LA4_71 == 'u') ) { s = 89; }

                   	else if ( ((LA4_71 >= '\u0000' && LA4_71 <= 't') || (LA4_71 >= 'v' && LA4_71 <= '\uFFFF')) ) { s = 45; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 47 : 
                   	int LA4_41 = input.LA(1);

                   	s = -1;
                   	if ( (LA4_41 == 'a') ) { s = 73; }

                   	else if ( ((LA4_41 >= '\u0000' && LA4_41 <= '`') || (LA4_41 >= 'b' && LA4_41 <= '\uFFFF')) ) { s = 45; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 48 : 
                   	int LA4_126 = input.LA(1);

                   	s = -1;
                   	if ( (LA4_126 == '\"') ) { s = 137; }

                   	else if ( ((LA4_126 >= '\u0000' && LA4_126 <= '!') || (LA4_126 >= '#' && LA4_126 <= '\uFFFF')) ) { s = 45; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 49 : 
                   	int LA4_93 = input.LA(1);

                   	s = -1;
                   	if ( (LA4_93 == 's') ) { s = 107; }

                   	else if ( ((LA4_93 >= '\u0000' && LA4_93 <= 'r') || (LA4_93 >= 't' && LA4_93 <= '\uFFFF')) ) { s = 45; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 50 : 
                   	int LA4_107 = input.LA(1);

                   	s = -1;
                   	if ( (LA4_107 == 'e') ) { s = 126; }

                   	else if ( ((LA4_107 >= '\u0000' && LA4_107 <= 'd') || (LA4_107 >= 'f' && LA4_107 <= '\uFFFF')) ) { s = 45; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 51 : 
                   	int LA4_147 = input.LA(1);

                   	s = -1;
                   	if ( (LA4_147 == '\"') ) { s = 153; }

                   	else if ( ((LA4_147 >= '\u0000' && LA4_147 <= '!') || (LA4_147 >= '#' && LA4_147 <= '\uFFFF')) ) { s = 45; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 52 : 
                   	int LA4_140 = input.LA(1);

                   	s = -1;
                   	if ( (LA4_140 == 'k') ) { s = 147; }

                   	else if ( ((LA4_140 >= '\u0000' && LA4_140 <= 'j') || (LA4_140 >= 'l' && LA4_140 <= '\uFFFF')) ) { s = 45; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 53 : 
                   	int LA4_131 = input.LA(1);

                   	s = -1;
                   	if ( (LA4_131 == 'e') ) { s = 140; }

                   	else if ( ((LA4_131 >= '\u0000' && LA4_131 <= 'd') || (LA4_131 >= 'f' && LA4_131 <= '\uFFFF')) ) { s = 45; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 54 : 
                   	int LA4_120 = input.LA(1);

                   	s = -1;
                   	if ( (LA4_120 == 'e') ) { s = 131; }

                   	else if ( ((LA4_120 >= '\u0000' && LA4_120 <= 'd') || (LA4_120 >= 'f' && LA4_120 <= '\uFFFF')) ) { s = 45; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 55 : 
                   	int LA4_103 = input.LA(1);

                   	s = -1;
                   	if ( (LA4_103 == '\"') ) { s = 122; }

                   	else if ( ((LA4_103 >= '\u0000' && LA4_103 <= '!') || (LA4_103 >= '#' && LA4_103 <= '\uFFFF')) ) { s = 45; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 56 : 
                   	int LA4_43 = input.LA(1);

                   	s = -1;
                   	if ( (LA4_43 == 'a') ) { s = 75; }

                   	else if ( ((LA4_43 >= '\u0000' && LA4_43 <= '`') || (LA4_43 >= 'b' && LA4_43 <= '\uFFFF')) ) { s = 45; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 57 : 
                   	int LA4_75 = input.LA(1);

                   	s = -1;
                   	if ( (LA4_75 == 'l') ) { s = 93; }

                   	else if ( ((LA4_75 >= '\u0000' && LA4_75 <= 'k') || (LA4_75 >= 'm' && LA4_75 <= '\uFFFF')) ) { s = 45; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 58 : 
                   	int LA4_157 = input.LA(1);

                   	s = -1;
                   	if ( (LA4_157 == '\"') ) { s = 163; }

                   	else if ( ((LA4_157 >= '\u0000' && LA4_157 <= '!') || (LA4_157 >= '#' && LA4_157 <= '\uFFFF')) ) { s = 45; }

                   	if ( s >= 0 ) return s;
                   	break;
        }
        NoViableAltException nvae4 =
            new NoViableAltException(dfa.Description, 4, _s, input);
        dfa.Error(nvae4);
        throw nvae4;
    }
 
    
}
