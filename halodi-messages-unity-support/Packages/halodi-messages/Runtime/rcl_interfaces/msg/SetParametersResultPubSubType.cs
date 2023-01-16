using System.IO;
namespace rcl_interfaces.msg
{

/**
* 
* Topic data type of the struct "SetParametersResult" defined in "SetParametersResult.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from SetParametersResult.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit SetParametersResult.idl instead.
*
*/
public class SetParametersResultPubSubType : Halodi.CDR.TopicDataType<SetParametersResult>
{
   public override string Name => "rcl_interfaces::msg::dds_::SetParametersResult_";


   public static int getCdrSerializedSize(rcl_interfaces.msg.SetParametersResult data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(rcl_interfaces.msg.SetParametersResult data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 1 + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4) + data.reason.Length + 1;


      return current_alignment - initial_alignment;
   }

   public static void write(rcl_interfaces.msg.SetParametersResult data, Halodi.CDR.CDRSerializer cdr)
   {
      cdr.write_type_7(data.successful);

      cdr.write_type_d(data.reason);

   }

   public static void read(rcl_interfaces.msg.SetParametersResult data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.successful=cdr.read_type_7();
      	
      data.reason = cdr.read_type_d();	

   }


	public override void Serialize(rcl_interfaces.msg.SetParametersResult data, Halodi.CDR.CDRSerializer cdr)
   	{
   		write(data, cdr);	
   	}

	public override void Deserialize(rcl_interfaces.msg.SetParametersResult data, Halodi.CDR.CDRDeserializer cdr)
   	{
   		read(data, cdr);	
   	}
   	
   	public override int GetSize(rcl_interfaces.msg.SetParametersResult data)
   	{
   		return getCdrSerializedSize(data);
   	}

    public static void Copy(rcl_interfaces.msg.SetParametersResult src, rcl_interfaces.msg.SetParametersResult target)
    {
        target.Set(src);
    }
    
    public override void CopyTo(rcl_interfaces.msg.SetParametersResult src, rcl_interfaces.msg.SetParametersResult target)
    {
    	Copy(src, target);
    }


}


}