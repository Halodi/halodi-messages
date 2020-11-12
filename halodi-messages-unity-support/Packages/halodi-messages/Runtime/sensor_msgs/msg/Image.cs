using System.Text;
namespace sensor_msgs.msg
{


/**
       * This message contains an uncompressed image
       * (0, 0) is at top-left corner of image
       * Header frame_id should be optical frame of camera
       * origin of frame should be optical center of cameara
       * +x should point to the right in the image
       * +y should point down in the image
       * +z should point into to plane of the image
       * If the frame_id here and the frame_id of the CameraInfo
       * message associated with the image conflict
       * the behavior is undefined
       * The legal values for encoding are in file src/image_encodings.cpp
       * If you want to standardize a new string format, join
       * ros-users@lists.ros.org and send an email proposing a new encoding.
       * taken from the list of strings in include/sensor_msgs/image_encodings.hpp
       */
[System.Serializable]
public class Image
{
   /**
            * Header timestamp should be acquisition time of image
            */
   public std_msgs.msg.Header header;
   /**
            * image height, that is, number of rows
            */
   public uint height;
   /**
            * image width, that is, number of columns
            */
   public uint width;
   /**
            * Encoding of pixels -- channel meaning, ordering, size
            */
   public string encoding;
   /**
            * is this data bigendian?
            */
   public byte is_bigendian;
   /**
            * Full row length in bytes
            */
   public uint step;
   /**
            * actual matrix data, size is (step * rows)
            */
   public System.Collections.Generic.List<byte> data;


   public void Set(Image other)
   {
      std_msgs.msg.HeaderPubSubType.Copy(other.header, header);

      height = other.height;

      width = other.width;

      encoding = other.encoding;

      is_bigendian = other.is_bigendian;

      step = other.step;


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

      builder.Append("Image {");
      builder.Append("header=");
      builder.Append(this.header);      builder.Append(", ");
      builder.Append("height=");
      builder.Append(this.height);      builder.Append(", ");
      builder.Append("width=");
      builder.Append(this.width);      builder.Append(", ");
      builder.Append("encoding=");
      builder.Append(this.encoding);      builder.Append(", ");
      builder.Append("is_bigendian=");
      builder.Append(this.is_bigendian);      builder.Append(", ");
      builder.Append("step=");
      builder.Append(this.step);      builder.Append(", ");
      builder.Append("data=");
      builder.Append(this.data);
      builder.Append("}");
      return builder.ToString();
   }
}


}