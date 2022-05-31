using System.Collections.Generic;
using _0_Framework.Application;
using Microsoft.EntityFrameworkCore;

namespace ShopManagement.Application.Contracts.Slide
{
    public interface ISlideApplication
    {
        OperationResult Create(CreateSlide command);
        OperationResult Edit(CreateSlide command);
        OperationResult Remove(long Id);
        OperationResult Restore(long Id);
        EditSlide GetDetails(long Id);
        List<SlideViewModel> GetList();
    }
}