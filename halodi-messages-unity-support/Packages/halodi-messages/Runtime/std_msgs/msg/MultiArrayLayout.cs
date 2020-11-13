using System.Text;
namespace std_msgs.msg
{


/**
       * The multiarray declares a generic multi-dimensional array of a
       * particular data type.  Dimensions are ordered from outer most
       * to inner most.
       * 
       * Accessors should ALWAYS be written in terms of dimension stride
       * and specified outer-most dimension first.
       * 
       * multiarray(i,j,k) = data[data_offset + dim_stride[1]*i + dim_stride[2]*j + k]
       * 
       * A standard, 3-channel 640x480 image with interleaved color channels
       * would be specified as:
       * 
       * dim[0].label  = "height"
       * dim[0].size   = 480
       * dim[0].stride = 3*640*480 = 921600  (note dim[0] stride is just size of image)
       * dim[1].label  = "width"
       * dim[1].size   = 640
       * dim[1].stride = 3*640 = 1920
       * dim[2].label  = "channel"
       * dim[2].size   = 3
       * dim[2].stride = 3
       * 
       * multiarray(i,j,k) refers to the ith row, jth column, and kth channel.
       */
[System.Serializable]
public class MultiArrayLayout : Halodi.CDR.DataType<MultiArrayLayout>
{

	public Halodi.CDR.TopicDataType<MultiArrayLayout> Type => new MultiArrayLayoutPubSubType();
	
   /**
            * Array of dimension properties
            */
   public System.Collections.Generic.List<std_msgs.msg.MultiArrayDimension> dim;
   /**
            * padding bytes at front of data
            */
   public uint data_offset;


   public void Set(MultiArrayLayout other)
   {

      if(other.dim == null)
      {
      	dim = null;
      }
      else
      {
      	dim = new System.Collections.Generic.List<std_msgs.msg.MultiArrayDimension>(other.dim.Count);
      	for(int i1 = 0; i1 < other.dim.Count; i1++)
      	{
      		if(other.dim[i1] == null)
      		{
      			dim.Add(null);
      		}
      		else
      		{
      			std_msgs.msg.MultiArrayDimension newElement = std_msgs.msg.MultiArrayDimensionPubSubType.Create();
      	   		std_msgs.msg.MultiArrayDimensionPubSubType.Copy(other.dim[i1], newElement);
      	   		dim.Add(newElement);
      		}	}
      }
      data_offset = other.data_offset;

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("MultiArrayLayout {");
      builder.Append("dim=");
      builder.Append(this.dim);      builder.Append(", ");
      builder.Append("data_offset=");
      builder.Append(this.data_offset);
      builder.Append("}");
      return builder.ToString();
   }
}


}