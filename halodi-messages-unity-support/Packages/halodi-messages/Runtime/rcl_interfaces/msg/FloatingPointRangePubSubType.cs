using System.IO;
namespace rcl_interfaces.msg
{

/**
* 
* Topic data type of the struct "FloatingPointRange" defined in "FloatingPointRange.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from FloatingPointRange.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit FloatingPointRange.idl instead.
*
*/
public class FloatingPointRangePubSubType : Halodi.CDR.TopicDataType<rcl_interfaces.msg.FloatingPointRange>
{
   public override string Name => "rcl_interfaces::msg::dds_::FloatingPointRange_";


   
   public override void serialize(rcl_interfaces.msg.FloatingPointRange data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, rcl_interfaces.msg.FloatingPointRange data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(rcl_interfaces.msg.FloatingPointRange data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(rcl_interfaces.msg.FloatingPointRange data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);



      return current_alignment - initial_alignment;
   }

   public static void write(rcl_interfaces.msg.FloatingPointRange data, Halodi.CDR.CDRSerializer cdr)
   {
      cdr.write_type_6(data.from_value);

      cdr.write_type_6(data.to_value);

      cdr.write_type_6(data.step);

   }

   public static void read(rcl_interfaces.msg.FloatingPointRange data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.from_value=cdr.read_type_6();
      	
      data.to_value=cdr.read_type_6();
      	
      data.step=cdr.read_type_6();
      	

   }


    public static void Copy(rcl_interfaces.msg.FloatingPointRange src, rcl_interfaces.msg.FloatingPointRange target)
    {
        target.Set(src);
    }


}


}