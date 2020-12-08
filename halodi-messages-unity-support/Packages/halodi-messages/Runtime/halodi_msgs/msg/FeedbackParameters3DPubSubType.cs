using System.IO;
namespace halodi_msgs.msg
{

/**
* 
* Topic data type of the struct "FeedbackParameters3D" defined in "FeedbackParameters3D.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from FeedbackParameters3D.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit FeedbackParameters3D.idl instead.
*
*/
public class FeedbackParameters3DPubSubType : Halodi.CDR.TopicDataType<FeedbackParameters3D>
{
   public override string Name => "halodi_msgs::msg::FeedbackParameters3D";


   
   public override void serialize(halodi_msgs.msg.FeedbackParameters3D data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, halodi_msgs.msg.FeedbackParameters3D data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(halodi_msgs.msg.FeedbackParameters3D data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(halodi_msgs.msg.FeedbackParameters3D data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += geometry_msgs.msg.Vector3PubSubType.getCdrSerializedSize(data.proportional, current_alignment);

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.integral.Count; ++i0)
      {
          current_alignment += geometry_msgs.msg.Vector3PubSubType.getCdrSerializedSize(data.integral[i0], current_alignment);}

      current_alignment += geometry_msgs.msg.Vector3PubSubType.getCdrSerializedSize(data.derivative, current_alignment);

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      current_alignment += (data.maximum_proportional_error.Count * 8) + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      current_alignment += (data.maximum_integral_windup.Count * 8) + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      current_alignment += (data.maximum_derivative_error.Count * 8) + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      current_alignment += (data.maximum_feedback.Count * 8) + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      current_alignment += (data.maximum_feedback_rate.Count * 8) + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      current_alignment += (data.integral_leakage.Count * 8) + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);



      return current_alignment - initial_alignment;
   }

   public static void write(halodi_msgs.msg.FeedbackParameters3D data, Halodi.CDR.CDRSerializer cdr)
   {
      geometry_msgs.msg.Vector3PubSubType.write(data.proportional, cdr);

      	if(data.integral == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int integral_length = data.integral.Count;
            cdr.write_type_2(integral_length);
            for (int i0 = 0; i0 < integral_length; i0++)
            {
      			geometry_msgs.msg.Vector3PubSubType.write(data.integral[i0], cdr);	      }
        }
      geometry_msgs.msg.Vector3PubSubType.write(data.derivative, cdr);

      	if(data.maximum_proportional_error == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int maximum_proportional_error_length = data.maximum_proportional_error.Count;
            cdr.write_type_2(maximum_proportional_error_length);
            for (int i0 = 0; i0 < maximum_proportional_error_length; i0++)
            {
      			cdr.write_type_6(data.maximum_proportional_error[i0]);
            }
        }
      	if(data.maximum_integral_windup == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int maximum_integral_windup_length = data.maximum_integral_windup.Count;
            cdr.write_type_2(maximum_integral_windup_length);
            for (int i0 = 0; i0 < maximum_integral_windup_length; i0++)
            {
      			cdr.write_type_6(data.maximum_integral_windup[i0]);
            }
        }
      	if(data.maximum_derivative_error == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int maximum_derivative_error_length = data.maximum_derivative_error.Count;
            cdr.write_type_2(maximum_derivative_error_length);
            for (int i0 = 0; i0 < maximum_derivative_error_length; i0++)
            {
      			cdr.write_type_6(data.maximum_derivative_error[i0]);
            }
        }
      	if(data.maximum_feedback == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int maximum_feedback_length = data.maximum_feedback.Count;
            cdr.write_type_2(maximum_feedback_length);
            for (int i0 = 0; i0 < maximum_feedback_length; i0++)
            {
      			cdr.write_type_6(data.maximum_feedback[i0]);
            }
        }
      	if(data.maximum_feedback_rate == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int maximum_feedback_rate_length = data.maximum_feedback_rate.Count;
            cdr.write_type_2(maximum_feedback_rate_length);
            for (int i0 = 0; i0 < maximum_feedback_rate_length; i0++)
            {
      			cdr.write_type_6(data.maximum_feedback_rate[i0]);
            }
        }
      	if(data.integral_leakage == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int integral_leakage_length = data.integral_leakage.Count;
            cdr.write_type_2(integral_leakage_length);
            for (int i0 = 0; i0 < integral_leakage_length; i0++)
            {
      			cdr.write_type_6(data.integral_leakage[i0]);
            }
        }
   }

   public static void read(halodi_msgs.msg.FeedbackParameters3D data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.proportional = geometry_msgs.msg.Vector3PubSubType.Create();
      geometry_msgs.msg.Vector3PubSubType.read(data.proportional, cdr);
      	

      int integral_length = cdr.read_type_2();
      data.integral = new System.Collections.Generic.List<geometry_msgs.msg.Vector3>(integral_length);
      for(int i = 0; i < integral_length; i++)
      {
      	geometry_msgs.msg.Vector3 new_integral = geometry_msgs.msg.Vector3PubSubType.Create(); 
      	geometry_msgs.msg.Vector3PubSubType.read(new_integral, cdr);
      	data.integral.Add(new_integral);	
      	
      }

      	
      data.derivative = geometry_msgs.msg.Vector3PubSubType.Create();
      geometry_msgs.msg.Vector3PubSubType.read(data.derivative, cdr);
      	

      int maximum_proportional_error_length = cdr.read_type_2();
      data.maximum_proportional_error = new System.Collections.Generic.List<double>(maximum_proportional_error_length);
      for(int i = 0; i < maximum_proportional_error_length; i++)
      {
      	data.maximum_proportional_error.Add(cdr.read_type_6());
      	
      	
      }

      	

      int maximum_integral_windup_length = cdr.read_type_2();
      data.maximum_integral_windup = new System.Collections.Generic.List<double>(maximum_integral_windup_length);
      for(int i = 0; i < maximum_integral_windup_length; i++)
      {
      	data.maximum_integral_windup.Add(cdr.read_type_6());
      	
      	
      }

      	

      int maximum_derivative_error_length = cdr.read_type_2();
      data.maximum_derivative_error = new System.Collections.Generic.List<double>(maximum_derivative_error_length);
      for(int i = 0; i < maximum_derivative_error_length; i++)
      {
      	data.maximum_derivative_error.Add(cdr.read_type_6());
      	
      	
      }

      	

      int maximum_feedback_length = cdr.read_type_2();
      data.maximum_feedback = new System.Collections.Generic.List<double>(maximum_feedback_length);
      for(int i = 0; i < maximum_feedback_length; i++)
      {
      	data.maximum_feedback.Add(cdr.read_type_6());
      	
      	
      }

      	

      int maximum_feedback_rate_length = cdr.read_type_2();
      data.maximum_feedback_rate = new System.Collections.Generic.List<double>(maximum_feedback_rate_length);
      for(int i = 0; i < maximum_feedback_rate_length; i++)
      {
      	data.maximum_feedback_rate.Add(cdr.read_type_6());
      	
      	
      }

      	

      int integral_leakage_length = cdr.read_type_2();
      data.integral_leakage = new System.Collections.Generic.List<double>(integral_leakage_length);
      for(int i = 0; i < integral_leakage_length; i++)
      {
      	data.integral_leakage.Add(cdr.read_type_6());
      	
      	
      }

      	

   }


    public static void Copy(halodi_msgs.msg.FeedbackParameters3D src, halodi_msgs.msg.FeedbackParameters3D target)
    {
        target.Set(src);
    }


}


}