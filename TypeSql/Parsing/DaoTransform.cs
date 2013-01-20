//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 3.4
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// $ANTLR 3.4 C:\\Users\\mjr\\src\\TypeSql\\TypeSql\\Parsing\\DaoTransform.g 2013-01-20 15:06:33

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 219
// Unreachable code detected.
#pragma warning disable 162
// Missing XML comment for publicly visible type or member 'Type_or_Member'
#pragma warning disable 1591
// CLS compliance checking will not be performed on 'type' because it is not visible from outside this assembly.
#pragma warning disable 3019


using System;
using System.Linq;
using TypeSql.Parsing;


using System.Collections.Generic;
using TypeSql.Antlr.Runtime;
using TypeSql.Antlr.Runtime.Misc;
using TypeSql.Antlr.Runtime.Tree;
using RewriteRuleITokenStream = TypeSql.Antlr.Runtime.Tree.RewriteRuleTokenStream;

using TypeSql.Antlr3.ST;
using TypeSql.Antlr3.ST.Language;
namespace  TypeSql.Parsing 
{
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "3.4")]
[System.CLSCompliant(false)]
internal partial class DaoTransform : Antlr.Runtime.Tree.TreeParser
{
	internal static readonly string[] tokenNames = new string[] {
		"<invalid>", "<EOR>", "<DOWN>", "<UP>", "ANY", "DIGIT", "ID", "INPUT_TOKEN", "NAMESPACE", "NAMESPACE_SEGMENT", "NEWLINE", "OUTPUT_TOKEN", "SQL", "TYPE", "TYPESQL", "USING", "WHITESPACE", "':'", "'?'", "'@'", "'['", "']'"
	};
	public const int EOF=-1;
	public const int T__17=17;
	public const int T__18=18;
	public const int T__19=19;
	public const int T__20=20;
	public const int T__21=21;
	public const int ANY=4;
	public const int DIGIT=5;
	public const int ID=6;
	public const int INPUT_TOKEN=7;
	public const int NAMESPACE=8;
	public const int NAMESPACE_SEGMENT=9;
	public const int NEWLINE=10;
	public const int OUTPUT_TOKEN=11;
	public const int SQL=12;
	public const int TYPE=13;
	public const int TYPESQL=14;
	public const int USING=15;
	public const int WHITESPACE=16;

	public DaoTransform(ITreeNodeStream input)
		: this(input, new RecognizerSharedState())
	{
	}
	public DaoTransform(ITreeNodeStream input, RecognizerSharedState state)
		: base(input, state)
	{
		OnCreated();
	}
	private StringTemplateGroup _templateGroup = new StringTemplateGroup("DaoTransformTemplates", typeof(AngleBracketTemplateLexer) );

	public StringTemplateGroup TemplateGroup
	{
		get { return _templateGroup; }
		set { _templateGroup = value; }
	}

	public override string[] TokenNames { get { return DaoTransform.tokenNames; } }
	public override string GrammarFileName { get { return "C:\\Users\\mjr\\src\\TypeSql\\TypeSql\\Parsing\\DaoTransform.g"; } }


	partial void OnCreated();
	partial void EnterRule(string ruleName, int ruleIndex);
	partial void LeaveRule(string ruleName, int ruleIndex);

	#region Rules
	partial void EnterRule_typeSql();
	partial void LeaveRule_typeSql();

