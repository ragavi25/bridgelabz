// --------------------------------------------------------------------------------------------------------------------
// <copyright file=NotesController.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="R Ragavi"/>
// --------------------------------------------------------------------------------------------------------------------
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Http;

using Model.Model.NodesModel;
using Repository.Context;
using Repository.RepositoryInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Repository.RepositoryImpl
{
    /// <summary>
    /// Purpose:Implementation of Note Repository.
    /// </summary>
    public class NotesRep : INotes
    {
        /// <summary>
        /// Purpose:This Repository using UserContext for the affected the database.
        /// </summary>
        private readonly UserContext context;
        public NotesRep(UserContext userContext)
        {
            context = userContext;
        }
        /// <summary>
        /// Purpose:create the Addnote using note model.
        /// </summary>
        /// <param name="notes"></param>
        /// <returns></returns>
        public  Task AddNotes(Nodes notes)
        {
            Nodes note = new Nodes()
            {
                NodeId = notes.NodeId,
                Email = notes.Email,
                Tittle = notes.Tittle,
                Description = notes.Description,
                Createdate1 = notes.Createdate1,
                Modifieddate = notes.Modifieddate,
                Archive = notes.Archive,
                Pin = notes.Pin,
                ChangeColor = notes.ChangeColor,
                AddImg = notes.AddImg,
                //Reminder=notes.Reminder,
                //Bin=notes.Bin,

            };
            
            this.context.Nodes.Add(note);
           var s=  Task.Run(() => context.SaveChanges());
            return s;
        } 
        /// <summary>
        /// purpose:create the DeleteNote using the id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task Delete(int id)
        {
            var result = this.context.Nodes.Where(op => op.NodeId == id).FirstOrDefault();
            if (result != null)
            {
                this.context.Nodes.Remove(result);
            }
            await Task.Run(() => context.SaveChanges());
        }
        /// <summary>
        /// Purpose:Create the GetNote using all the note list.
        /// </summary>
        /// <returns></returns>
        public List<Nodes> GetNotes()
        {
            return this.context.Nodes.ToList();
        }
        /// <summary>
        /// purpose:Create the GetNote using get the specific note list.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<Nodes> GetNote(int id)
        {
            var result = this.context.Nodes.Where(op => op.NodeId == id).SingleOrDefault();
            if (result != null)
            {
                var a = this.context.Nodes.ToList();
                Task.Run(() => context.SaveChanges());
            }
            return null;
        }
        /// <summary>
        /// Purpose:create the Update note using specific part of note upadated.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="tittle"></param>
        /// <param name="Decription"></param>
        /// <param name="color"></param>
        /// <param name="img"></param>
        /// <returns></returns>
        public Task Update(int id, string tittle, string Decription, string color, string img)
        {
            var result = this.context.Nodes.Where(op => op.NodeId == id).SingleOrDefault();
            if (result != null)
            {
                result.Tittle = tittle;
                result.Description = Decription;
                result.ChangeColor = color;
                result.AddImg = img;
                this.context.Nodes.Update(result);
                return Task.Run(() => context.SaveChanges());
            }
            return default;
        }
        /// <summary>
        /// Purpose:Create a UploadImages.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="img"></param>
        /// <returns></returns>
        public async Task<string> UploadImg(int id, string img)
        {
           // var stream = img.OpenReadStream();
            var Filename = img;
            Account account = new Account("dxizbs2aq", "572583872924614", "572583872924614");
            Cloudinary cloudinary = new Cloudinary(account);
            var UploadFile = new ImageUploadParams() { File = new FileDescription(Filename) };
            var Result = cloudinary.Upload(UploadFile);
            var file = this.context.Nodes.Where(op => op.NodeId == id).SingleOrDefault();
            file.AddImg = Result.Uri.ToString();
            try
            {
                var res = this.context.Update(file.AddImg);
                await Task.Run(() => context.SaveChanges());
                return file.AddImg;
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        /// <summary>
        /// Purpose:Create a Change colors.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="color"></param>
        /// <returns></returns>
        public async Task<string> Color(int id, string color)
        {
            var result = this.context.Nodes.Where(op => op.NodeId == id).SingleOrDefault();
            if (result != null)
            {
                result.ChangeColor = color;
                this.context.Nodes.Update(result);
                await Task.Run(() => this.context.SaveChanges());
            }
            return default;
        }
        /// <summary>
        /// Purpose:Create a pin is ture.so pinned the note.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<bool> Ispin(int id)
        {
            var result = this.context.Nodes.Where(op => op.NodeId == id).SingleOrDefault();
            if (result != null)
            {
                result.Pin = true;
                this.context.Nodes.Update(result);
                await Task.Run(() => this.context.SaveChanges());
            }
            return default;
        }
        /// <summary>
        /// Purpose:Create a unpin .
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<bool> Unpin(int id)
        {
            var result = this.context.Nodes.Where(op => op.NodeId == id).SingleOrDefault();
            if (result != null)
            {
                result.Pin = false;
                this.context.Nodes.Update(result);
                await Task.Run(() => this.context.SaveChanges());
            }
            return default;
        }
        /// <summary>
        /// Purpose:Create a Archive.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<bool> IsArchive(int id)
        {
            var result = this.context.Nodes.Where(op => op.NodeId == id).SingleOrDefault();
            if (result != null)
            {
                result.Archive = true;
                this.context.Nodes.Update(result);
                await Task.Run(() => this.context.SaveChanges());
            }
            return default;
        }
        /// <summary>
        /// Purpose:Create a UnArchive.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<bool> UnArchive(int id)
        {
            var result = this.context.Nodes.Where(op => op.NodeId == id && op.Archive == true).SingleOrDefault();
            if (result != null)
            {
                result.Archive = false;
                this.context.Nodes.Update(result);
                await Task.Run(() => this.context.SaveChanges());
            }
            return default;
        }
        /// <summary>
        /// Purpose:Create a Reminder.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="Reminder"></param>
        /// <returns></returns>
        public async Task<int> Reminder(int id, string Reminder)
        {
            var result = this.context.Nodes.Where(OP => OP.NodeId == id).SingleOrDefault();
            if (result != null)
            {
                result.Reminder = Reminder.ToString();
                await Task.Run(() => this.context.SaveChanges());
            }
            return default;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Nodes> GetArchive()
        {
            var a = this.context.Nodes.Where(op => op.Archive == true).SingleOrDefault();
            if(a!=null)
            {
                this.context.Nodes.ToList();
              //var s=Task.Run(() => context.SaveChanges());
                
            }
            return default;
        }
        /// <summary>
        /// Purpose:Create a Bin.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<bool> IsBin(int id)
        {
            var result = this.context.Nodes.Where(op => op.NodeId == id).SingleOrDefault();
            if(result!=null)
            {
                result.Bin = true;
                this.context.Nodes.Update(result);
                await Task.Run(()=>this.context.SaveChanges());
            }
            return default;
        }
        /// <summary>
        /// Purpose:Create a GetBin List.
        /// </summary>
        /// <returns></returns>
        public List<Nodes> GetBin()
        {
            var result = this.context.Nodes.Where(op => op.Bin == true).SingleOrDefault();
            if(result!=null)
            {
                this.context.Nodes.ToList();
                Task.Run(() => context.SaveChanges());
            }
            return default;
        }
        /// <summary>
        /// Purpose:Create a Restore the note.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<string> Restore(int id)
        {
            var data = this.context.Nodes.Where(op => op.NodeId == id && op.Bin == true).SingleOrDefault();
            if(data!=null)
            {
                data.Bin = false;
                await Task.Run(() => context.SaveChanges());
            }
            return default;
        }
    }
}

