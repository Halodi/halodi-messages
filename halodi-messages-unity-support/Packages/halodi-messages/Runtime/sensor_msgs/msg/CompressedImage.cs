using System.Text;
namespace sensor_msgs.msg
{


/**
       * This message contains a compressed image.
       * Header frame_id should be optical frame of camera
       * origin of frame should be optical center of cameara
       * +x should point to the right in the image
       * +y should point down in the image
       * +z should point into to plane of the image
       * Acceptable values:
       * jpeg, png
       */
[System.Serializable]
public class CompressedImage
{
   /**
            * Header timestamp should be acquisition time of image
            */
   public std_msgs.msg.Header header;
   /**
            * Specifies the format of the data
            */
   public string format;
   /**
            * Compressed image buffer
            */
   public System.Collections.Generic.List<byte> data;


   public void Set(CompressedImage other)
   {
      std_msgs.msg.HeaderPubSubType.Copy(other.header, header);

      format = other.format;


      if(other.data == null)
      {
      	data = null;
      }
      else
      {
      	data = new System.Collections.Generic.List<byte>(other.data.Count);
      	for(int i1 = 0; i1 < other.data.Count; i1++)
      	{
         		data.Add(other.data[i1]);
      	}
      }
   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("CompressedImage {");
      builder.Append("header=");
      builder.Append(this.header);      builder.Append(", ");
      builder.Append("format=");
      builder.Append(this.format);      builder.Append(", ");
      builder.Append("data=");
      builder.Append(this.data);
      builder.Append("}");
      return builder.ToString();
   }
}


}