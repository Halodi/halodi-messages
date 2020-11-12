using System.Text;
namespace sensor_msgs.msg
{


/**
       * This message holds a collection of 3d points, plus optional additional
       * information about each point.
       */
[System.Serializable]
public class PointCloud
{
   /**
            * Time of sensor data acquisition, coordinate frame ID.
            */
   public std_msgs.msg.Header header;
   /**
            * Array of 3d points. Each Point32 should be interpreted as a 3d point
            * in the frame given in the header.
            */
   public System.Collections.Generic.List<geometry_msgs.msg.Point32> points;
   /**
            * Each channel should have the same number of elements as points array,
            * and the data in each channel should correspond 1:1 with each point.
            * Channel names in common practice are listed in ChannelFloat32.msg.
            */
   public System.Collections.Generic.List<sensor_msgs.msg.ChannelFloat32> channels;


   public void Set(PointCloud other)
   {
      std_msgs.msg.HeaderPubSubType.Copy(other.header, header);


      if(other.points == null)
      {
      	points = null;
      }
      else
      {
      	points = new System.Collections.Generic.List<geometry_msgs.msg.Point32>(other.points.Count);
      	for(int i1 = 0; i1 < other.points.Count; i1++)
      	{
      		if(other.points[i1] == null)
      		{
      			points.Add(null);
      		}
      		else
      		{
      			geometry_msgs.msg.Point32 newElement = geometry_msgs.msg.Point32PubSubType.Create();
      	   		geometry_msgs.msg.Point32PubSubType.Copy(other.points[i1], newElement);
      	   		points.Add(newElement);
      		}	}
      }

      if(other.channels == null)
      {
      	channels = null;
      }
      else
      {
      	channels = new System.Collections.Generic.List<sensor_msgs.msg.ChannelFloat32>(other.channels.Count);
      	for(int i2 = 0; i2 < other.channels.Count; i2++)
      	{
      		if(other.channels[i2] == null)
      		{
      			channels.Add(null);
      		}
      		else
      		{
      			sensor_msgs.msg.ChannelFloat32 newElement = sensor_msgs.msg.ChannelFloat32PubSubType.Create();
      	   		sensor_msgs.msg.ChannelFloat32PubSubType.Copy(other.channels[i2], newElement);
      	   		channels.Add(newElement);
      		}	}
      }
   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("PointCloud {");
      builder.Append("header=");
      builder.Append(this.header);      builder.Append(", ");
      builder.Append("points=");
      builder.Append(this.points);      builder.Append(", ");
      builder.Append("channels=");
      builder.Append(this.channels);
      builder.Append("}");
      return builder.ToString();
   }
}


}