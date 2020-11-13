using System.Text;
namespace sensor_msgs.msg
{


/**
       * This message is used by the PointCloud message to hold optional data
       * associated with each point in the cloud. The length of the values
       * array should be the same as the length of the points array in the
       * PointCloud, and each value should be associated with the corresponding
       * point.
       * 
       * Channel names in existing practice include:
       * "u", "v" - row and column (respectively) in the left stereo image.
       * This is opposite to usual conventions but remains for
       * historical reasons. The newer PointCloud2 message has no
       * such problem.
       * "rgb" - For point clouds produced by color stereo cameras. uint8
       * (R,G,B) values packed into the least significant 24 bits,
       * in order.
       * "intensity" - laser or pixel intensity.
       * "distance"
       */
[System.Serializable]
public class ChannelFloat32 : Halodi.CDR.DataType<ChannelFloat32>
{

	public Halodi.CDR.TopicDataType<ChannelFloat32> Type => new ChannelFloat32PubSubType();
	
   /**
            * The channel name should give semantics of the channel (e.g.
            * "intensity" instead of "value").
            */
   public string name;
   /**
            * The values array should be 1-1 with the elements of the associated
            * PointCloud.
            */
   public System.Collections.Generic.List<float> values;


   public void Set(ChannelFloat32 other)
   {
      name = other.name;


      if(other.values == null)
      {
      	values = null;
      }
      else
      {
      	values = new System.Collections.Generic.List<float>(other.values.Count);
      	for(int i1 = 0; i1 < other.values.Count; i1++)
      	{
         		values.Add(other.values[i1]);
      	}
      }
   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("ChannelFloat32 {");
      builder.Append("name=");
      builder.Append(this.name);      builder.Append(", ");
      builder.Append("values=");
      builder.Append(this.values);
      builder.Append("}");
      return builder.ToString();
   }
}


}