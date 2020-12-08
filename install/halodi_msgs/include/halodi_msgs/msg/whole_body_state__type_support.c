// generated from rosidl_typesupport_introspection_c/resource/idl__type_support.c.em
// with input from halodi_msgs:msg/WholeBodyState.idl
// generated code does not contain a copyright notice

#include <stddef.h>
#include "halodi_msgs/msg/whole_body_state__rosidl_typesupport_introspection_c.h"
#include "halodi_msgs/msg/rosidl_typesupport_introspection_c__visibility_control.h"
#include "rosidl_typesupport_introspection_c/field_types.h"
#include "rosidl_typesupport_introspection_c/identifier.h"
#include "rosidl_typesupport_introspection_c/message_introspection.h"
#include "halodi_msgs/msg/whole_body_state__functions.h"
#include "halodi_msgs/msg/whole_body_state__struct.h"


// Include directives for member types
// Member `header`
#include "std_msgs/msg/header.h"
// Member `header`
#include "std_msgs/msg/header__rosidl_typesupport_introspection_c.h"
// Member `controller_state`
#include "rosidl_generator_c/string_functions.h"
// Member `current_balance_mode`
#include "halodi_msgs/msg/balance_mode.h"
// Member `current_balance_mode`
#include "halodi_msgs/msg/balance_mode__rosidl_typesupport_introspection_c.h"
// Member `pose`
#include "geometry_msgs/msg/pose.h"
// Member `pose`
#include "geometry_msgs/msg/pose__rosidl_typesupport_introspection_c.h"
// Member `angular_velocity`
// Member `linear_velocity`
#include "geometry_msgs/msg/vector3.h"
// Member `angular_velocity`
// Member `linear_velocity`
#include "geometry_msgs/msg/vector3__rosidl_typesupport_introspection_c.h"
// Member `imu_measurements`
#include "halodi_msgs/msg/imu_measurement.h"
// Member `imu_measurements`
#include "halodi_msgs/msg/imu_measurement__rosidl_typesupport_introspection_c.h"
// Member `joint_states`
#include "halodi_msgs/msg/joint_measurement.h"
// Member `joint_states`
#include "halodi_msgs/msg/joint_measurement__rosidl_typesupport_introspection_c.h"
// Member `taskspace_feedback`
#include "halodi_msgs/msg/task_space_feedback.h"
// Member `taskspace_feedback`
#include "halodi_msgs/msg/task_space_feedback__rosidl_typesupport_introspection_c.h"