	// $ANTLR start "typeSql"
	// C:\\Users\\mjr\\src\\TypeSql\\TypeSql\\Parsing\\DaoTransform.g:19:8: public typeSql[string name, string rawSql] : ^( TYPESQL ( ^( USING NAMESPACE ) )* ( ^( SQL ( outputToken | inputToken | . )* ) ) ) -> dao(name=nameusingNamespaces=usingNamespacesoutputTokens=outputTokensinputTokens=inputTokensrawSql=rawSql);
	[GrammarRule("typeSql")]
	public TemplateTreeRuleReturnScope<StringTemplate, CommonTree> typeSql(string name, string rawSql)
	{
		EnterRule_typeSql();
		EnterRule("typeSql", 1);
		TraceIn("typeSql", 1);
		TemplateTreeRuleReturnScope<StringTemplate, CommonTree> retval = new TemplateTreeRuleReturnScope<StringTemplate, CommonTree>();
		retval.Start = (CommonTree)input.LT(1);

		CommonTree NAMESPACE1 = default(CommonTree);
		DaoTransform.outputToken_return outputToken2 = default(DaoTransform.outputToken_return);
		DaoTransform.inputToken_return inputToken3 = default(DaoTransform.inputToken_return);


			var outputTokens = new List<OutputToken>();
			var inputTokens = new List<InputToken>();
			var usingNamespaces = new List<string>();

		try { DebugEnterRule(GrammarFileName, "typeSql");
		DebugLocation(19, 1);
		try
		{
			// C:\\Users\\mjr\\src\\TypeSql\\TypeSql\\Parsing\\DaoTransform.g:25:2: ( ^( TYPESQL ( ^( USING NAMESPACE ) )* ( ^( SQL ( outputToken | inputToken | . )* ) ) ) -> dao(name=nameusingNamespaces=usingNamespacesoutputTokens=outputTokensinputTokens=inputTokensrawSql=rawSql))
			DebugEnterAlt(1);
			// C:\\Users\\mjr\\src\\TypeSql\\TypeSql\\Parsing\\DaoTransform.g:25:4: ^( TYPESQL ( ^( USING NAMESPACE ) )* ( ^( SQL ( outputToken | inputToken | . )* ) ) )
			{
			DebugLocation(25, 4);
			DebugLocation(25, 6);
			Match(input,TYPESQL,Follow._TYPESQL_in_typeSql80); 

			Match(input, TokenTypes.Down, null); 
			DebugLocation(26, 4);
			// C:\\Users\\mjr\\src\\TypeSql\\TypeSql\\Parsing\\DaoTransform.g:26:4: ( ^( USING NAMESPACE ) )*
			try { DebugEnterSubRule(1);
			while (true)
			{
				int alt1=2;
				try { DebugEnterDecision(1, false);
				int LA1_0 = input.LA(1);

				if ((LA1_0==USING))
				{
					alt1 = 1;
				}


				} finally { DebugExitDecision(1); }
				switch ( alt1 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\Users\\mjr\\src\\TypeSql\\TypeSql\\Parsing\\DaoTransform.g:26:5: ^( USING NAMESPACE )
					{
					DebugLocation(26, 5);
					DebugLocation(26, 7);
					Match(input,USING,Follow._USING_in_typeSql88); 

					Match(input, TokenTypes.Down, null); 
					DebugLocation(26, 13);
					NAMESPACE1=(CommonTree)Match(input,NAMESPACE,Follow._NAMESPACE_in_typeSql90); 

					Match(input, TokenTypes.Up, null); 

					DebugLocation(26, 24);
					 usingNamespaces.Add((NAMESPACE1!=null?NAMESPACE1.Text:null)); 

					}
					break;

				default:
					goto loop1;
				}
			}

			loop1:
				;

			} finally { DebugExitSubRule(1); }

			DebugLocation(27, 4);
			// C:\\Users\\mjr\\src\\TypeSql\\TypeSql\\Parsing\\DaoTransform.g:27:4: ( ^( SQL ( outputToken | inputToken | . )* ) )
			DebugEnterAlt(1);
			// C:\\Users\\mjr\\src\\TypeSql\\TypeSql\\Parsing\\DaoTransform.g:27:5: ^( SQL ( outputToken | inputToken | . )* )
			{
			DebugLocation(27, 5);
			DebugLocation(27, 7);
			Match(input,SQL,Follow._SQL_in_typeSql104); 

			if (input.LA(1) == TokenTypes.Down)
			{
				Match(input, TokenTypes.Down, null); 
				DebugLocation(27, 11);
				// C:\\Users\\mjr\\src\\TypeSql\\TypeSql\\Parsing\\DaoTransform.g:27:11: ( outputToken | inputToken | . )*
				try { DebugEnterSubRule(2);
				while (true)
				{
					int alt2=4;
					try { DebugEnterDecision(2, false);
					switch (input.LA(1))
					{
					case OUTPUT_TOKEN:
						{
						int LA2_2 = input.LA(2);

						if ((LA2_2==DOWN))
						{
							int LA2_5 = input.LA(3);

							if ((LA2_5==ID))
							{
								int LA2_7 = input.LA(4);

								if ((LA2_7==TYPE))
								{
									int LA2_9 = input.LA(5);

									if ((LA2_9==DOWN))
									{
										alt2 = 1;
									}
									else if (((LA2_9>=UP && LA2_9<=21)))
									{
										alt2 = 3;
									}


								}
								else if (((LA2_7>=UP && LA2_7<=SQL)||(LA2_7>=TYPESQL && LA2_7<=21)))
								{
									alt2 = 3;
								}


							}
							else if (((LA2_5>=ANY && LA2_5<=DIGIT)||(LA2_5>=INPUT_TOKEN && LA2_5<=21)))
							{
								alt2 = 3;
							}


						}
						else if (((LA2_2>=UP && LA2_2<=21)))
						{
							alt2 = 3;
						}


						}
						break;
					case INPUT_TOKEN:
						{
						int LA2_3 = input.LA(2);

						if ((LA2_3==DOWN))
						{
							int LA2_6 = input.LA(3);

							if ((LA2_6==ID))
							{
								int LA2_8 = input.LA(4);

								if ((LA2_8==TYPE))
								{
									int LA2_10 = input.LA(5);

									if ((LA2_10==DOWN))
									{
										alt2 = 2;
									}
									else if (((LA2_10>=UP && LA2_10<=21)))
									{
										alt2 = 3;
									}


								}
								else if (((LA2_8>=UP && LA2_8<=SQL)||(LA2_8>=TYPESQL && LA2_8<=21)))
								{
									alt2 = 3;
								}


							}
							else if (((LA2_6>=ANY && LA2_6<=DIGIT)||(LA2_6>=INPUT_TOKEN && LA2_6<=21)))
							{
								alt2 = 3;
							}


						}
						else if (((LA2_3>=UP && LA2_3<=21)))
						{
							alt2 = 3;
						}


						}
						break;
					case ANY:
					case DIGIT:
					case ID:
					case NAMESPACE:
					case NAMESPACE_SEGMENT:
					case NEWLINE:
					case SQL:
					case TYPE:
					case TYPESQL:
					case USING:
					case WHITESPACE:
					case 17:
					case 18:
					case 19:
					case 20:
					case 21:
						{
						alt2 = 3;
						}
						break;
					}

					} finally { DebugExitDecision(2); }
					switch ( alt2 )
					{
					case 1:
						DebugEnterAlt(1);
						// C:\\Users\\mjr\\src\\TypeSql\\TypeSql\\Parsing\\DaoTransform.g:28:5: outputToken
						{
						DebugLocation(28, 5);
						PushFollow(Follow._outputToken_in_typeSql112);
						outputToken2=outputToken();
						PopFollow();

						DebugLocation(28, 17);
						 outputTokens.Add((outputToken2!=null?outputToken2.token:default(OutputToken))); 

						}
						break;
					case 2:
						DebugEnterAlt(2);
						// C:\\Users\\mjr\\src\\TypeSql\\TypeSql\\Parsing\\DaoTransform.g:29:7: inputToken
						{
						DebugLocation(29, 7);
						PushFollow(Follow._inputToken_in_typeSql123);
						inputToken3=inputToken();
						PopFollow();

						DebugLocation(29, 18);
						 inputTokens.Add((inputToken3!=null?inputToken3.token:default(InputToken))); 

						}
						break;
					case 3:
						DebugEnterAlt(3);
						// C:\\Users\\mjr\\src\\TypeSql\\TypeSql\\Parsing\\DaoTransform.g:30:7: .
						{
						DebugLocation(30, 7);
						MatchAny(input); 

						}
						break;

					default:
						goto loop2;
					}
				}

				loop2:
					;

				} finally { DebugExitSubRule(2); }


				Match(input, TokenTypes.Up, null); 
			}


			}


			Match(input, TokenTypes.Up, null); 


			// TEMPLATE REWRITE
			// 33:3: -> dao(name=nameusingNamespaces=usingNamespacesoutputTokens=outputTokensinputTokens=inputTokensrawSql=rawSql)
			{
				retval.Template = TemplateGroup.GetInstanceOf("dao",
				new Dictionary<string, object>() { {"name", name}, {"usingNamespaces", usingNamespaces}, {"outputTokens", outputTokens}, {"inputTokens", inputTokens}, {"rawSql", rawSql} }
			);
			}



			}

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("typeSql", 1);
			LeaveRule("typeSql", 1);
			LeaveRule_typeSql();
		}
		DebugLocation(34, 1);
		} finally { DebugExitRule(GrammarFileName, "typeSql"); }
		return retval;

	}
	// $ANTLR end "typeSql"

