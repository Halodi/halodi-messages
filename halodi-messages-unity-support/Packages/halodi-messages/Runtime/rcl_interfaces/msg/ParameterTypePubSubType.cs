using System.IO;
namespace rcl_interfaces.msg
{

/**
* 
* Topic data type of the struct "ParameterType" defined in "ParameterType.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from ParameterType.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit ParameterType.idl instead.
*
*/
public class ParameterTypePubSubType : Halodi.CDR.TopicDataType<ParameterType>
{
   public override string Name => "rcl_interfaces::msg::dds_::ParameterType_";


   
   public override void serialize(rcl_interfaces.msg.ParameterType data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, rcl_interfaces.msg.ParameterType data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(rcl_interfaces.msg.ParameterType data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(rcl_interfaces.msg.ParameterType data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 1 + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);



      return current_alignment - initial_alignment;
   }

   public static void write(rcl_interfaces.msg.ParameterType data, Halodi.CDR.CDRSerializer cdr)
   {
      cdr.write_type_7(data.unused_placeholder_field);

   }

   public static void read(rcl_interfaces.msg.ParameterType data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.unused_placeholder_field=cdr.read_type_7();
      	

   }


    public static void Copy(rcl_interfaces.msg.ParameterType src, rcl_interfaces.msg.ParameterType target)
    {
        target.Set(src);
    }


}


}