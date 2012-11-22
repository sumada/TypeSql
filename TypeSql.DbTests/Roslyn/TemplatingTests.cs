﻿using System.Collections.Generic;
using System.Data;
using TypeSql.Parsing;
using TypeSql.Templating.Dapper;
using Xunit;
using Roslyn.Scripting.CSharp;

namespace TypeSql.Tests.Templating
{
    public class TemplatingTests
    {

        [Fact]
        public void DapperTemplateTest_OneOutput()
        {
            //arrange 
            var parseResult = new ParseResult(
                new List<OutputToken> { new OutputToken("FirstName", "string") },
                new List<InputToken>(), "SELECT FirstName FROM SalesLT.Customer");

            const string sqlName = "CustomerFirstNameQuery";

            var template = new DapperDaoTemplate(sqlName, parseResult);

            //act
            string result = template.TransformText();

            var engine = new ScriptEngine();
            var session = engine.CreateSession();
            session.AddReference("System.Core");
            session.AddReference(typeof (DapperDaoTemplate).Assembly);
            session.AddReference(typeof(IDbConnection).Assembly);
            session.Execute("using System.Linq;");
            session.Execute(result);
            session.Execute("var query = new CustomerFirstNameQuery(\"AdventureWorks\");") ;
            var queryResult = session.Execute("query.Execute().ToList();");

        }
        [Fact]
        public void DapperTemplateTest_OneOutput_OneInput()
        {
            //arrange 
            var parseResult = new ParseResult(
                new List<OutputToken> { new OutputToken("FirstName", "string") },
                new List<InputToken>{new InputToken("Id", "int")}, 
                "SELECT FirstName FROM SalesLT.Customer WHERE CustomerId=@Id");

            const string sqlName = "CustomerFirstNameByIdQuery";

            var template = new DapperDaoTemplate(sqlName, parseResult);

            //act
            string result = template.TransformText();

            var engine = new ScriptEngine();
            var session = engine.CreateSession();
            session.AddReference("System.Core");
            session.AddReference(typeof (DapperDaoTemplate).Assembly);
            session.AddReference(typeof(IDbConnection).Assembly);
            session.Execute("using System.Linq;");
            session.Execute(result);
            session.Execute("var query = new CustomerFirstNameByIdQuery(\"AdventureWorks\");") ;
            var queryResult = session.Execute("query.Execute(Id:10).ToList();");

        }
    }
}