 using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Dotnet.Models;

namespace Dotnet.Controllers;

public class ClassinfoController  : Controller
{
    private readonly  AppDbContext _context;

    public ClassinfoController(AppDbContext context)
    {
         _context = context;
    }

     [HttpGet]
     public async task <IActionResult> Index(){
        var = await _context.Classinfo.ToListAsync();

        return View();

     }
     [HttpPost]

     [HttpGet]
      public async Task<IActionResult> Update(long id)
      {
          try
          {
               var info = await  _context.ClassInfos.Where(x.ClassInfo=>x.id==id).FirstOrDefaultAsync();
               if(info==null)throw new Exception($"class info with id '{id}' nor found");
               var model = new ClassInfoVm()
               {
                    Name= Info.Name,
                    Description = info.Description
               };
               return View(model);
          }
          catch (Exception e)
          {
               return BadRequest(e.Message);
               
               
          }
      }
      [HttpPost]
      public async Task<IActionResult> Update(long id,ClassInfoVm model)
      {
          try{
               var info = await _context.ClassInfos.Where(ClassInfo=>x.id==id).FirstOrDefaultAsync();
               if(info==null)throw new Exception($"class info with id {id} not found");
               info.Name=model.Name;
               info.Description=model.Description;
               _context.ClassInfos.Update(info);
               awaot _context.SaveChangesAsync();
               return RedirectToAction("Index");
          }
          catch(Exception e)
          {
               return BadRequest(e.Message);
          }
      }
      [HttpGet]
      public async Task<IActionResult>Delete(long id)
      {
          try{
               var info = await _context.ClassInfos.Where(ClassInfo=> x.Id==id).FirstOrDefaultAsync();
               if(info==null) throw new Exception($"class info with id{id} not found");
               _context.ClassInfos.Remove(info);
               await _context.SaveChangesAsync();
               return RedirectToAction("Index");
               
          }
          catch(Exception e)
          {
               return BadRequest(e.Message);
          }
      }
    
}