	private sealed partial class outputToken_return : TemplateTreeRuleReturnScope<StringTemplate, CommonTree>
	{
		public OutputToken token;
		public outputToken_return(DaoTransform grammar) {OnCreated(grammar);}
		partial void OnCreated(DaoTransform grammar);
	}

	partial void EnterRule_outputToken();
	partial void LeaveRule_outputToken();

	// $ANTLR start "outputToken"
	// C:\\Users\\mjr\\src\\TypeSql\\TypeSql\\Parsing\\DaoTransform.g:41:1: outputToken returns [OutputToken token] : ^( OUTPUT_TOKEN id= ID type ) ;
	[GrammarRule("outputToken")]
	private DaoTransform.outputToken_return outputToken()
	{
		EnterRule_outputToken();
		EnterRule("outputToken", 2);
		TraceIn("outputToken", 2);
		DaoTransform.outputToken_return retval = new DaoTransform.outputToken_return(this);
		retval.Start = (CommonTree)input.LT(1);

		CommonTree id = default(CommonTree);
		DaoTransform.type_return type4 = default(DaoTransform.type_return);

		try { DebugEnterRule(GrammarFileName, "outputToken");
		DebugLocation(41, 1);
		try
		{
			// C:\\Users\\mjr\\src\\TypeSql\\TypeSql\\Parsing\\DaoTransform.g:42:2: ( ^( OUTPUT_TOKEN id= ID type ) )
			DebugEnterAlt(1);
			// C:\\Users\\mjr\\src\\TypeSql\\TypeSql\\Parsing\\DaoTransform.g:42:4: ^( OUTPUT_TOKEN id= ID type )
			{
			DebugLocation(42, 4);
			DebugLocation(42, 6);
			Match(input,OUTPUT_TOKEN,Follow._OUTPUT_TOKEN_in_outputToken202); 

			Match(input, TokenTypes.Down, null); 
			DebugLocation(42, 21);
			id=(CommonTree)Match(input,ID,Follow._ID_in_outputToken206); 
			DebugLocation(42, 25);
			PushFollow(Follow._type_in_outputToken208);
			type4=type();
			PopFollow();


			Match(input, TokenTypes.Up, null); 

			DebugLocation(42, 33);
			 retval.token = new OutputToken((id!=null?id.Text:null), (type4!=null?type4.typeName:default(string))); 

			}

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("outputToken", 2);
			LeaveRule("outputToken", 2);
			LeaveRule_outputToken();
		}
		DebugLocation(43, 1);
		} finally { DebugExitRule(GrammarFileName, "outputToken"); }
		return retval;

	}
	// $ANTLR end "outputToken"

