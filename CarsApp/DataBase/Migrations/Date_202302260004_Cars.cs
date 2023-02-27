using CarsApp.Models;
using FluentMigrator;
using System.Data;

namespace CarsApp.DataBase.Migrations;

[Migration(202302260004)]
public class Date_202302260004_Cars : Migration
{
    private string _modelTableName = nameof(Model).ToLower();
    private string _brandTableName = nameof(Brand).ToLower();

    public override void Down()
    {
        string[] tables = { _modelTableName, _brandTableName};

        foreach (var table in tables)
        {
            if (Schema.Table(table).Exists())
            {
                Delete.Table(table);
            }
        }
    }

    public override void Up()
    {
        if (!Schema.Table(_brandTableName).Exists())
        {
            Create.Table(_brandTableName)
                .WithColumn(nameof(Brand.Id)).AsInt32().NotNullable().PrimaryKey().Identity()
                .WithColumn(nameof(Brand.Name)).AsString(40).WithDefaultValue("").Unique()
                .WithColumn(nameof(Brand.Active)).AsBoolean().WithDefaultValue(false);
        }

        if (!Schema.Table(_modelTableName).Exists())
        {
            Create.Table(_modelTableName)
                .WithColumn(nameof(Model.Id)).AsInt32().NotNullable().PrimaryKey().Identity()
                .WithColumn(nameof(Model.Name)).AsString(40).WithDefaultValue("").Unique()
                .WithColumn(nameof(Model.Active)).AsBoolean().WithDefaultValue(false)
                .WithColumn(nameof(Model.BrandId)).AsInt32();

            Create.ForeignKey()
                .FromTable(_modelTableName).ForeignColumn(nameof(Model.BrandId))
                .ToTable(_brandTableName).PrimaryColumn(nameof(Brand.Id)).OnDelete(Rule.Cascade);
        }
    }
}