#ifdef __cplusplus
extern "C"
{
#endif

void WholeBodyState__rosidl_typesupport_introspection_c__WholeBodyState_init_function(
  void * message_memory, enum rosidl_runtime_c_message_initialization _init)
{
  // TODO(karsten1987): initializers are not yet implemented for typesupport c
  // see https://github.com/ros2/ros2/issues/397
  (void) _init;
  halodi_msgs__msg__WholeBodyState__init(message_memory);
}

void WholeBodyState__rosidl_typesupport_introspection_c__WholeBodyState_fini_function(void * message_memory)
{
  halodi_msgs__msg__WholeBodyState__fini(message_memory);
}

size_t WholeBodyState__rosidl_typesupport_introspection_c__size_function__ImuMeasurement__imu_measurements(
  const void * untyped_member)
{
  const halodi_msgs__msg__ImuMeasurement__Sequence * member =
    (const halodi_msgs__msg__ImuMeasurement__Sequence *)(untyped_member);
  return member->size;
}

const void * WholeBodyState__rosidl_typesupport_introspection_c__get_const_function__ImuMeasurement__imu_measurements(
  const void * untyped_member, size_t index)
{
  const halodi_msgs__msg__ImuMeasurement__Sequence * member =
    (const halodi_msgs__msg__ImuMeasurement__Sequence *)(untyped_member);
  return &member->data[index];
}

void * WholeBodyState__rosidl_typesupport_introspection_c__get_function__ImuMeasurement__imu_measurements(
  void * untyped_member, size_t index)
{
  halodi_msgs__msg__ImuMeasurement__Sequence * member =
    (halodi_msgs__msg__ImuMeasurement__Sequence *)(untyped_member);
  return &member->data[index];
}

bool WholeBodyState__rosidl_typesupport_introspection_c__resize_function__ImuMeasurement__imu_measurements(
  void * untyped_member, size_t size)
{
  halodi_msgs__msg__ImuMeasurement__Sequence * member =
    (halodi_msgs__msg__ImuMeasurement__Sequence *)(untyped_member);
  halodi_msgs__msg__ImuMeasurement__Sequence__fini(member);
  return halodi_msgs__msg__ImuMeasurement__Sequence__init(member, size);
}

size_t WholeBodyState__rosidl_typesupport_introspection_c__size_function__JointMeasurement__joint_states(
  const void * untyped_member)
{
  const halodi_msgs__msg__JointMeasurement__Sequence * member =
    (const halodi_msgs__msg__JointMeasurement__Sequence *)(untyped_member);
  return member->size;
}

const void * WholeBodyState__rosidl_typesupport_introspection_c__get_const_function__JointMeasurement__joint_states(
  const void * untyped_member, size_t index)
{
  const halodi_msgs__msg__JointMeasurement__Sequence * member =
    (const halodi_msgs__msg__JointMeasurement__Sequence *)(untyped_member);
  return &member->data[index];
}

void * WholeBodyState__rosidl_typesupport_introspection_c__get_function__JointMeasurement__joint_states(
  void * untyped_member, size_t index)
{
  halodi_msgs__msg__JointMeasurement__Sequence * member =
    (halodi_msgs__msg__JointMeasurement__Sequence *)(untyped_member);
  return &member->data[index];
}

bool WholeBodyState__rosidl_typesupport_introspection_c__resize_function__JointMeasurement__joint_states(
  void * untyped_member, size_t size)
{
  halodi_msgs__msg__JointMeasurement__Sequence * member =
    (halodi_msgs__msg__JointMeasurement__Sequence *)(untyped_member);
  halodi_msgs__msg__JointMeasurement__Sequence__fini(member);
  return halodi_msgs__msg__JointMeasurement__Sequence__init(member, size);
}

size_t WholeBodyState__rosidl_typesupport_introspection_c__size_function__TaskSpaceFeedback__taskspace_feedback(
  const void * untyped_member)
{
  const halodi_msgs__msg__TaskSpaceFeedback__Sequence * member =
    (const halodi_msgs__msg__TaskSpaceFeedback__Sequence *)(untyped_member);
  return member->size;
}

const void * WholeBodyState__rosidl_typesupport_introspection_c__get_const_function__TaskSpaceFeedback__taskspace_feedback(
  const void * untyped_member, size_t index)
{
  const halodi_msgs__msg__TaskSpaceFeedback__Sequence * member =
    (const halodi_msgs__msg__TaskSpaceFeedback__Sequence *)(untyped_member);
  return &member->data[index];
}

void * WholeBodyState__rosidl_typesupport_introspection_c__get_function__TaskSpaceFeedback__taskspace_feedback(
  void * untyped_member, size_t index)
{
  halodi_msgs__msg__TaskSpaceFeedback__Sequence * member =
    (halodi_msgs__msg__TaskSpaceFeedback__Sequence *)(untyped_member);
  return &member->data[index];
}

bool WholeBodyState__rosidl_typesupport_introspection_c__resize_function__TaskSpaceFeedback__taskspace_feedback(
  void * untyped_member, size_t size)
{
  halodi_msgs__msg__TaskSpaceFeedback__Sequence * member =
    (halodi_msgs__msg__TaskSpaceFeedback__Sequence *)(untyped_member);
  halodi_msgs__msg__TaskSpaceFeedback__Sequence__fini(member);
  return halodi_msgs__msg__TaskSpaceFeedback__Sequence__init(member, size);
}

static rosidl_typesupport_introspection_c__MessageMember WholeBodyState__rosidl_typesupport_introspection_c__WholeBodyState_message_member_array[11] = {
  {
    "header",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    NULL,  // members of sub message (initialized later)
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs__msg__WholeBodyState, header),  // bytes offset in struct
    NULL,  // default value
    NULL,  // size() function pointer
    NULL,  // get_const(index) function pointer
    NULL,  // get(index) function pointer
    NULL  // resize(index) function pointer
  },
  {
    "last_received_sequence_id",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_INT32,  // type
    0,  // upper bound of string
    NULL,  // members of sub message
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs__msg__WholeBodyState, last_received_sequence_id),  // bytes offset in struct
    NULL,  // default value
    NULL,  // size() function pointer
    NULL,  // get_const(index) function pointer
    NULL,  // get(index) function pointer
    NULL  // resize(index) function pointer
  },
  {
    "controller_state",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_STRING,  // type
    0,  // upper bound of string
    NULL,  // members of sub message
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs__msg__WholeBodyState, controller_state),  // bytes offset in struct
    NULL,  // default value
    NULL,  // size() function pointer
    NULL,  // get_const(index) function pointer
    NULL,  // get(index) function pointer
    NULL  // resize(index) function pointer
  },
  {
    "current_balance_mode",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    NULL,  // members of sub message (initialized later)
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs__msg__WholeBodyState, current_balance_mode),  // bytes offset in struct
    NULL,  // default value
    NULL,  // size() function pointer
    NULL,  // get_const(index) function pointer
    NULL,  // get(index) function pointer
    NULL  // resize(index) function pointer
  },
  {
    "robot_status",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_OCTET,  // type
    0,  // upper bound of string
    NULL,  // members of sub message
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs__msg__WholeBodyState, robot_status),  // bytes offset in struct
    NULL,  // default value
    NULL,  // size() function pointer
    NULL,  // get_const(index) function pointer
    NULL,  // get(index) function pointer
    NULL  // resize(index) function pointer
  },
  {
    "pose",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    NULL,  // members of sub message (initialized later)
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs__msg__WholeBodyState, pose),  // bytes offset in struct
    NULL,  // default value
    NULL,  // size() function pointer
    NULL,  // get_const(index) function pointer
    NULL,  // get(index) function pointer
    NULL  // resize(index) function pointer
  },
  {
    "angular_velocity",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    NULL,  // members of sub message (initialized later)
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs__msg__WholeBodyState, angular_velocity),  // bytes offset in struct
    NULL,  // default value
    NULL,  // size() function pointer
    NULL,  // get_const(index) function pointer
    NULL,  // get(index) function pointer
    NULL  // resize(index) function pointer
  },
  {
    "linear_velocity",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    NULL,  // members of sub message (initialized later)
    false,  // is array
    0,  // array size
    false,  // is upper bound
    offsetof(halodi_msgs__msg__WholeBodyState, linear_velocity),  // bytes offset in struct
    NULL,  // default value
    NULL,  // size() function pointer
    NULL,  // get_const(index) function pointer
    NULL,  // get(index) function pointer
    NULL  // resize(index) function pointer
  },
  {
    "imu_measurements",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    NULL,  // members of sub message (initialized later)
    true,  // is array
    2,  // array size
    true,  // is upper bound
    offsetof(halodi_msgs__msg__WholeBodyState, imu_measurements),  // bytes offset in struct
    NULL,  // default value
    WholeBodyState__rosidl_typesupport_introspection_c__size_function__ImuMeasurement__imu_measurements,  // size() function pointer
    WholeBodyState__rosidl_typesupport_introspection_c__get_const_function__ImuMeasurement__imu_measurements,  // get_const(index) function pointer
    WholeBodyState__rosidl_typesupport_introspection_c__get_function__ImuMeasurement__imu_measurements,  // get(index) function pointer
    WholeBodyState__rosidl_typesupport_introspection_c__resize_function__ImuMeasurement__imu_measurements  // resize(index) function pointer
  },
  {
    "joint_states",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    NULL,  // members of sub message (initialized later)
    true,  // is array
    25,  // array size
    true,  // is upper bound
    offsetof(halodi_msgs__msg__WholeBodyState, joint_states),  // bytes offset in struct
    NULL,  // default value
    WholeBodyState__rosidl_typesupport_introspection_c__size_function__JointMeasurement__joint_states,  // size() function pointer
    WholeBodyState__rosidl_typesupport_introspection_c__get_const_function__JointMeasurement__joint_states,  // get_const(index) function pointer
    WholeBodyState__rosidl_typesupport_introspection_c__get_function__JointMeasurement__joint_states,  // get(index) function pointer
    WholeBodyState__rosidl_typesupport_introspection_c__resize_function__JointMeasurement__joint_states  // resize(index) function pointer
  },
  {
    "taskspace_feedback",  // name
    rosidl_typesupport_introspection_c__ROS_TYPE_MESSAGE,  // type
    0,  // upper bound of string
    NULL,  // members of sub message (initialized later)
    true,  // is array
    5,  // array size
    true,  // is upper bound
    offsetof(halodi_msgs__msg__WholeBodyState, taskspace_feedback),  // bytes offset in struct
    NULL,  // default value
    WholeBodyState__rosidl_typesupport_introspection_c__size_function__TaskSpaceFeedback__taskspace_feedback,  // size() function pointer
    WholeBodyState__rosidl_typesupport_introspection_c__get_const_function__TaskSpaceFeedback__taskspace_feedback,  // get_const(index) function pointer
    WholeBodyState__rosidl_typesupport_introspection_c__get_function__TaskSpaceFeedback__taskspace_feedback,  // get(index) function pointer
    WholeBodyState__rosidl_typesupport_introspection_c__resize_function__TaskSpaceFeedback__taskspace_feedback  // resize(index) function pointer
  }
};

