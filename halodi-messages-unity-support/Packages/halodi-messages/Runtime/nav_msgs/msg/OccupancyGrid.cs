using System.Text;
namespace nav_msgs.msg
{


/**
       * This represents a 2-D grid map, in which each cell represents the probability of occupancy.
       */
[System.Serializable]
public class OccupancyGrid
{
   public std_msgs.msg.Header header;
   /**
            * MetaData for the map
            */
   public nav_msgs.msg.MapMetaData info;
   /**
            * The map data, in row-major order, starting with (0,0).  Occupancy
            * probabilities are in the range [0,100].  Unknown is -1.
            */
   public System.Collections.Generic.List<byte> data;


   public void Set(OccupancyGrid other)
   {
      std_msgs.msg.HeaderPubSubType.Copy(other.header, header);

      nav_msgs.msg.MapMetaDataPubSubType.Copy(other.info, info);


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

      builder.Append("OccupancyGrid {");
      builder.Append("header=");
      builder.Append(this.header);      builder.Append(", ");
      builder.Append("info=");
      builder.Append(this.info);      builder.Append(", ");
      builder.Append("data=");
      builder.Append(this.data);
      builder.Append("}");
      return builder.ToString();
   }
}


}