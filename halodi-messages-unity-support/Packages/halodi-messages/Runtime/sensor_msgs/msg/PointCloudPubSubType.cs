using System.IO;
namespace sensor_msgs.msg
{

/**
* 
* Topic data type of the struct "PointCloud" defined in "PointCloud.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from PointCloud.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit PointCloud.idl instead.
*
*/
public class PointCloudPubSubType : Halodi.CDR.TopicDataType<PointCloud>
{
   public override string Name => "sensor_msgs::msg::dds_::PointCloud_";


   public static int getCdrSerializedSize(sensor_msgs.msg.PointCloud data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(sensor_msgs.msg.PointCloud data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += std_msgs.msg.HeaderPubSubType.getCdrSerializedSize(data.header, current_alignment);

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.points.Count; ++i0)
      {
          current_alignment += geometry_msgs.msg.Point32PubSubType.getCdrSerializedSize(data.points[i0], current_alignment);}

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.channels.Count; ++i0)
      {
          current_alignment += sensor_msgs.msg.ChannelFloat32PubSubType.getCdrSerializedSize(data.channels[i0], current_alignment);}


      return current_alignment - initial_alignment;
   }

   public static void write(sensor_msgs.msg.PointCloud data, Halodi.CDR.CDRSerializer cdr)
   {
      std_msgs.msg.HeaderPubSubType.write(data.header, cdr);

      	if(data.points == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int points_length = data.points.Count;
            cdr.write_type_2(points_length);
            for (int i0 = 0; i0 < points_length; i0++)
            {
      			geometry_msgs.msg.Point32PubSubType.write(data.points[i0], cdr);	      }
        }
      	if(data.channels == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int channels_length = data.channels.Count;
            cdr.write_type_2(channels_length);
            for (int i0 = 0; i0 < channels_length; i0++)
            {
      			sensor_msgs.msg.ChannelFloat32PubSubType.write(data.channels[i0], cdr);	      }
        }
   }

   public static void read(sensor_msgs.msg.PointCloud data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.header = std_msgs.msg.HeaderPubSubType.Create();
      std_msgs.msg.HeaderPubSubType.read(data.header, cdr);
      	

      int points_length = cdr.read_type_2();
      data.points = new System.Collections.Generic.List<geometry_msgs.msg.Point32>(points_length);
      for(int i = 0; i < points_length; i++)
      {
      	geometry_msgs.msg.Point32 new_points = geometry_msgs.msg.Point32PubSubType.Create(); 
      	geometry_msgs.msg.Point32PubSubType.read(new_points, cdr);
      	data.points.Add(new_points);	
      	
      }

      	

      int channels_length = cdr.read_type_2();
      data.channels = new System.Collections.Generic.List<sensor_msgs.msg.ChannelFloat32>(channels_length);
      for(int i = 0; i < channels_length; i++)
      {
      	sensor_msgs.msg.ChannelFloat32 new_channels = sensor_msgs.msg.ChannelFloat32PubSubType.Create(); 
      	sensor_msgs.msg.ChannelFloat32PubSubType.read(new_channels, cdr);
      	data.channels.Add(new_channels);	
      	
      }

      	

   }


	public override void Serialize(sensor_msgs.msg.PointCloud data, Halodi.CDR.CDRSerializer cdr)
   	{
   		write(data, cdr);	
   	}

	public override void Deserialize(sensor_msgs.msg.PointCloud data, Halodi.CDR.CDRDeserializer cdr)
   	{
   		read(data, cdr);	
   	}
   	
   	public override int GetSize(sensor_msgs.msg.PointCloud data)
   	{
   		return getCdrSerializedSize(data);
   	}

    public static void Copy(sensor_msgs.msg.PointCloud src, sensor_msgs.msg.PointCloud target)
    {
        target.Set(src);
    }
    
    public override void CopyTo(sensor_msgs.msg.PointCloud src, sensor_msgs.msg.PointCloud target)
    {
    	Copy(src, target);
    }


}


}