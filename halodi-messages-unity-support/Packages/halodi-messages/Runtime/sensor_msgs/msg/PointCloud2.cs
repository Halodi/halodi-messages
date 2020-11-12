using System.Text;
namespace sensor_msgs.msg
{


/**
       * This message holds a collection of N-dimensional points, which may
       * contain additional information such as normals, intensity, etc. The
       * point data is stored as a binary blob, its layout described by the
       * contents of the "fields" array.
       * 
       * The point cloud data may be organized 2d (image-like) or 1d (unordered).
       * Point clouds organized as 2d images may be produced by camera depth sensors
       * such as stereo or time-of-flight.
       */
[System.Serializable]
public class PointCloud2
{
   /**
            * Time of sensor data acquisition, and the coordinate frame ID (for 3d points).
            */
   public std_msgs.msg.Header header;
   /**
            * 2D structure of the point cloud. If the cloud is unordered, height is
            * 1 and width is the length of the point cloud.
            */
   public uint height;
   public uint width;
   /**
            * Describes the channels and their layout in the binary data blob.
            */
   public System.Collections.Generic.List<sensor_msgs.msg.PointField> fields;
   /**
            * Is this data bigendian?
            */
   public bool is_bigendian;
   /**
            * Length of a point in bytes
            */
   public uint point_step;
   /**
            * Length of a row in bytes
            */
   public uint row_step;
   /**
            * Actual point data, size is (row_step*height)
            */
   public System.Collections.Generic.List<byte> data;
   /**
            * True if there are no invalid points
            */
   public bool is_dense;


   public void Set(PointCloud2 other)
   {
      std_msgs.msg.HeaderPubSubType.Copy(other.header, header);

      height = other.height;

      width = other.width;


      if(other.fields == null)
      {
      	fields = null;
      }
      else
      {
      	fields = new System.Collections.Generic.List<sensor_msgs.msg.PointField>(other.fields.Count);
      	for(int i1 = 0; i1 < other.fields.Count; i1++)
      	{
      		if(other.fields[i1] == null)
      		{
      			fields.Add(null);
      		}
      		else
      		{
      			sensor_msgs.msg.PointField newElement = sensor_msgs.msg.PointFieldPubSubType.Create();
      	   		sensor_msgs.msg.PointFieldPubSubType.Copy(other.fields[i1], newElement);
      	   		fields.Add(newElement);
      		}	}
      }
      is_bigendian = other.is_bigendian;

      point_step = other.point_step;

      row_step = other.row_step;


      if(other.data == null)
      {
      	data = null;
      }
      else
      {
      	data = new System.Collections.Generic.List<byte>(other.data.Count);
      	for(int i2 = 0; i2 < other.data.Count; i2++)
      	{
         		data.Add(other.data[i2]);
      	}
      }
      is_dense = other.is_dense;

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("PointCloud2 {");
      builder.Append("header=");
      builder.Append(this.header);      builder.Append(", ");
      builder.Append("height=");
      builder.Append(this.height);      builder.Append(", ");
      builder.Append("width=");
      builder.Append(this.width);      builder.Append(", ");
      builder.Append("fields=");
      builder.Append(this.fields);      builder.Append(", ");
      builder.Append("is_bigendian=");
      builder.Append(this.is_bigendian);      builder.Append(", ");
      builder.Append("point_step=");
      builder.Append(this.point_step);      builder.Append(", ");
      builder.Append("row_step=");
      builder.Append(this.row_step);      builder.Append(", ");
      builder.Append("data=");
      builder.Append(this.data);      builder.Append(", ");
      builder.Append("is_dense=");
      builder.Append(this.is_dense);
      builder.Append("}");
      return builder.ToString();
   }
}


}