// generated from rosidl_generator_cpp/resource/idl__struct.hpp.em
// with input from halodi_msgs:msg/WholeBodyTrajectory.idl
// generated code does not contain a copyright notice

#ifndef HALODI_MSGS__MSG__WHOLE_BODY_TRAJECTORY__STRUCT_HPP_
#define HALODI_MSGS__MSG__WHOLE_BODY_TRAJECTORY__STRUCT_HPP_

#include <rosidl_generator_cpp/bounded_vector.hpp>
#include <rosidl_generator_cpp/message_initialization.hpp>
#include <algorithm>
#include <array>
#include <memory>
#include <string>
#include <vector>


// Include directives for member types
// Member 'trajectory_id'
#include "unique_identifier_msgs/msg/uuid__struct.hpp"
// Member 'start_time'
#include "builtin_interfaces/msg/time__struct.hpp"
// Member 'balance_mode'
#include "halodi_msgs/msg/balance_mode__struct.hpp"
// Member 'interpolation_mode'
#include "halodi_msgs/msg/trajectory_interpolation__struct.hpp"
// Member 'trajectory_points'
#include "halodi_msgs/msg/whole_body_trajectory_point__struct.hpp"

#ifndef _WIN32
# define DEPRECATED__halodi_msgs__msg__WholeBodyTrajectory __attribute__((deprecated))
#else
# define DEPRECATED__halodi_msgs__msg__WholeBodyTrajectory __declspec(deprecated)
#endif

namespace halodi_msgs
{

namespace msg
{

// message struct
template<class ContainerAllocator>
struct WholeBodyTrajectory_
{
  using Type = WholeBodyTrajectory_<ContainerAllocator>;

  explicit WholeBodyTrajectory_(rosidl_generator_cpp::MessageInitialization _init = rosidl_generator_cpp::MessageInitialization::ALL)
  : trajectory_id(_init),
    interpolation_mode(_init)
  {
    if (rosidl_generator_cpp::MessageInitialization::ALL == _init ||
      rosidl_generator_cpp::MessageInitialization::ZERO == _init)
    {
      this->append_trajectory = false;
    }
  }

  explicit WholeBodyTrajectory_(const ContainerAllocator & _alloc, rosidl_generator_cpp::MessageInitialization _init = rosidl_generator_cpp::MessageInitialization::ALL)
  : trajectory_id(_alloc, _init),
    interpolation_mode(_alloc, _init)
  {
    if (rosidl_generator_cpp::MessageInitialization::ALL == _init ||
      rosidl_generator_cpp::MessageInitialization::ZERO == _init)
    {
      this->append_trajectory = false;
    }
  }

  // field types and members
  using _trajectory_id_type =
    unique_identifier_msgs::msg::UUID_<ContainerAllocator>;
  _trajectory_id_type trajectory_id;
  using _start_time_type =
    rosidl_generator_cpp::BoundedVector<builtin_interfaces::msg::Time_<ContainerAllocator>, 1, typename ContainerAllocator::template rebind<builtin_interfaces::msg::Time_<ContainerAllocator>>::other>;
  _start_time_type start_time;
  using _balance_mode_type =
    rosidl_generator_cpp::BoundedVector<halodi_msgs::msg::BalanceMode_<ContainerAllocator>, 1, typename ContainerAllocator::template rebind<halodi_msgs::msg::BalanceMode_<ContainerAllocator>>::other>;
  _balance_mode_type balance_mode;
  using _append_trajectory_type =
    bool;
  _append_trajectory_type append_trajectory;
  using _interpolation_mode_type =
    halodi_msgs::msg::TrajectoryInterpolation_<ContainerAllocator>;
  _interpolation_mode_type interpolation_mode;
  using _trajectory_points_type =
    rosidl_generator_cpp::BoundedVector<halodi_msgs::msg::WholeBodyTrajectoryPoint_<ContainerAllocator>, 255, typename ContainerAllocator::template rebind<halodi_msgs::msg::WholeBodyTrajectoryPoint_<ContainerAllocator>>::other>;
  _trajectory_points_type trajectory_points;

