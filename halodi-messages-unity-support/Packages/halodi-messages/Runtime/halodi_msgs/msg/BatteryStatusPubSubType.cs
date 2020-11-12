using System.IO;
namespace halodi_msgs.msg
{

/**
* 
* Topic data type of the struct "BatteryStatus" defined in "BatteryStatus.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from BatteryStatus.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit BatteryStatus.idl instead.
*
*/
public class BatteryStatusPubSubType : Halodi.CDR.TopicDataType<halodi_msgs.msg.BatteryStatus>
{
   public override string Name => "halodi_msgs::msg::dds_::Battery_";


   
   public override void serialize(halodi_msgs.msg.BatteryStatus data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, halodi_msgs.msg.BatteryStatus data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(halodi_msgs.msg.BatteryStatus data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(halodi_msgs.msg.BatteryStatus data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 1 + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);


      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);



      return current_alignment - initial_alignment;
   }

   public static void write(halodi_msgs.msg.BatteryStatus data, Halodi.CDR.CDRSerializer cdr)
   {
      cdr.write_type_9(data.battery_status_level);

      cdr.write_type_6(data.battery_voltage);

      cdr.write_type_6(data.low_battery_voltage);

      cdr.write_type_6(data.shutdown_battery_voltage);

   }

   public static void read(halodi_msgs.msg.BatteryStatus data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.battery_status_level=cdr.read_type_9();
      	
      data.battery_voltage=cdr.read_type_6();
      	
      data.low_battery_voltage=cdr.read_type_6();
      	
      data.shutdown_battery_voltage=cdr.read_type_6();
      	

   }


    public static void Copy(halodi_msgs.msg.BatteryStatus src, halodi_msgs.msg.BatteryStatus target)
    {
        target.Set(src);
    }


}


}