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


	public override void Serialize(rcl_interfaces.msg.Parameter data, Halodi.CDR.CDRSerializer cdr)
   	{
   		write(data, cdr);	
   	}

	public override void Deserialize(rcl_interfaces.msg.Parameter data, Halodi.CDR.CDRDeserializer cdr)
   	{
   		read(data, cdr);	
   	}
   	
   	public override int GetSize(rcl_interfaces.msg.Parameter data)
   	{
   		return getCdrSerializedSize(data);
   	}

    public static void Copy(rcl_interfaces.msg.Parameter src, rcl_interfaces.msg.Parameter target)
    {
        target.Set(src);
    }
    
    public override void CopyTo(rcl_interfaces.msg.Parameter src, rcl_interfaces.msg.Parameter target)
    {
    	Copy(src, target);
    }


}


}