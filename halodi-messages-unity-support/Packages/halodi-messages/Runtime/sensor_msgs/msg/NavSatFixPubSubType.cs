using System.IO;
namespace sensor_msgs.msg
{

/**
* 
* Topic data type of the struct "NavSatFix" defined in "NavSatFix.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from NavSatFix.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit NavSatFix.idl instead.
*
*/
public class NavSatFixPubSubType : Halodi.CDR.TopicDataType<NavSatFix>
{
   public override string Name => "sensor_msgs::msg::dds_::NavSatFix_";


   
   public override void serialize(sensor_msgs.msg.NavSatFix data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, sensor_msgs.msg.NavSatFix data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(sensor_msgs.msg.NavSatFix data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(sensor_msgs.msg.NavSatFix data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += std_msgs.msg.HeaderPubSubType.getCdrSerializedSize(data.header, current_alignment);

      current_alignment += sensor_msgs.msg.NavSatStatusPubSubType.getCdrSerializedSize(data.status, current_alignment);

      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += ((9) * 8) + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);
      current_alignment += 1 + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);



      return current_alignment - initial_alignment;
   }

   public static void write(sensor_msgs.msg.NavSatFix data, Halodi.CDR.CDRSerializer cdr)
   {
      std_msgs.msg.HeaderPubSubType.write(data.header, cdr);

      sensor_msgs.msg.NavSatStatusPubSubType.write(data.status, cdr);

      cdr.write_type_6(data.latitude);

      cdr.write_type_6(data.longitude);

      cdr.write_type_6(data.altitude);

      for(int i0 = 0; i0 < 9; ++i0)
      {
        	cdr.write_type_6(data.position_covariance[i0]);	
      }

      cdr.write_type_9(data.position_covariance_type);

   }

   public static void read(sensor_msgs.msg.NavSatFix data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.header = std_msgs.msg.HeaderPubSubType.Create();
      std_msgs.msg.HeaderPubSubType.read(data.header, cdr);
      	
      data.status = sensor_msgs.msg.NavSatStatusPubSubType.Create();
      sensor_msgs.msg.NavSatStatusPubSubType.read(data.status, cdr);
      	
      data.latitude=cdr.read_type_6();
      	
      data.longitude=cdr.read_type_6();
      	
      data.altitude=cdr.read_type_6();
      	
      for(int i0 = 0; i0 < 9; ++i0)
      {
        	data.position_covariance[i0] = cdr.read_type_6();
        	
      }
      	
      data.position_covariance_type=cdr.read_type_9();
      	

   }


    public static void Copy(sensor_msgs.msg.NavSatFix src, sensor_msgs.msg.NavSatFix target)
    {
        target.Set(src);
    }


}


}