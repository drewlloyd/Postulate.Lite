﻿using Postulate.Lite.Core.Models;
using System.Collections.Generic;
using System.Data;

namespace Postulate.Lite.Core.Merge
{
	public class AddColumn : Action
	{
		public AddColumn(ColumnInfo columnInfo) : base(ObjectType.Column, ActionType.Create)
		{
			ColumnInfo = columnInfo;
		}

		public ColumnInfo ColumnInfo { get; private set; }

		public override IEnumerable<string> SqlCommands<TKey>(CommandProvider<TKey> commandProvider, IDbConnection connection)
		{
			yield return commandProvider.AddColumnCommand(ColumnInfo);
		}
	}
}