	private sealed partial class inputToken_return : TemplateTreeRuleReturnScope<StringTemplate, CommonTree>
	{
		public InputToken token;
		public inputToken_return(DaoTransform grammar) {OnCreated(grammar);}
		partial void OnCreated(DaoTransform grammar);
	}

	partial void EnterRule_inputToken();
	partial void LeaveRule_inputToken();

	// $ANTLR start "inputToken"
	// C:\\Users\\mjr\\src\\TypeSql\\TypeSql\\Parsing\\DaoTransform.g:45:1: inputToken returns [InputToken token] : ^( INPUT_TOKEN id= ID type ) ;
	[GrammarRule("inputToken")]
	private DaoTransform.inputToken_return inputToken()
	{
		EnterRule_inputToken();
		EnterRule("inputToken", 3);
		TraceIn("inputToken", 3);
		DaoTransform.inputToken_return retval = new DaoTransform.inputToken_return(this);
		retval.Start = (CommonTree)input.LT(1);

		CommonTree id = default(CommonTree);
		DaoTransform.type_return type5 = default(DaoTransform.type_return);

		try { DebugEnterRule(GrammarFileName, "inputToken");
		DebugLocation(45, 1);
		try
		{
			// C:\\Users\\mjr\\src\\TypeSql\\TypeSql\\Parsing\\DaoTransform.g:46:2: ( ^( INPUT_TOKEN id= ID type ) )
			DebugEnterAlt(1);
			// C:\\Users\\mjr\\src\\TypeSql\\TypeSql\\Parsing\\DaoTransform.g:46:4: ^( INPUT_TOKEN id= ID type )
			{
			DebugLocation(46, 4);
			DebugLocation(46, 6);
			Match(input,INPUT_TOKEN,Follow._INPUT_TOKEN_in_inputToken229); 

			Match(input, TokenTypes.Down, null); 
			DebugLocation(46, 20);
			id=(CommonTree)Match(input,ID,Follow._ID_in_inputToken233); 
			DebugLocation(46, 24);
			PushFollow(Follow._type_in_inputToken235);
			type5=type();
			PopFollow();


			Match(input, TokenTypes.Up, null); 

			DebugLocation(46, 32);
			 retval.token = new InputToken((id!=null?id.Text:null), (type5!=null?type5.typeName:default(string))); 

			}

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("inputToken", 3);
			LeaveRule("inputToken", 3);
			LeaveRule_inputToken();
		}
		DebugLocation(47, 1);
		} finally { DebugExitRule(GrammarFileName, "inputToken"); }
		return retval;

	}
	// $ANTLR end "inputToken"