static const rosidl_typesupport_introspection_c__MessageMembers WholeBodyState__rosidl_typesupport_introspection_c__WholeBodyState_message_members = {
  "halodi_msgs__msg",  // message namespace
  "WholeBodyState",  // message name
  11,  // number of fields
  sizeof(halodi_msgs__msg__WholeBodyState),
  WholeBodyState__rosidl_typesupport_introspection_c__WholeBodyState_message_member_array,  // message members
  WholeBodyState__rosidl_typesupport_introspection_c__WholeBodyState_init_function,  // function to initialize message memory (memory has to be allocated)
  WholeBodyState__rosidl_typesupport_introspection_c__WholeBodyState_fini_function  // function to terminate message instance (will not free memory)
};

// this is not const since it must be initialized on first access
// since C does not allow non-integral compile-time constants
static rosidl_message_type_support_t WholeBodyState__rosidl_typesupport_introspection_c__WholeBodyState_message_type_support_handle = {
  0,
  &WholeBodyState__rosidl_typesupport_introspection_c__WholeBodyState_message_members,
  get_message_typesupport_handle_function,
};

ROSIDL_TYPESUPPORT_INTROSPECTION_C_EXPORT_halodi_msgs
const rosidl_message_type_support_t *
ROSIDL_TYPESUPPORT_INTERFACE__MESSAGE_SYMBOL_NAME(rosidl_typesupport_introspection_c, halodi_msgs, msg, WholeBodyState)() {
  WholeBodyState__rosidl_typesupport_introspection_c__WholeBodyState_message_member_array[0].members_ =
    ROSIDL_TYPESUPPORT_INTERFACE__MESSAGE_SYMBOL_NAME(rosidl_typesupport_introspection_c, std_msgs, msg, Header)();
  WholeBodyState__rosidl_typesupport_introspection_c__WholeBodyState_message_member_array[3].members_ =
    ROSIDL_TYPESUPPORT_INTERFACE__MESSAGE_SYMBOL_NAME(rosidl_typesupport_introspection_c, halodi_msgs, msg, BalanceMode)();
  WholeBodyState__rosidl_typesupport_introspection_c__WholeBodyState_message_member_array[5].members_ =
    ROSIDL_TYPESUPPORT_INTERFACE__MESSAGE_SYMBOL_NAME(rosidl_typesupport_introspection_c, geometry_msgs, msg, Pose)();
  WholeBodyState__rosidl_typesupport_introspection_c__WholeBodyState_message_member_array[6].members_ =
    ROSIDL_TYPESUPPORT_INTERFACE__MESSAGE_SYMBOL_NAME(rosidl_typesupport_introspection_c, geometry_msgs, msg, Vector3)();
  WholeBodyState__rosidl_typesupport_introspection_c__WholeBodyState_message_member_array[7].members_ =
    ROSIDL_TYPESUPPORT_INTERFACE__MESSAGE_SYMBOL_NAME(rosidl_typesupport_introspection_c, geometry_msgs, msg, Vector3)();
  WholeBodyState__rosidl_typesupport_introspection_c__WholeBodyState_message_member_array[8].members_ =
    ROSIDL_TYPESUPPORT_INTERFACE__MESSAGE_SYMBOL_NAME(rosidl_typesupport_introspection_c, halodi_msgs, msg, ImuMeasurement)();
  WholeBodyState__rosidl_typesupport_introspection_c__WholeBodyState_message_member_array[9].members_ =
    ROSIDL_TYPESUPPORT_INTERFACE__MESSAGE_SYMBOL_NAME(rosidl_typesupport_introspection_c, halodi_msgs, msg, JointMeasurement)();
  WholeBodyState__rosidl_typesupport_introspection_c__WholeBodyState_message_member_array[10].members_ =
    ROSIDL_TYPESUPPORT_INTERFACE__MESSAGE_SYMBOL_NAME(rosidl_typesupport_introspection_c, halodi_msgs, msg, TaskSpaceFeedback)();
  if (!WholeBodyState__rosidl_typesupport_introspection_c__WholeBodyState_message_type_support_handle.typesupport_identifier) {
    WholeBodyState__rosidl_typesupport_introspection_c__WholeBodyState_message_type_support_handle.typesupport_identifier =
      rosidl_typesupport_introspection_c__identifier;
  }
  return &WholeBodyState__rosidl_typesupport_introspection_c__WholeBodyState_message_type_support_handle;
}
#ifdef __cplusplus
}
#endif
