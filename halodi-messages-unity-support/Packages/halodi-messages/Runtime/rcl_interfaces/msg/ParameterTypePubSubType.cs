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


	public override void Serialize(rcl_interfaces.msg.ParameterType data, Halodi.CDR.CDRSerializer cdr)
   	{
   		write(data, cdr);	
   	}

	public override void Deserialize(rcl_interfaces.msg.ParameterType data, Halodi.CDR.CDRDeserializer cdr)
   	{
   		read(data, cdr);	
   	}
   	
   	public override int GetSize(rcl_interfaces.msg.ParameterType data)
   	{
   		return getCdrSerializedSize(data);
   	}

    public static void Copy(rcl_interfaces.msg.ParameterType src, rcl_interfaces.msg.ParameterType target)
    {
        target.Set(src);
    }
    
    public override void CopyTo(rcl_interfaces.msg.ParameterType src, rcl_interfaces.msg.ParameterType target)
    {
    	Copy(src, target);
    }


}


}