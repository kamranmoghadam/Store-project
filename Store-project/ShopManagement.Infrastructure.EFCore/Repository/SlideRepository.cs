using _0_Framework.Infrastructure;
using Microsoft.EntityFrameworkCore;
using ShopManagement.Application.Contracts.Slide;
using ShopManagement.Domain.SlideAgg;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace ShopManagement.Infrastructure.EFCore.Repository
{
    public class SlideRepository:RepositoryBase<long,Slide>,ISlideRepository
    {
        private readonly ShopContext _context;

        public SlideRepository( ShopContext Context) : base(Context)
        {
            _context= Context;
        }

        public SlideRepository(DbContext context) : base(context)
        {
        }

        public EditSlide GetDetails(long id)
        {
            return _context.Slides.Select(x=>new EditSlide
            {
                Id=x.Id, Title=x.Title,
                PictureTitle=x.PictureTitle,
                Picture=x.Picture,
                PictureAlt = x.PictureAlt,
                Heading=x.Heading,
                Text = x.BtnText,
                BtnText = x.BtnText
            }).FirstOrDefault(x => x.Id==id);
        }

        public List<SlideViewModel> GetList()
        {
            return _context.Slides.Select(X => new SlideViewModel
            {
                Id=X.Id,
                Title=X.Title,
                Picture=X.Picture,
                Heading = X.Heading,
                IsRemoved = X.IsRemoved,
                CreationDate = X.CreationDate.ToString()
            }).OrderByDescending(x=>x.Id).ToList();
        }
    }
}