  // setters for named parameter idiom
  Type & set__trajectory_id(
    const unique_identifier_msgs::msg::UUID_<ContainerAllocator> & _arg)
  {
    this->trajectory_id = _arg;
    return *this;
  }
  Type & set__start_time(
    const rosidl_generator_cpp::BoundedVector<builtin_interfaces::msg::Time_<ContainerAllocator>, 1, typename ContainerAllocator::template rebind<builtin_interfaces::msg::Time_<ContainerAllocator>>::other> & _arg)
  {
    this->start_time = _arg;
    return *this;
  }
  Type & set__balance_mode(
    const rosidl_generator_cpp::BoundedVector<halodi_msgs::msg::BalanceMode_<ContainerAllocator>, 1, typename ContainerAllocator::template rebind<halodi_msgs::msg::BalanceMode_<ContainerAllocator>>::other> & _arg)
  {
    this->balance_mode = _arg;
    return *this;
  }
  Type & set__append_trajectory(
    const bool & _arg)
  {
    this->append_trajectory = _arg;
    return *this;
  }
  Type & set__interpolation_mode(
    const halodi_msgs::msg::TrajectoryInterpolation_<ContainerAllocator> & _arg)
  {
    this->interpolation_mode = _arg;
    return *this;
  }
  Type & set__trajectory_points(
    const rosidl_generator_cpp::BoundedVector<halodi_msgs::msg::WholeBodyTrajectoryPoint_<ContainerAllocator>, 255, typename ContainerAllocator::template rebind<halodi_msgs::msg::WholeBodyTrajectoryPoint_<ContainerAllocator>>::other> & _arg)
  {
    this->trajectory_points = _arg;
    return *this;
  }

  // constant declarations

  // pointer types
  using RawPtr =
    halodi_msgs::msg::WholeBodyTrajectory_<ContainerAllocator> *;
  using ConstRawPtr =
    const halodi_msgs::msg::WholeBodyTrajectory_<ContainerAllocator> *;
  using SharedPtr =
    std::shared_ptr<halodi_msgs::msg::WholeBodyTrajectory_<ContainerAllocator>>;
  using ConstSharedPtr =
    std::shared_ptr<halodi_msgs::msg::WholeBodyTrajectory_<ContainerAllocator> const>;

  template<typename Deleter = std::default_delete<
      halodi_msgs::msg::WholeBodyTrajectory_<ContainerAllocator>>>
  using UniquePtrWithDeleter =
    std::unique_ptr<halodi_msgs::msg::WholeBodyTrajectory_<ContainerAllocator>, Deleter>;

  using UniquePtr = UniquePtrWithDeleter<>;

  template<typename Deleter = std::default_delete<
      halodi_msgs::msg::WholeBodyTrajectory_<ContainerAllocator>>>
  using ConstUniquePtrWithDeleter =
    std::unique_ptr<halodi_msgs::msg::WholeBodyTrajectory_<ContainerAllocator> const, Deleter>;
  using ConstUniquePtr = ConstUniquePtrWithDeleter<>;

  using WeakPtr =
    std::weak_ptr<halodi_msgs::msg::WholeBodyTrajectory_<ContainerAllocator>>;
  using ConstWeakPtr =
    std::weak_ptr<halodi_msgs::msg::WholeBodyTrajectory_<ContainerAllocator> const>;

  // pointer types similar to ROS 1, use SharedPtr / ConstSharedPtr instead
  // NOTE: Can't use 'using' here because GNU C++ can't parse attributes properly
  typedef DEPRECATED__halodi_msgs__msg__WholeBodyTrajectory
    std::shared_ptr<halodi_msgs::msg::WholeBodyTrajectory_<ContainerAllocator>>
    Ptr;
  typedef DEPRECATED__halodi_msgs__msg__WholeBodyTrajectory
    std::shared_ptr<halodi_msgs::msg::WholeBodyTrajectory_<ContainerAllocator> const>
    ConstPtr;

  // comparison operators
  bool operator==(const WholeBodyTrajectory_ & other) const
  {
    if (this->trajectory_id != other.trajectory_id) {
      return false;
    }
    if (this->start_time != other.start_time) {
      return false;
    }
    if (this->balance_mode != other.balance_mode) {
      return false;
    }
    if (this->append_trajectory != other.append_trajectory) {
      return false;
    }
    if (this->interpolation_mode != other.interpolation_mode) {
      return false;
    }
    if (this->trajectory_points != other.trajectory_points) {
      return false;
    }
    return true;
  }
  bool operator!=(const WholeBodyTrajectory_ & other) const
  {
    return !this->operator==(other);
  }
};  // struct WholeBodyTrajectory_

// alias to use template instance with default allocator
using WholeBodyTrajectory =
  halodi_msgs::msg::WholeBodyTrajectory_<std::allocator<void>>;

// constant definitions

}  // namespace msg

}  // namespace halodi_msgs

#endif  // HALODI_MSGS__MSG__WHOLE_BODY_TRAJECTORY__STRUCT_HPP_
