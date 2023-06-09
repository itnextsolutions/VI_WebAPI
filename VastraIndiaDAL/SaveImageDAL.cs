﻿using Microsoft.AspNetCore.Http;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Web;

namespace VastraIndiaDAL
{
    public class SaveImageDAL
    {

        public async Task SaveImagesAsync(IFormFile formFile, string FileName, string FolderName)
        {
            try
            {
                //var formCollection = await Request.ReadFormAsync();
                var file = formFile;

                var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), FolderName);
                if (file.Length > 0)
                {
                    var fileName = FileName;
                    //  var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                    var fullPath = Path.Combine(pathToSave, fileName);
                    var dbPath = Path.Combine(FolderName, fileName);
                    using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        file.CopyTo(stream);
                    }
                }
            }

            catch (Exception ex)
            {
                //return StatusCode(500, $"Internal server error: {ex}");
            }
        }

        public async Task SaveProductImagesAsync(IFormFile MenFrontImage, IFormFile MenSideImage, IFormFile MenBackImage, IFormFile MenSizeChartImage, string MenFrontImageFile, string MenSideImageFile, string MenBackImageFile,string MenSizeChartImageFile, IFormFile WomenFrontImage, IFormFile WomenSideImage, IFormFile WomenBackImage, IFormFile WomenSizeChartImage,string WomenFrontImageFile,string WomenSideImageFile,string WomenBakImageFile,string WomenSizeChartImageFile, string FolderName)
        {
            try
            {
                //var formCollection = await Request.ReadFormAsync();
                var file = MenFrontImage;

                var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), FolderName);
                if (file.Length > 0)
                {
                    //var fileName = MenFrontImageFile;
                    //  var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                    var fullPath = Path.Combine(pathToSave, MenFrontImageFile);
                    var dbPath = Path.Combine(FolderName, MenFrontImageFile);
                    using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        file.CopyTo(stream);
                    }
                }

                var file1 = MenSideImage;

                if (file1.Length > 0)
                {
                    //  var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                    var fullPath = Path.Combine(pathToSave, MenSideImageFile);
                    var dbPath = Path.Combine(FolderName, MenSideImageFile);
                    using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        file1.CopyTo(stream);
                    }
                }


                var file2 = MenBackImage;

                if (file2.Length > 0)
                {
                    //  var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                    var fullPath = Path.Combine(pathToSave, MenBackImageFile);
                    var dbPath = Path.Combine(FolderName, MenBackImageFile);
                    using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        file2.CopyTo(stream);
                    }
                }

                var file3 = MenSizeChartImage;

                if (file3.Length > 0)
                {
                    //  var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                    var fullPath = Path.Combine(pathToSave, MenSizeChartImageFile);
                    var dbPath = Path.Combine(FolderName, MenSizeChartImageFile);
                    using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        file3.CopyTo(stream);
                    }
                }

                var file4 = WomenFrontImage;

                if (file4.Length > 0)
                {
                    //  var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                    var fullPath = Path.Combine(pathToSave, WomenFrontImageFile);
                    var dbPath = Path.Combine(FolderName, WomenFrontImageFile);
                    using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        file4.CopyTo(stream);
                    }
                }

                var file5 = WomenSideImage;

                if (file5.Length > 0)
                {
                    //  var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                    var fullPath = Path.Combine(pathToSave, WomenSideImageFile);
                    var dbPath = Path.Combine(FolderName, WomenSideImageFile);
                    using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        file5.CopyTo(stream);
                    }
                }


                var file6 = WomenBackImage;

                if (file6.Length > 0)
                {
                    //  var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                    var fullPath = Path.Combine(pathToSave, WomenBakImageFile);
                    var dbPath = Path.Combine(FolderName, WomenBakImageFile);
                    using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        file6.CopyTo(stream);
                    }
                }

                var file7 = WomenSizeChartImage;

                if (file7.Length > 0)
                {
                    //  var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                    var fullPath = Path.Combine(pathToSave, WomenSizeChartImageFile);
                    var dbPath = Path.Combine(FolderName, WomenSizeChartImageFile);
                    using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        file7.CopyTo(stream);
                    }
                }
            }

            catch (Exception ex)
            {
                //return StatusCode(500, $"Internal server error: {ex}");
            }
        }
    }
}