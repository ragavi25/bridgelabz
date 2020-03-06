using Model.Model.NodesModel;
using Repository.Context;
using Repository.RepositoryInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.RepositoryImpl
{
    public class NotesImpl : INotes
    {
        private readonly UserContext context;
        public NotesImpl(UserContext user)
        {
            context = user;
        }
        public Task AddNotes(Nodes notes)
        {
            Nodes note = new Nodes()
            {
                NodeId = notes.NodeId,
                Tittle = notes.Tittle,
                Description = notes.Description,
                Createdate1 = notes.Createdate1,
                Modifieddate = notes.Modifieddate,
                Archive=notes.Archive,
                Pin=notes.Pin,
                ChangeColor=notes.ChangeColor,
                AddImg=notes.AddImg,

            };
           this.context.Nodes.Add(note);
            return  Task.Run(() => context.SaveChanges());
        }

        public Task Delete(int id)
        {
            var result = this.context.Nodes.Where(op => op.NodeId == id).FirstOrDefault();
            if(result!=null)
            {
                this.context.Nodes.Remove(result); 
            }
            return Task.Run(() => context.SaveChanges());

        }

        public  List<Nodes> GetNotes()
        {
            return  this.context.Nodes.ToList();
        }

        public List<Nodes> GetNote(int id)
        {
            var result = this.context.Nodes.Where(op => op.NodeId == id).SingleOrDefault();
            if(result!=null)
            {
               var a= this.context.Nodes.ToList();
                Task.Run(() => context.SaveChanges());
            }
            return null;


        }

        public Task Update(int id, string tittle, string Decription,string color,string img)
        {

            var result = this.context.Nodes.Where(op => op.NodeId == id).SingleOrDefault();
            if(result != null)
            {

                //Nodes notes = new Nodes()
                //{
                //    Tittle = result.Tittle,
                //    Description = result.Description,
                //    Modifieddate = result.Modifieddate,
                //    ChangeColor=result.ChangeColor,
                //    AddImg=result.AddImg,
                //};
                result.Tittle = tittle;
                result.Description = Decription;
                result.ChangeColor = color;
                result.AddImg = img;
                //var result1 = this.context.Nodes.Find(id);
                //this.context.
                ////this.context.Nodes.Update(result);
                var res = Task.Run(() => context.SaveChanges());
                return res;
            }
            return default;
            
        }
    }
}
