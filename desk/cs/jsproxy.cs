using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace desk.cs
{
   public  class jsproxy
    {
      public async static Task<Root> getjsstring ()
        {
            var http = new HttpClient();
            var response = await http.GetAsync("https://yande.re/post.json?limit=3");
            var result = await response.Content.ReadAsStringAsync();

            //序列化
            var serializer = new DataContractJsonSerializer(typeof(Root));
            var ms = new MemoryStream(Encoding.UTF8.GetBytes(result));
            var data = (Root)serializer.ReadObject(ms);
            return data;
           
        }
    }

    [DataContract]
    public class getjs
    {
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public int[] id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string[] tags { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public int[] created_at { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public int[] updated_at { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public int[] creator_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string[] approver_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string[] author { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public int[] change { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string[] source { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public int[] score { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string[] md5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public int[] file_size { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string[] file_ext { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string[] file_url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string[] is_shown_in_index { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string[] preview_url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public int[] preview_width { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public int[] preview_height { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public int[] actual_preview_width { get; set; }
        /// <summary>
        /// 
        /// </summary>

        [DataMember]
        public int[] actual_preview_height { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string[] sample_url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public int[] sample_width { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public int[] sample_height { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public int[] sample_file_size { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string []jpeg_url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public int[] jpeg_width { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public int[] jpeg_height { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public int[] jpeg_file_size { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string[] rating { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string[] is_rating_locked { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string[] has_children { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string[] parent_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string[] status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string[] is_pending { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public int[] width { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public int[] height { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string is_held { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string[] frames_pending_string { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public List<string> frames_pending { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string[] frames_string { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public List<string> frames { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string[] is_note_locked { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public int []last_noted_at { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public int[] last_commented_at { get; set; }
    }
    
    [DataContract]
    public class Root
    {
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public getjs[] Rootgetjs { get; set; }
    }
}
