using System;
using System.Collections.Generic;
using System.Text;

namespace MediaCodec
{
    abstract class Media
    {
        private string fileName;
        private int id;
        private static int nextId = 0;

        public Media()
        {
            this.fileName = "";
            this.id = nextId;
            nextId++;
        }

        public Media(string fileName)
        {
            this.fileName = fileName;
            this.id = nextId;
            nextId++;
        }

        public string getFileName()
        {
            return fileName;
        }

        public int getId()
        {
            return id;
        }

        public virtual string getMediaInfo()
        {
            return "File ID: " + id + "\nFile Name: " + fileName;
        }
        
    }
}