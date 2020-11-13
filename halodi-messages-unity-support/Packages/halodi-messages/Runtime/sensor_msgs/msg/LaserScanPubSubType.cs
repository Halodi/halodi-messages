using System.IO;
namespace sensor_msgs.msg
{

/**
* 
* Topic data type of the struct "LaserScan" defined in "LaserScan.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from LaserScan.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit LaserScan.idl instead.
*
*/
public class LaserScanPubSubType : Halodi.CDR.TopicDataType<LaserScan>
{
   public override string Name => "sensor_msgs::msg::dds_::LaserScan_";


   
   public override void serialize(sensor_msgs.msg.LaserScan data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, sensor_msgs.msg.LaserScan data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(sensor_msgs.msg.LaserScan data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(sensor_msgs.msg.LaserScan data, int current_alignment)
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
      current_alignment += (data.ranges.Count * 4) + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      current_alignment += (data.intensities.Count * 4) + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);



      return current_alignment - initial_alignment;
   }

   public static void write(sensor_msgs.msg.LaserScan data, Halodi.CDR.CDRSerializer cdr)
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
      			cdr.write_type_5(data.ranges[i0]);
            }
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
      			cdr.write_type_5(data.intensities[i0]);
            }
        }
   }

   public static void read(sensor_msgs.msg.LaserScan data, Halodi.CDR.CDRDeserializer cdr)
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
      data.ranges = new System.Collections.Generic.List<float>(ranges_length);
      for(int i = 0; i < ranges_length; i++)
      {
      	data.ranges.Add(cdr.read_type_5());
      	
      	
      }

      	

      int intensities_length = cdr.read_type_2();
      data.intensities = new System.Collections.Generic.List<float>(intensities_length);
      for(int i = 0; i < intensities_length; i++)
      {
      	data.intensities.Add(cdr.read_type_5());
      	
      	
      }

      	

   }


    public static void Copy(sensor_msgs.msg.LaserScan src, sensor_msgs.msg.LaserScan target)
    {
        target.Set(src);
    }


}


}