using System.IO;
namespace rcl_interfaces.msg
{

/**
* 
* Topic data type of the struct "ParameterEvent" defined in "ParameterEvent.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from ParameterEvent.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit ParameterEvent.idl instead.
*
*/
public class ParameterEventPubSubType : Halodi.CDR.TopicDataType<ParameterEvent>
{
   public override string Name => "rcl_interfaces::msg::dds_::ParameterEvent_";


   public static int getCdrSerializedSize(rcl_interfaces.msg.ParameterEvent data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(rcl_interfaces.msg.ParameterEvent data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += builtin_interfaces.msg.TimePubSubType.getCdrSerializedSize(data.stamp, current_alignment);

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4) + data.node.Length + 1;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.new_parameters.Count; ++i0)
      {
          current_alignment += rcl_interfaces.msg.ParameterPubSubType.getCdrSerializedSize(data.new_parameters[i0], current_alignment);}

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.changed_parameters.Count; ++i0)
      {
          current_alignment += rcl_interfaces.msg.ParameterPubSubType.getCdrSerializedSize(data.changed_parameters[i0], current_alignment);}

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.deleted_parameters.Count; ++i0)
      {
          current_alignment += rcl_interfaces.msg.ParameterPubSubType.getCdrSerializedSize(data.deleted_parameters[i0], current_alignment);}


      return current_alignment - initial_alignment;
   }

   public static void write(rcl_interfaces.msg.ParameterEvent data, Halodi.CDR.CDRSerializer cdr)
   {
      builtin_interfaces.msg.TimePubSubType.write(data.stamp, cdr);

      cdr.write_type_d(data.node);

      	if(data.new_parameters == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int new_parameters_length = data.new_parameters.Count;
            cdr.write_type_2(new_parameters_length);
            for (int i0 = 0; i0 < new_parameters_length; i0++)
            {
      			rcl_interfaces.msg.ParameterPubSubType.write(data.new_parameters[i0], cdr);	      }
        }
      	if(data.changed_parameters == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int changed_parameters_length = data.changed_parameters.Count;
            cdr.write_type_2(changed_parameters_length);
            for (int i0 = 0; i0 < changed_parameters_length; i0++)
            {
      			rcl_interfaces.msg.ParameterPubSubType.write(data.changed_parameters[i0], cdr);	      }
        }
      	if(data.deleted_parameters == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int deleted_parameters_length = data.deleted_parameters.Count;
            cdr.write_type_2(deleted_parameters_length);
            for (int i0 = 0; i0 < deleted_parameters_length; i0++)
            {
      			rcl_interfaces.msg.ParameterPubSubType.write(data.deleted_parameters[i0], cdr);	      }
        }
   }

   public static void read(rcl_interfaces.msg.ParameterEvent data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.stamp = builtin_interfaces.msg.TimePubSubType.Create();
      builtin_interfaces.msg.TimePubSubType.read(data.stamp, cdr);
      	
      data.node = cdr.read_type_d();	

      int new_parameters_length = cdr.read_type_2();
      data.new_parameters = new System.Collections.Generic.List<rcl_interfaces.msg.Parameter>(new_parameters_length);
      for(int i = 0; i < new_parameters_length; i++)
      {
      	rcl_interfaces.msg.Parameter new_new_parameters = rcl_interfaces.msg.ParameterPubSubType.Create(); 
      	rcl_interfaces.msg.ParameterPubSubType.read(new_new_parameters, cdr);
      	data.new_parameters.Add(new_new_parameters);	
      	
      }

      	

      int changed_parameters_length = cdr.read_type_2();
      data.changed_parameters = new System.Collections.Generic.List<rcl_interfaces.msg.Parameter>(changed_parameters_length);
      for(int i = 0; i < changed_parameters_length; i++)
      {
      	rcl_interfaces.msg.Parameter new_changed_parameters = rcl_interfaces.msg.ParameterPubSubType.Create(); 
      	rcl_interfaces.msg.ParameterPubSubType.read(new_changed_parameters, cdr);
      	data.changed_parameters.Add(new_changed_parameters);	
      	
      }

      	

      int deleted_parameters_length = cdr.read_type_2();
      data.deleted_parameters = new System.Collections.Generic.List<rcl_interfaces.msg.Parameter>(deleted_parameters_length);
      for(int i = 0; i < deleted_parameters_length; i++)
      {
      	rcl_interfaces.msg.Parameter new_deleted_parameters = rcl_interfaces.msg.ParameterPubSubType.Create(); 
      	rcl_interfaces.msg.ParameterPubSubType.read(new_deleted_parameters, cdr);
      	data.deleted_parameters.Add(new_deleted_parameters);	
      	
      }

      	

   }


	public override void Serialize(rcl_interfaces.msg.ParameterEvent data, Halodi.CDR.CDRSerializer cdr)
   	{
   		write(data, cdr);	
   	}

	public override void Deserialize(rcl_interfaces.msg.ParameterEvent data, Halodi.CDR.CDRDeserializer cdr)
   	{
   		read(data, cdr);	
   	}
   	
   	public override int GetSize(rcl_interfaces.msg.ParameterEvent data)
   	{
   		return getCdrSerializedSize(data);
   	}

    public static void Copy(rcl_interfaces.msg.ParameterEvent src, rcl_interfaces.msg.ParameterEvent target)
    {
        target.Set(src);
    }
    
    public override void CopyTo(rcl_interfaces.msg.ParameterEvent src, rcl_interfaces.msg.ParameterEvent target)
    {
    	Copy(src, target);
    }


}


}