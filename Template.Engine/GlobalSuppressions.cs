// This file is used by Code Analysis to maintain SuppressMessage 
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given 
// a specific target and scoped to a namespace, type, member, etc.
//
// To add a suppression to this file, right-click the message in the 
// Code Analysis results, point to "Suppress Message", and click 
// "In Suppression File".
// You do not need to add suppressions to this file manually.

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("Microsoft.Design", "CA1065:DoNotRaiseExceptionsInUnexpectedLocations", Scope = "member", Target = "Template.Engine.Security.BaseRoleProvider.#ApplicationName")]
[assembly: SuppressMessage("Microsoft.Usage", "CA2202:Do not dispose objects multiple times", Scope = "member", Target = "Template.Engine.Security.Cypher.#Desencriptar(System.String,System.String)")]
[assembly: SuppressMessage("Microsoft.Design", "CA1063:ImplementIDisposableCorrectly", Scope = "type", Target = "Template.Engine.Data.DataContext")]
[assembly: SuppressMessage("Microsoft.Design", "CA1063:ImplementIDisposableCorrectly", Scope = "member", Target = "Template.Engine.Data.DataContext.#Dispose()")]
[assembly: SuppressMessage("Microsoft.Security", "CA2100:Review SQL queries for security vulnerabilities", Scope = "member", Target = "Template.Engine.Data.DataContext.#ExecuteQuery(System.Int32)")]
[assembly: SuppressMessage("Microsoft.Security", "CA2100:Review SQL queries for security vulnerabilities", Scope = "member", Target = "Template.Engine.Data.DataContext.#ExecuteQuery`1(System.Int32)")]
[assembly: SuppressMessage("Microsoft.Security", "CA2100:Review SQL queries for security vulnerabilities", Scope = "member", Target = "Template.Engine.Data.DataContext.#ExecuteQuery()")]
[assembly: SuppressMessage("Microsoft.Security", "CA2100:Review SQL queries for security vulnerabilities", Scope = "member", Target = "Template.Engine.Data.DataContext.#ExecuteNonQuery()")]
[assembly: SuppressMessage("Microsoft.Usage", "CA2202:Do not dispose objects multiple times", Scope = "member", Target = "Template.Engine.Data.DataContext.#ExecuteNonQuery()")]
[assembly: SuppressMessage("Microsoft.Usage", "CA2202:Do not dispose objects multiple times", Scope = "member", Target = "Template.Engine.XML.XmlHelper.#Serializar(System.Object)")]
[assembly: SuppressMessage("Microsoft.Usage", "CA2202:Do not dispose objects multiple times", Scope = "member", Target = "Template.Engine.Security.Cypher.#Encriptar(System.String,System.String)")]
