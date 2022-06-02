﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _0_Framework.Application;
using ShopManagement.Application.Contracts.Slide;
using ShopManagement.Domain.SlideAgg;

namespace ShopManagement.Application
{
    public class SlideApplication : ISlideApplication

    {
        private readonly IFileUploader _fileUploader;
        private readonly ISlideRepository _slideRepository;

        public SlideApplication(ISlideRepository slideRepository, IFileUploader fileUploader)
        {
            _slideRepository = slideRepository;
            _fileUploader = fileUploader;
        }

        public OperationResult Create(CreateSlide command)
        {
            var operation = new OperationResult();
            var pictureName = _fileUploader.Upload(command.Picture, "slides");
            var slide = new Slide(pictureName, command.PictureAlt,command.PictureTitle,
                command.Heading,command.Title,command.Text,command.BtnText ,command.Link);
            _slideRepository.Create(slide); 
            _slideRepository.SaveChanges();
            return operation.Succedded();
        }

        public OperationResult Edit(EditSlide command)
        {
            var operation=new OperationResult();
            var slide = _slideRepository.Get(command.Id);
            if (slide == null)
                return operation.Failed(ApplicationMessages.RecordNotFound);

            var pictureName = _fileUploader.Upload(command.Picture, "slides");

            slide.Edit(pictureName, command.PictureAlt, command.PictureTitle,
                command.Heading, command.Title, command.Text, command.Link, command.BtnText);
            _slideRepository.SaveChanges();
            return operation.Succedded();
        }

        public EditSlide GetDetails(long Id)
        {
            return _slideRepository.GetDetails(Id);
        }

        public List<SlideViewModel> GetList()
        {
            return _slideRepository.GetList();
        }

        public OperationResult Remove(long Id)
        {
            var operation = new OperationResult();
            var slide = _slideRepository.Get(Id);
            if (slide == null)
                return operation.Failed(ApplicationMessages.RecordNotFound);

            slide.Remove();
            _slideRepository.SaveChanges();
            return operation.Succedded();
        }

        public OperationResult Restore(long Id)
        {
            var operation = new OperationResult();
            var slide = _slideRepository.Get(Id);
            if (slide == null)
                return operation.Failed(ApplicationMessages.RecordNotFound);

            slide.Restore();
            _slideRepository.SaveChanges();
            return operation.Succedded();
        }
    }
}