	private sealed partial class type_return : TemplateTreeRuleReturnScope<StringTemplate, CommonTree>
	{
		public string typeName;
		public type_return(DaoTransform grammar) {OnCreated(grammar);}
		partial void OnCreated(DaoTransform grammar);
	}

	partial void EnterRule_type();
	partial void LeaveRule_type();

	// $ANTLR start "type"
	// C:\\Users\\mjr\\src\\TypeSql\\TypeSql\\Parsing\\DaoTransform.g:49:1: type returns [string typeName] : ^( TYPE ID ( '?' )? ) ;
	[GrammarRule("type")]
	private DaoTransform.type_return type()
	{
		EnterRule_type();
		EnterRule("type", 4);
		TraceIn("type", 4);
		DaoTransform.type_return retval = new DaoTransform.type_return(this);
		retval.Start = (CommonTree)input.LT(1);

		CommonTree ID6 = default(CommonTree);

		try { DebugEnterRule(GrammarFileName, "type");
		DebugLocation(49, 67);
		try
		{
			// C:\\Users\\mjr\\src\\TypeSql\\TypeSql\\Parsing\\DaoTransform.g:50:2: ( ^( TYPE ID ( '?' )? ) )
			DebugEnterAlt(1);
			// C:\\Users\\mjr\\src\\TypeSql\\TypeSql\\Parsing\\DaoTransform.g:50:4: ^( TYPE ID ( '?' )? )
			{
			DebugLocation(50, 4);
			DebugLocation(50, 6);
			Match(input,TYPE,Follow._TYPE_in_type258); 

			Match(input, TokenTypes.Down, null); 
			DebugLocation(50, 11);
			ID6=(CommonTree)Match(input,ID,Follow._ID_in_type260); 
			DebugLocation(50, 14);
			 retval.typeName =(ID6!=null?ID6.Text:null); 
			DebugLocation(50, 38);
			// C:\\Users\\mjr\\src\\TypeSql\\TypeSql\\Parsing\\DaoTransform.g:50:38: ( '?' )?
			int alt3=2;
			try { DebugEnterSubRule(3);
			try { DebugEnterDecision(3, false);
			int LA3_0 = input.LA(1);

			if ((LA3_0==18))
			{
				alt3 = 1;
			}
			} finally { DebugExitDecision(3); }
			switch (alt3)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\Users\\mjr\\src\\TypeSql\\TypeSql\\Parsing\\DaoTransform.g:50:39: '?'
				{
				DebugLocation(50, 39);
				Match(input,18,Follow._18_in_type265); 
				DebugLocation(50, 43);
				retval.typeName += '?'; 

				}
				break;

			}
			} finally { DebugExitSubRule(3); }


			Match(input, TokenTypes.Up, null); 


			}

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("type", 4);
			LeaveRule("type", 4);
			LeaveRule_type();
		}
		DebugLocation(50, 67);
		} finally { DebugExitRule(GrammarFileName, "type"); }
		return retval;

	}
	// $ANTLR end "type"
	#endregion Rules


	#region Follow sets
	private static class Follow
	{
		public static readonly BitSet _TYPESQL_in_typeSql80 = new BitSet(new ulong[]{0x4UL});
		public static readonly BitSet _USING_in_typeSql88 = new BitSet(new ulong[]{0x4UL});
		public static readonly BitSet _NAMESPACE_in_typeSql90 = new BitSet(new ulong[]{0x8UL});
		public static readonly BitSet _SQL_in_typeSql104 = new BitSet(new ulong[]{0x4UL});
		public static readonly BitSet _outputToken_in_typeSql112 = new BitSet(new ulong[]{0x3FFFF8UL});
		public static readonly BitSet _inputToken_in_typeSql123 = new BitSet(new ulong[]{0x3FFFF8UL});
		public static readonly BitSet _OUTPUT_TOKEN_in_outputToken202 = new BitSet(new ulong[]{0x4UL});
		public static readonly BitSet _ID_in_outputToken206 = new BitSet(new ulong[]{0x2000UL});
		public static readonly BitSet _type_in_outputToken208 = new BitSet(new ulong[]{0x8UL});
		public static readonly BitSet _INPUT_TOKEN_in_inputToken229 = new BitSet(new ulong[]{0x4UL});
		public static readonly BitSet _ID_in_inputToken233 = new BitSet(new ulong[]{0x2000UL});
		public static readonly BitSet _type_in_inputToken235 = new BitSet(new ulong[]{0x8UL});
		public static readonly BitSet _TYPE_in_type258 = new BitSet(new ulong[]{0x4UL});
		public static readonly BitSet _ID_in_type260 = new BitSet(new ulong[]{0x40008UL});
		public static readonly BitSet _18_in_type265 = new BitSet(new ulong[]{0x8UL});
	}
	#endregion Follow sets
}

} // namespace  TypeSql.Parsing 
