using System.IO;
namespace rcl_interfaces.msg
{

/**
* 
* Topic data type of the struct "Parameter" defined in "Parameter.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from Parameter.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit Parameter.idl instead.
*
*/
public class ParameterPubSubType : Halodi.CDR.TopicDataType<Parameter>
{
   public override string Name => "rcl_interfaces::msg::dds_::Parameter_";


   
   public override void serialize(rcl_interfaces.msg.Parameter data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, rcl_interfaces.msg.Parameter data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(rcl_interfaces.msg.Parameter data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(rcl_interfaces.msg.Parameter data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4) + data.name.Length + 1;

      current_alignment += rcl_interfaces.msg.ParameterValuePubSubType.getCdrSerializedSize(data.value, current_alignment);


      return current_alignment - initial_alignment;
   }

   public static void write(rcl_interfaces.msg.Parameter data, Halodi.CDR.CDRSerializer cdr)
   {
      cdr.write_type_d(data.name);

      rcl_interfaces.msg.ParameterValuePubSubType.write(data.value, cdr);

   }

   public static void read(rcl_interfaces.msg.Parameter data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.name = cdr.read_type_d();	
      data.value = rcl_interfaces.msg.ParameterValuePubSubType.Create();
      rcl_interfaces.msg.ParameterValuePubSubType.read(data.value, cdr);
      	

   }


    public static void Copy(rcl_interfaces.msg.Parameter src, rcl_interfaces.msg.Parameter target)
    {
        target.Set(src);
    }


}


}