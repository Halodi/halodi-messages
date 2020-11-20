using System.IO;
namespace halodi_msgs.msg
{

/**
* 
* Topic data type of the struct "PassivityData" defined in "PassivityData.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from PassivityData.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit PassivityData.idl instead.
*
*/
public class PassivityDataPubSubType : Halodi.CDR.TopicDataType<PassivityData>
{
   public override string Name => "halodi_msgs::msg::dds_::PassivityData_";


   
   public override void serialize(halodi_msgs.msg.PassivityData data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, halodi_msgs.msg.PassivityData data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(halodi_msgs.msg.PassivityData data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(halodi_msgs.msg.PassivityData data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);



      return current_alignment - initial_alignment;
   }

   public static void write(halodi_msgs.msg.PassivityData data, Halodi.CDR.CDRSerializer cdr)
   {
      cdr.write_type_6(data.energy_packet);

      cdr.write_type_6(data.energy_tank_level);

      cdr.write_type_6(data.virtual_mass);

   }

   public static void read(halodi_msgs.msg.PassivityData data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.energy_packet=cdr.read_type_6();
      	
      data.energy_tank_level=cdr.read_type_6();
      	
      data.virtual_mass=cdr.read_type_6();
      	

   }


    public static void Copy(halodi_msgs.msg.PassivityData src, halodi_msgs.msg.PassivityData target)
    {
        target.Set(src);
    }


}


}