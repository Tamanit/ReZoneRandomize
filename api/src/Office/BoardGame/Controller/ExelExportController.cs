using api.DataBase.Repository;
using Aspose.Cells;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using AppContext = api.DataBase.AppContext;

namespace api.Office.BoardGame.Controller;

[ApiController]
[Route("api/v1/office")]
public class ExelExportController : ControllerBase
{
    [HttpGet]
    [Route("export")]
    public IActionResult all()
    {
        Workbook wb = new Workbook();
        Worksheet sheet = wb.Worksheets[0];
        sheet.Cells["A1"].PutValue("Системное Имя");
        sheet.Cells["B1"].PutValue("Назавние настольной игры");
        sheet.Cells["C1"].PutValue("Описание");
        sheet.Cells["D1"].PutValue("Правила игры");
        sheet.Cells["E1"].PutValue("Сложность");
        sheet.Cells["F1"].PutValue("Возврастное ограничение");
        sheet.Cells["G1"].PutValue("Кол-во игроков");

        var boardGames = new BoardGameRepository().GetAll();
        int counter = 2;
        foreach (var bg in boardGames)
        {
            sheet.Cells["A" + counter].PutValue(bg.Name);
            sheet.Cells["B" + counter].PutValue(bg.Title);
            sheet.Cells["C" + counter].PutValue(bg.Description);
            sheet.Cells["D" + counter].PutValue(bg.Rules);
            if (bg.Difficulty != null) sheet.Cells["E" + counter].PutValue(bg.Difficulty.Name);
            if (bg.AgeRestriction != null) sheet.Cells["F" + counter].PutValue(bg.AgeRestriction.Text);
            if (bg.PlayerCount != null) sheet.Cells["G" + counter].PutValue(bg.PlayerCount.Text);
            counter++;
        }

        var fileName = "Excel_Table" + Guid.NewGuid() + ".xlsx";
        wb.Save(fileName, SaveFormat.Xlsx);

        var memoryStream = new MemoryStream();

        using (var stream = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read,
                   bufferSize: 4096, useAsync: true))
        {
            stream.CopyTo(memoryStream);
        }

        memoryStream.Seek(offset: 0, SeekOrigin.Begin);
        
        System.IO.File.Delete(fileName);
        
        return new FileStreamResult(memoryStream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet");
    }
}