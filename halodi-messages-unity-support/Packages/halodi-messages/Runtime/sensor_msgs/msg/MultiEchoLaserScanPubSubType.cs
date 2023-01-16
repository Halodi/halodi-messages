using System.IO;
namespace sensor_msgs.msg
{

/**
* 
* Topic data type of the struct "MultiEchoLaserScan" defined in "MultiEchoLaserScan.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from MultiEchoLaserScan.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit MultiEchoLaserScan.idl instead.
*
*/
public class MultiEchoLaserScanPubSubType : Halodi.CDR.TopicDataType<MultiEchoLaserScan>
{
   public override string Name => "sensor_msgs::msg::dds_::MultiEchoLaserScan_";


   public static int getCdrSerializedSize(sensor_msgs.msg.MultiEchoLaserScan data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(sensor_msgs.msg.MultiEchoLaserScan data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += std_msgs.msg.HeaderPubSubType.getCdrSerializedSize(data.header, current_alignment);

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.ranges.Count; ++i0)
      {
          current_alignment += sensor_msgs.msg.LaserEchoPubSubType.getCdrSerializedSize(data.ranges[i0], current_alignment);}

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.intensities.Count; ++i0)
      {
          current_alignment += sensor_msgs.msg.LaserEchoPubSubType.getCdrSerializedSize(data.intensities[i0], current_alignment);}


      return current_alignment - initial_alignment;
   }

   public static void write(sensor_msgs.msg.MultiEchoLaserScan data, Halodi.CDR.CDRSerializer cdr)
   {
      std_msgs.msg.HeaderPubSubType.write(data.header, cdr);

      cdr.write_type_5(data.angle_min);

      cdr.write_type_5(data.angle_max);

      cdr.write_type_5(data.angle_increment);

      cdr.write_type_5(data.time_increment);

      cdr.write_type_5(data.scan_time);

      cdr.write_type_5(data.range_min);

      cdr.write_type_5(data.range_max);

      	if(data.ranges == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int ranges_length = data.ranges.Count;
            cdr.write_type_2(ranges_length);
            for (int i0 = 0; i0 < ranges_length; i0++)
            {
      			sensor_msgs.msg.LaserEchoPubSubType.write(data.ranges[i0], cdr);	      }
        }
      	if(data.intensities == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int intensities_length = data.intensities.Count;
            cdr.write_type_2(intensities_length);
            for (int i0 = 0; i0 < intensities_length; i0++)
            {
      			sensor_msgs.msg.LaserEchoPubSubType.write(data.intensities[i0], cdr);	      }
        }
   }

   public static void read(sensor_msgs.msg.MultiEchoLaserScan data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.header = std_msgs.msg.HeaderPubSubType.Create();
      std_msgs.msg.HeaderPubSubType.read(data.header, cdr);
      	
      data.angle_min=cdr.read_type_5();
      	
      data.angle_max=cdr.read_type_5();
      	
      data.angle_increment=cdr.read_type_5();
      	
      data.time_increment=cdr.read_type_5();
      	
      data.scan_time=cdr.read_type_5();
      	
      data.range_min=cdr.read_type_5();
      	
      data.range_max=cdr.read_type_5();
      	

      int ranges_length = cdr.read_type_2();
      data.ranges = new System.Collections.Generic.List<sensor_msgs.msg.LaserEcho>(ranges_length);
      for(int i = 0; i < ranges_length; i++)
      {
      	sensor_msgs.msg.LaserEcho new_ranges = sensor_msgs.msg.LaserEchoPubSubType.Create(); 
      	sensor_msgs.msg.LaserEchoPubSubType.read(new_ranges, cdr);
      	data.ranges.Add(new_ranges);	
      	
      }

      	

      int intensities_length = cdr.read_type_2();
      data.intensities = new System.Collections.Generic.List<sensor_msgs.msg.LaserEcho>(intensities_length);
      for(int i = 0; i < intensities_length; i++)
      {
      	sensor_msgs.msg.LaserEcho new_intensities = sensor_msgs.msg.LaserEchoPubSubType.Create(); 
      	sensor_msgs.msg.LaserEchoPubSubType.read(new_intensities, cdr);
      	data.intensities.Add(new_intensities);	
      	
      }

      	

   }


	public override void Serialize(sensor_msgs.msg.MultiEchoLaserScan data, Halodi.CDR.CDRSerializer cdr)
   	{
   		write(data, cdr);	
   	}

	public override void Deserialize(sensor_msgs.msg.MultiEchoLaserScan data, Halodi.CDR.CDRDeserializer cdr)
   	{
   		read(data, cdr);	
   	}
   	
   	public override int GetSize(sensor_msgs.msg.MultiEchoLaserScan data)
   	{
   		return getCdrSerializedSize(data);
   	}

    public static void Copy(sensor_msgs.msg.MultiEchoLaserScan src, sensor_msgs.msg.MultiEchoLaserScan target)
    {
        target.Set(src);
    }
    
    public override void CopyTo(sensor_msgs.msg.MultiEchoLaserScan src, sensor_msgs.msg.MultiEchoLaserScan target)
    {
    	Copy(src, target);
    }


}


}